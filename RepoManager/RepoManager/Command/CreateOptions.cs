using System.Collections.Generic;
using System.Threading.Tasks;
using CommandLine;

namespace RepoManager.Command
{
    [Verb("create", HelpText = "Create repositories")]
    class CreateOptions : TokenOption, ICommand
    {
        [Value(index: 0, Required = true, HelpText = "List of repositories")]
        public IEnumerable<string> Names { get; set; }

        public async Task Execute(Manager manager)
        {
            foreach (string name in Names)
                await manager.CreateRepository(name);
        }
    }
}
