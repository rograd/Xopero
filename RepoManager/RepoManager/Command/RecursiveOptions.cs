using System.Threading.Tasks;
using CommandLine;

namespace RepoManager.Command
{
    [Verb("recursive", HelpText ="Create repository recursively")]
    class RecusriveOptions : TokenOption, ICommand
    {
        [Value(index: 0, Required = true, HelpText = "Name of repository")]
        public string Name { get; set; }

        [Option("times", Required = true, HelpText = "Number of repositories")]
        public int Times { get; set; }

        public async Task Execute(Manager manager)
        {
            for (int i = 1; i <= Times; i++)
                await manager.CreateRepository($"{Name}{i}");
        }
    }
}
