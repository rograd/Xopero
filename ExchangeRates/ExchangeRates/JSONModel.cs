using System.Text.Json.Serialization;

namespace ExchangeRates;

public class JSONModel
{
    public class Rate
    {
        [JsonPropertyName("currency")]
        public string Currency { get; set; }
        
        [JsonPropertyName("code")]
        public string Code { get; set; }

        [JsonPropertyName("ask")]
        public double ExchangeRate { get; set; }
    }

    public class Table
    {
        [JsonPropertyName("rates")]
        public List<Rate> Rates { get; set; }
    }
}