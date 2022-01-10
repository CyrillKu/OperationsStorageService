using Retail.Operations.Storage.AppServices.Contracts.Event;

namespace Retail.Operations.Storage.AppServices.Event.Mappers
{
    public class EventMapper: IEventMapper
    {
        public EventDto Map(Entities.Event ev)
        {
            return new EventDto()
            {
                AggregationId = ev.AggregationId,
                Content = ev.Content,
                DomainId = ev.DomainId,
                EventId = ev.EventId,
                ProcessId = ev.ProcessId,
                Timestamp = ev.Timestamp
            };
        }
        Entities.Event IEventMapper.Map(EventDto evDto)
        {
            return new Entities.Event()
            {
                AggregationId = evDto.AggregationId,
                Content = evDto.Content,
                DomainId = evDto.DomainId,
                EventId = evDto.EventId,
                ProcessId = evDto.ProcessId,
                Timestamp = evDto.Timestamp
            };        }
    }
}