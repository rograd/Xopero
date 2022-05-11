namespace Hashing;

class Program
{
    private static IHashStrategy[] algorithms = new IHashStrategy[] {
        new MD5Strategy(),
        new SHA1Strategy(),
        new SHA256Strategy(),
        new BCryptStrategy()
    };

    static void Main(string[] args)
    {
        int index = 0;
        IHashStrategy selectedAlgorithm = algorithms[index];

        ConsoleKeyInfo keyInfo;
        do
        {
            DisplayAlgorithms(selectedAlgorithm);
            keyInfo = Console.ReadKey();

            switch (keyInfo.Key)
            {
                case ConsoleKey.UpArrow:
                    if (--index < 0)
                        index = algorithms.Length - 1;
                    break;

                case ConsoleKey.DownArrow:
                    index++;
                    index %= algorithms.Length;
                    break;

                default:
                    break;
            }

            selectedAlgorithm = algorithms[index];
        } while (keyInfo.Key != ConsoleKey.Enter);

        Console.Write("Wprowadź hasło: ");
        string input = Console.ReadLine();

        HashAlgorithm hashAlgorithm = new(selectedAlgorithm);
        string hash = hashAlgorithm.ComputeHash(input);

        Console.WriteLine("\nZaszyfrowane hasło:");
        Console.WriteLine(hash);
    }

    public static void DisplayAlgorithms(IHashStrategy selectedAlgorithm)
    {
        Console.Clear();
        Console.WriteLine("Wybierz algorytm:");
        foreach (IHashStrategy algorithm in algorithms)
        {
            string marker = algorithm.Equals(selectedAlgorithm) ? "[■]" : "[ ]";
            Console.WriteLine($"{marker} {algorithm}");
        }
        Console.WriteLine("Enter, aby zatwierdzić...\n");
    }
}