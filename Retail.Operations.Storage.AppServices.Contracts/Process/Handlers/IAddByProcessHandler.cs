using System.Threading.Tasks;

namespace Retail.Operations.Storage.AppServices.Contracts.Process.Handlers
{
    public interface IAddByProcessHandler
    {
        Task<int> AddByProcess(ProcessDto proc);
    }
}