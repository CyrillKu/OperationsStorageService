using Retail.Operations.Storage.AppServices.Contracts.Event;
using Retail.Operations.Storage.Entities;

namespace Retail.Operations.Storage.AppServices.Event.Mappers
{
    public interface IEventMapper
    {
        Entities.Event Map(EventDto evDto);
        EventDto Map(Entities.Event ev);
    }
}