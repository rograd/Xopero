using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Json;
using System.Net.Http.Headers;

namespace IssueObserver.Worker
{
    using Change;

    class Fetcher : HttpClient
    {
        private Target _target;
        public Fetcher(Target target)
        {
            _target = target;
            BaseAddress = new("https://api.github.com");
            DefaultRequestHeaders.Accept.Add(new("application/vnd.github.v3+json"));
            DefaultRequestHeaders.UserAgent.Add(new("IssueObserver", "1.0"));
        }

        public async Task Authorize(string token)
        {
            AuthenticationHeaderValue authorization = new("Token", token);
            DefaultRequestHeaders.Authorization = authorization;
            var response = await GetAsync("/user");
            response.EnsureSuccessStatusCode();
        }

        public async Task<List<IChange>> GetChanges()
        {
            string endpoint = $"/repos/{_target.Owner}/{_target.Repository}/issues";
            List<IChange> changes = new();
            List<Issue> issues = await GetListOfType<Issue>($"{endpoint}?state=all");
            List<Comment> comments = await GetListOfType<Comment>($"{endpoint}/comments");
            changes = changes.Concat(issues)
                             .Concat(comments)
                             .ToList();

            return changes;
        }

        private async Task<List<T>> GetListOfType<T>(string endpoint) where T : IChange
        {
            var response = await GetAsync(endpoint);
            List<T> data = await response.Content.ReadFromJsonAsync<List<T>>();
            return data;
        }
    }
}
