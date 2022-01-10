using System.Threading.Tasks;

namespace Retail.Operations.Storage.AppServices.Contracts.CommandHandler
{
    public interface ICommand
    {
        Task<int> Execute();
        // void Undo();
    }
}