using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using CommandLine;

namespace RepoManagerCLI
{
    class Options
    {
        [Option('t', "token", Required = true, HelpText = "Github personal access token.")]
        public string Token { get; set; }

        [Option('n', "names", Required = true, HelpText = "List of repositories.", Separator = ',')]
        public IEnumerable<string> Names { get; set; }

        [Option('d', "delete", Required = false, HelpText = "Weather to delete repositories.")]
        public bool Delete { get; set; }
    }

    class Program
    {
        async public static Task Main(string[] args)
        {
            await Parser.Default.ParseArguments<Options>(args)
                                .WithParsedAsync(ProcessArguments);
        }

        async public static Task ProcessArguments(Options options)
        {
            RepoManager manager = new(options.Token);
            HttpResponseMessage response;
            foreach (string name in options.Names)
            {
                response = await (options.Delete ? manager.DeleteRepository(name) : manager.CreateRepository(name));
                Logger.Target = name;
                switch (response.StatusCode)
                {
                    case HttpStatusCode.Created:
                        Logger.Ok("Successfully created repository!");
                        break;

                    case (HttpStatusCode)422:
                        Logger.Warning("Repository already exists.");
                        break;

                    case HttpStatusCode.NoContent:
                        Logger.Ok("Repository has been deleted.");
                        break;

                    case HttpStatusCode.NotFound:
                        Logger.Warning("Repository doesn't exist.");
                        break;

                    default:
                        Logger.Fail("An error occured.");
                        break;
                }
            }
        }
    }
}
