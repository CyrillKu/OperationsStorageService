using System.Threading.Tasks;
using Retail.Operations.Storage.AppServices.Contracts.CommandHandler;
using Retail.Operations.Storage.AppServices.Contracts.Process;
using Retail.Operations.Storage.AppServices.Contracts.Process.Handlers;

namespace Retail.Operations.Storage.AppServices.CommandHandler
{
    public class AddByProcessCommand : ICommand
    {
        private readonly IAddByProcessHandler _receiver;
        private readonly ProcessDto _processDto;

        public AddByProcessCommand(IAddByProcessHandler receiver, ProcessDto processDto)
        {
            _receiver = receiver;
            _processDto = processDto;
        }

        public async Task<int> Execute()
        {
            return await _receiver.AddByProcess(_processDto);
        }
    }
}