using System.Text.Json.Serialization;

namespace IssueObserver.Change
{
    class Comment : IChange
    {
        public int Id { get; set; }
        public string Body { get; set; }

        [JsonPropertyName("html_url")]
        public string HtmlUrl { get; set; }
    }
}
