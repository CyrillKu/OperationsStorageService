using System.Threading.Tasks;
using Retail.Operations.Storage.AppServices.Contracts.CommandHandler;
using Retail.Operations.Storage.AppServices.Contracts.Operation;
using Retail.Operations.Storage.AppServices.Contracts.Operation.Handlers;

namespace Retail.Operations.Storage.AppServices.CommandHandler
{
    public class AddByOperationCommand : ICommand
    {
        private readonly IAddByOperationHandler _receiver;
        private readonly OperationDto _operationDto;


        public AddByOperationCommand(IAddByOperationHandler receiver, OperationDto operationDto)
        {
            _receiver = receiver;
            _operationDto = operationDto;
        }

        public async Task<int> Execute()
        {
            return await _receiver.AddByOperation(_operationDto);
        }
    }
}