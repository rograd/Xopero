using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Timers;
using IniParser.Model;

namespace IssueObserver
{
    using Change;
    using Worker;

    class Target
    {
        public string Owner;
        public string Repository;

        public Target(KeyDataCollection data)
        {
            Owner = data["Owner"];
            Repository = data["Repository"];
        }
    }

    class Observer : Timer
    {
        private List<IChange> _previousChanges;
        private Mailer _mailer;
        private Fetcher _fetcher;

        public Observer(int interval, Fetcher fetcher, Mailer mailer) : base(interval * 1000)
        {
            _fetcher = fetcher;
            _mailer = mailer;
            Elapsed += CheckChanges;
        }

        private async void CheckChanges(object sender, ElapsedEventArgs e)
        {
            List<IChange> changes = await _fetcher.GetChanges();
            CompareChanges(changes);
            _previousChanges = changes;
        }

        public async Task Watch()
        {
            _previousChanges = await _fetcher.GetChanges();
            Start();
        }

        private async void CompareChanges(List<IChange> changes)
        {
            var previousIssues = _previousChanges.OfType<Issue>().ToList();
            foreach (var change in changes)
            {
                // new issue or comment
                if (!_previousChanges.Exists(c => c.Id == change.Id)) await _mailer.SendChangeCreated(change);
                // issue closed
                else if (change is Issue issue)
                {
                    State previousState = previousIssues.Find(i => i.Id == issue.Id).State;
                    bool stateChanged = issue.State != previousState;
                    bool isClosed = issue.State == State.Closed;
                    if (stateChanged && isClosed) await _mailer.SendIssueClosed(issue);
                }
            }
        }
    }
}
