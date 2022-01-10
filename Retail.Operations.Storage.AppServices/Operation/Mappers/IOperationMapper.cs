using Retail.Operations.Storage.AppServices.Contracts.Operation;

namespace Retail.Operations.Storage.AppServices.Operation.Mappers
{
    public interface IOperationMapper
    {
        Entities.Operation Map(OperationDto operationDto);
        OperationDto Map( Entities.Operation operation);
    }
}