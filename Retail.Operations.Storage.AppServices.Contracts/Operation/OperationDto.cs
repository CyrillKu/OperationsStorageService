using System;

namespace Retail.Operations.Storage.AppServices.Contracts.Operation
{
    public class OperationDto
    {
        public int? Status { get; set; } // integer
        public DateTime? Timestamp { get; set; }
    }
}