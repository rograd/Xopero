using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace RepoManager
{
    class Manager
    {
        private string _username;

        private HttpClient httpClient = new()
        {
            BaseAddress = new Uri("https://api.github.com"),
            DefaultRequestHeaders =
            {
                Accept = { new MediaTypeWithQualityHeaderValue("application/vnd.github.v3+json") },
                UserAgent = { new ProductInfoHeaderValue("RepoManager", "1.0") }
            }
        };

        public Manager(string token)
        {
            httpClient.DefaultRequestHeaders.Authorization = new("Token", token);
        }

        public async Task<bool> Authorize()
        {
            var response = await httpClient.GetAsync("/user");
            if (!response.IsSuccessStatusCode) return false;

            JObject user = JObject.Parse(await response.Content.ReadAsStringAsync());
            string username = (string)user["login"];
            _username = username;
            return true;
        }

        class Repository
        {
            public string Name { get; set; }
        }

        public async Task<string[]> GetRepositoryNames()
        {
            string endpoint = "/user/repos";
            var response = await httpClient.GetAsync(endpoint);
            var repos = await response.Content.ReadFromJsonAsync<List<Repository>>();
            IEnumerable<string> names = repos.Select(repos => repos.Name);
            return names.ToArray();
        }

        public async Task CreateRepository(string name)
        {
            string endpoint = "/user/repos";
            var payload = new { name };
            var response = await httpClient.PostAsJsonAsync(endpoint, payload);
            Logger.DisplayResult(name, response.StatusCode);
        }

        public async Task DeleteRepository(string name)
        {
            string endpoint = $"/repos/{_username}/{name}";
            var response = await httpClient.DeleteAsync(endpoint);
            Logger.DisplayResult(name, response.StatusCode);
        }
    }
}
