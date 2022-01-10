using System.Threading.Tasks;
using Retail.Operations.Storage.AppServices.Contracts.CommandHandler;

namespace Retail.Operations.Storage.AppServices.CommandHandler
{
    public class EmptyCommand : ICommand
    {
        public Task<int> Execute()
        {
            return null;
        }
    }
}