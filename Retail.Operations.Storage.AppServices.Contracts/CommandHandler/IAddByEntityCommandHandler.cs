using System.Threading.Tasks;
using Retail.Operations.Storage.AppServices.Contracts.Event;
using Retail.Operations.Storage.AppServices.Contracts.Operation;
using Retail.Operations.Storage.AppServices.Contracts.Process;

namespace Retail.Operations.Storage.AppServices.Contracts.CommandHandler
{
    public interface IAddByEntityCommandHandler
    {
        Task<int> AddByEvent(EventDto eventDto);
        Task<int> AddByProcess(ProcessDto processDto);
        Task<int> AddByOperation(OperationDto operationDto);
    }
}