using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;
using IniParser.Model;

namespace IssueObserver.Worker
{
    using Change;

    class Mailer : SmtpClient
    {
        private MailMessage _message;

        public Mailer(KeyDataCollection data) : base(data["Host"])
        {
            Port = int.Parse(data["Port"]);
            string username = data["Username"];
            Credentials = new NetworkCredential(username, data["Password"]);
            EnableSsl = bool.Parse(data["EnableSsl"]);
            _message = new(username, data["To"]);
        }

        public async Task SendChangeCreated(IChange change)
        {
            string changeType = change.GetType().Name.ToLower();
            _message.Subject = $"[New {changeType}]";
            _message.Body = change.HtmlUrl;
            await SendMailAsync(_message);
        }

        public async Task SendIssueClosed(Issue issue)
        {
            _message.Subject = $"[Issue closed] {issue.Title}";
            _message.Body = issue.HtmlUrl;
            await SendMailAsync(_message);
        }
    }
}
