using Retail.Operations.Storage.AppServices.Contracts.Process;

namespace Retail.Operations.Storage.AppServices.Process.Mappers
{
    public class ProcessMapper: IProcessMapper
    {
        public Entities.Process Map(ProcessDto procDto)
        {
            return new Entities.Process()
            {
                DomainId = procDto.DomainId,
                OperationId = procDto.OperationId,
                ParentProcessId = procDto.ParentProcessId,
                State = procDto.State,
                Timestamp = procDto.Timestamp
            };
        }

        public ProcessDto Map(Entities.Process process)
        {
            return new ProcessDto()
            {
                DomainId = process.DomainId,
                OperationId = process.OperationId,
                ParentProcessId = process.ParentProcessId,
                State = process.State,
                Timestamp = process.Timestamp
            };
        }
    }
}