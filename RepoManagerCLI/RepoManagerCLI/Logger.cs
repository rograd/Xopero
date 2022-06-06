using System;

namespace RepoManagerCLI
{
    static class Logger
    {
        private static string _target;
        public static string Target
        {
            get => _target;
            set => _target = value;
        }

        public static void Ok(string message)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            ShowMessage('+', message);
        }

        public static void Warning(string message)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            ShowMessage('*', message);
        }

        public static void Fail(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            ShowMessage('-', message);
        }

        private static void ShowMessage(char marker, string text)
        {
            Console.WriteLine($"[{marker}] {text} (\"{_target}\")");
            Console.ResetColor();
        }
    }
}
