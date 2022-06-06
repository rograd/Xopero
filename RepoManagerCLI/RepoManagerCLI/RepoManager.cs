using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace RepoManagerCLI
{
    class RepoManager
    {
        private string Username;

        private HttpClient httpClient = new()
        {
            BaseAddress = new Uri("https://api.github.com"),
            DefaultRequestHeaders =
            {
                Accept = { new MediaTypeWithQualityHeaderValue("application/vnd.github.v3+json") },
                UserAgent = { new ProductInfoHeaderValue("RepoManager", "1.0") }
            }
        };

        async private Task<string> CheckLogin()
        {
            var response = await httpClient.GetAsync("/user");
            JObject user = JObject.Parse(await response.Content.ReadAsStringAsync());
            string login = (string)user["login"];
            return login;
        }

        public RepoManager(string token)
        {
            httpClient.DefaultRequestHeaders
                .Authorization = new AuthenticationHeaderValue("Token", token);
            Username = CheckLogin().Result;
        }

        async public Task<HttpResponseMessage> CreateRepository(string name)
        {
            string endpoint = "/user/repos";
            var payload = new { name };
            var response = await httpClient.PostAsJsonAsync(endpoint, payload);
            return response;
        }

        public async Task<HttpResponseMessage> DeleteRepository(string name)
        {
            string endpoint = $"/repos/{Username}/{name}";
            var response = await httpClient.DeleteAsync(endpoint);
            return response;
        }
    }
}
