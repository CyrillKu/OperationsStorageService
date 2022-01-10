using Retail.Operations.Storage.AppServices.Contracts.Operation;

namespace Retail.Operations.Storage.AppServices.Operation.Mappers
{
    public class OperationMapper: IOperationMapper
    {
        public Entities.Operation Map(OperationDto operationDto)
        {
            return new Entities.Operation()
            {
                Status = operationDto.Status,
                Timestamp = operationDto.Timestamp
            };
        }
        
        public OperationDto Map(Entities.Operation operation)
        {
            return new OperationDto()
            {
                Status = operation.Status,
                Timestamp = operation.Timestamp
            };
        }
    }
}