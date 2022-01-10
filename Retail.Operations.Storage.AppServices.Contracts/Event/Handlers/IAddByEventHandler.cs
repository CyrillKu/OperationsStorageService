using System.Threading.Tasks;

namespace Retail.Operations.Storage.AppServices.Contracts.Event.Handlers
{
    public interface IAddByEventHandler
    {
        Task<int> AddByEvent(EventDto ev);
    }
}