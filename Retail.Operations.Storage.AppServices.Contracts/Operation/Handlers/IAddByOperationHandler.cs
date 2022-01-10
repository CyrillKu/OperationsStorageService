using System.Threading.Tasks;

namespace Retail.Operations.Storage.AppServices.Contracts.Operation.Handlers
{
    public interface IAddByOperationHandler
    {
        Task<int> AddByOperation(OperationDto op);

    }
}