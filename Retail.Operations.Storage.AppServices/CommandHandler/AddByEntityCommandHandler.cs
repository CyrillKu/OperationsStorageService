using System;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Retail.Operations.Storage.AppServices.Contracts.CommandHandler;
using Retail.Operations.Storage.AppServices.Contracts.Event;
using Retail.Operations.Storage.AppServices.Contracts.Event.Handlers;
using Retail.Operations.Storage.AppServices.Contracts.Operation;
using Retail.Operations.Storage.AppServices.Contracts.Operation.Handlers;
using Retail.Operations.Storage.AppServices.Contracts.Process;
using Retail.Operations.Storage.AppServices.Contracts.Process.Handlers;

namespace Retail.Operations.Storage.AppServices.CommandHandler
{
    public class AddByEntityCommandHandler : IAddByEntityCommandHandler
    {
        private readonly IAddByEventHandler _eventHandler;
        private readonly IAddByProcessHandler _processHandler;
        private readonly IAddByOperationHandler _operationHandler;
        private ICommand _command;

        public AddByEntityCommandHandler(IAddByEventHandler eventHandler, IAddByProcessHandler processHandler, IAddByOperationHandler operationHandler, ICommand command)
        {
            _eventHandler = eventHandler ?? throw new ArgumentNullException(nameof(eventHandler));
            _processHandler = processHandler ?? throw new ArgumentNullException(nameof(processHandler));
            _operationHandler = operationHandler ?? throw new ArgumentNullException(nameof(operationHandler));
            _command = command ?? throw new ArgumentNullException(nameof(command));
        }

        public async Task<int> AddByEvent(EventDto eventDto)
        {
            SetCommand(new AddByEventCommand(_eventHandler, eventDto));
            return await ExecuteCommand();
        }

        public async Task<int> AddByProcess(ProcessDto processDto)
        {
            SetCommand(new AddByProcessCommand(_processHandler, processDto));
            return await ExecuteCommand();
        }

        public async Task<int> AddByOperation(OperationDto operationDto)
        {
            SetCommand(new AddByOperationCommand(_operationHandler, operationDto));
            return await ExecuteCommand();
        }
        
        private void SetCommand(ICommand com)
        {
            _command = com;
        }
        private async Task<int> ExecuteCommand()
        {
            return await _command.Execute();
        }
    }

    
}