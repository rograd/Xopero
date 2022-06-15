using System;
using System.Net;

namespace RepoManager
{
    static class Logger
    {
        private static string _target;

        private static void Ok(string message)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            ShowMessage('+', message);
        }

        private static void Warning(string message)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            ShowMessage('*', message);
        }

        private static void Fail(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            ShowMessage('-', message);
        }

        private static void ShowMessage(char marker, string text)
        {
            Console.WriteLine($"[{marker}] {text} (\"{_target}\")");
            Console.ResetColor();
        }

        public static void DisplayResult(string target, HttpStatusCode statusCode)
        {
            _target = target;
            switch (statusCode)
            {
                case HttpStatusCode.Created:
                    Ok("Successfully created repository!");
                    break;

                case (HttpStatusCode)422:
                    Warning("Repository already exists.");
                    break;

                case HttpStatusCode.NoContent:
                    Ok("Repository has been deleted.");
                    break;

                case HttpStatusCode.NotFound:
                    Warning("Repository doesn't exist.");
                    break;

                default:
                    Fail("An error occured. (Check permissions)");
                    break;
            }
        }
    }
}
