using Retail.Operations.Storage.AppServices.Contracts.Process;

namespace Retail.Operations.Storage.AppServices.Process.Mappers
{
    public interface IProcessMapper
    {
        Entities.Process Map(ProcessDto procDto);
        ProcessDto Map( Entities.Process process);
    }
}