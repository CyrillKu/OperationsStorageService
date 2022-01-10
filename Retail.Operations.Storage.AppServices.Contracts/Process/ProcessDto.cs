using System;

namespace Retail.Operations.Storage.AppServices.Contracts.Process
{
    public class ProcessDto
    {
        public long Id { get; set; } // bigint
        public int? DomainId { get; set; } // integer
        public long? OperationId { get; set; } // bigint
        public int? State { get; set; } // integer
        public DateTime? Timestamp { get; set; } // timestamp (6) without time zone
        public int? ParentProcessId { get; set; }
    }
}