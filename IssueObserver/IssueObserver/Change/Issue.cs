using System.Text.Json.Serialization;

namespace IssueObserver.Change
{
    enum State
    {
        Open,
        Closed
    }

    class Issue : IChange
    {
        public int Id { get; set; }
        public string Title;

        [JsonConverter(typeof(JsonStringEnumConverter))]
        public State State { get; set; }

        [JsonPropertyName("html_url")]
        public string HtmlUrl { get; set; }
    }
}
