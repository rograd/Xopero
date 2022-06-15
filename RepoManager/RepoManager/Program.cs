using System;
using System.Threading.Tasks;
using CommandLine;

namespace RepoManager
{
    using Command;

    class Program
    {
        async public static Task Main(string[] args)
        {
            await Parser.Default.ParseArguments<CreateOptions, DeleteOptions, RecusriveOptions>(args)
                                .WithParsedAsync<ICommand>(async command =>
                                {
                                    Manager manager = new(command.Token);
                                    if (!await manager.Authorize()) {
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.WriteLine("Couldn't authorize...");
                                        Console.ResetColor();
                                        return;
                                    };
                                    await command.Execute(manager);
                                });
        }
    }
}
