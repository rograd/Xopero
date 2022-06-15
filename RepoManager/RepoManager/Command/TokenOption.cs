using CommandLine;

namespace RepoManager.Command
{
    class TokenOption
    {
        [Option("token", Required = true, HelpText = "Github personal access token.")]
        public string Token { get; set; }
    }
}
