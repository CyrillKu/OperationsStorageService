using System;

namespace Retail.Operations.Storage.AppServices.Contracts.Event
{
    public class EventDto
    {
        public Guid? EventId { get; set; } // uuid
        public string AggregationId { get; set; } // text
        public int? DomainId { get; set; } // integer
        public long? ProcessId { get; set; } // bigint
        public byte[] Content { get; set; } // bytea
        public DateTime? Timestamp { get; set; }
    }
}