using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RestEase;
using Retail.Operations.Storage.Api.Contracts.Web;
using Retail.Operations.Storage.AppServices.Contracts.CommandHandler;
using Retail.Operations.Storage.AppServices.Contracts.Event;
using Retail.Operations.Storage.AppServices.Contracts.Operation;
using Retail.Operations.Storage.AppServices.Contracts.Process;

namespace Retail.Operations.Storage.Host.Controllers
{
    [Route("api/")]
    [ApiController]
    public class OperationsStorageController : ControllerBase, IOperationsStorageController
    {
        private readonly IAddByEntityCommandHandler _commandHandler;

        public OperationsStorageController(IAddByEntityCommandHandler commandHandler)
        {
            _commandHandler = commandHandler;
        }
        [HttpPost("addbyoperation")]
        [Post("api/addbyoperation")]
        public Task<int> AddByOperation([Body] OperationDto operationDto)
        {
            return _commandHandler.AddByOperation(operationDto);
        }
        [HttpPost("addbyevent")]
        [Post("api/addbyevent")]
        public Task<int> AddByEvent([Body] EventDto eventDto)
        {
            return _commandHandler.AddByEvent(eventDto);
        }
        [HttpPost("addbyprocess")]
        [Post("api/addbyprocess")]
        public Task<int> AddByProcess([Body] ProcessDto processDto)
        {
            return _commandHandler.AddByProcess(processDto);
        }
    }
}