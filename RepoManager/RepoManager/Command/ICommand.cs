using System.Threading.Tasks;

namespace RepoManager.Command
{
    interface ICommand
    {
        string Token { get; set; }
        Task Execute(Manager manager);
    }
}
