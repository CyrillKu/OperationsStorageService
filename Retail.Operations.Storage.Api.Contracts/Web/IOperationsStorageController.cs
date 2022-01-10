using System.Threading.Tasks;
using RestEase;
using Retail.Operations.Storage.AppServices.Contracts.Event;
using Retail.Operations.Storage.AppServices.Contracts.Operation;
using Retail.Operations.Storage.AppServices.Contracts.Process;

namespace Retail.Operations.Storage.Api.Contracts.Web
{
    public interface IOperationsStorageController
    {
        [Post("api/addbyoperation")]
        Task<int> AddByOperation([Body] OperationDto operationDto);

        [Post("api/addbyevent")]
        Task<int> AddByEvent([Body] EventDto eventDto);

        [Post("api/addbyprocess")]
        Task<int> AddByProcess([Body] ProcessDto processDto);
        
    }
}