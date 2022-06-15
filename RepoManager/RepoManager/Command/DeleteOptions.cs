using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommandLine;
using System.Diagnostics;
using System.IO;

namespace RepoManager.Command
{
    [Verb("delete", HelpText = "Choose to delete repositories")]
    class DeleteOptions : TokenOption, ICommand
    {
        private static async Task<string[]> GetFeedback(string fileName)
        {
            Console.WriteLine("Choose which repositories you'd want to delete. Save the file afterwards.");
            var notepad = Process.Start("notepad.exe", fileName);
            await notepad.WaitForExitAsync();
            string[] lines = await File.ReadAllLinesAsync(fileName);
            return lines;
        }

        public async Task Execute(Manager manager)
        {
            string fileName = "tempdata.txt";
            string[] names = await manager.GetRepositoryNames();
            await File.WriteAllLinesAsync(fileName, names);
            names = await GetFeedback(fileName);

            DisplayWarning();
            foreach (string name in names) Console.WriteLine(name);
            DisplayWarning();

            if (!Agreement()) return;

            foreach (string name in names)
                await manager.DeleteRepository(name);
        }

        private static bool Agreement()
        {
            string agreement = "agree";
            Console.WriteLine($"Do you want to proceed? Type \"{agreement}\"");
            bool proceed = Console.ReadLine().Equals(agreement);
            if (!proceed)
            {
                Console.WriteLine("Interrupted.");
                return false;
            }
            return true;
        }

        private static void DisplayWarning()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("=======================================");
            Console.WriteLine("Following repositories will be removed.");
            Console.WriteLine("=======================================");
            Console.ResetColor();
        }
    }
}
