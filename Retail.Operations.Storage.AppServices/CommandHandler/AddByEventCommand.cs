using System.Threading.Tasks;
using Retail.Operations.Storage.AppServices.Contracts.CommandHandler;
using Retail.Operations.Storage.AppServices.Contracts.Event;
using Retail.Operations.Storage.AppServices.Contracts.Event.Handlers;

namespace Retail.Operations.Storage.AppServices.CommandHandler
{
    public class AddByEventCommand : ICommand
    {
        private readonly IAddByEventHandler _receiver;
        private readonly EventDto _eventDto;

        public AddByEventCommand(IAddByEventHandler receiver, EventDto eventDto)
        {
            _receiver = receiver;
            _eventDto = eventDto;
        }

        public async Task<int> Execute()
        {
            return await _receiver.AddByEvent(_eventDto);

        }
    }
}