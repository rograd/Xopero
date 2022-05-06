namespace ExchangeRates;

class Program
{
    static async Task Main(string[] args)
    {
        Exchange exchange = new Exchange();
        List<JSONModel.Rate> rates = await exchange.FetchRates();

        int index = 0;
        JSONModel.Rate selected = rates[index];

        ConsoleKeyInfo keyInfo;
        do
        {
            exchange.DisplayRates(rates, selected);

            keyInfo = Console.ReadKey();
            switch (keyInfo.Key)
            {
                case ConsoleKey.UpArrow:
                    if (--index < 0)
                        index = rates.Count - 1;
                    break;

                case ConsoleKey.DownArrow:
                    index++;
                    index %= rates.Count;
                    break;

                default:
                    break;
            }

            selected = rates[index];
        } while (keyInfo.Key != ConsoleKey.Enter);

        Console.Clear();
        Console.WriteLine($"{selected.Currency} ({selected.Code}): {selected.ExchangeRate} PLN");
    }
}