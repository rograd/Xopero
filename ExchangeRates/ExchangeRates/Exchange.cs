using System.Net.Http.Headers;
using System.Net.Http.Json;

namespace ExchangeRates;

class Exchange
{
    private HttpClient httpClient = new HttpClient();
    private string[] codes = { "USD", "EUR", "GBP", "CZK", "SEK", "AUD" };
    private string url = "https://api.nbp.pl/api/exchangerates/tables/c";

    public async Task<List<JSONModel.Rate>> FetchRates()
    {
        // request
        HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, url);
        request.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

        // response
        HttpResponseMessage response = await httpClient.SendAsync(request);

        // process
        var data = await response.Content.ReadFromJsonAsync<List<JSONModel.Table>>();
        List<JSONModel.Rate> rates = data[0].Rates;

        // filter
        rates = rates.FindAll(rate => codes.Contains(rate.Code));

        return rates;
    }

    public void DisplayRates(List<JSONModel.Rate> rates, JSONModel.Rate selected)
    {
        Console.Clear();
        Console.WriteLine("Waluty:");
        rates.ForEach(rate =>
        {
            string marker = rate.Equals(selected) ? $"[■] {rate.ExchangeRate} PLN" : "[ ]";
            Console.WriteLine($"{rate.Code} {marker}");
        });
        Console.WriteLine("Enter, aby zakończyć...");
    }
}