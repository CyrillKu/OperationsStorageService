using System;
using System.Threading.Tasks;
using LinqToDB;
using LinqToDB.Data;
using Retail.Operations.Storage.AppServices.Contracts.Event;
using Retail.Operations.Storage.AppServices.Contracts.Event.Handlers;
using Retail.Operations.Storage.AppServices.Event.Mappers;

namespace Retail.Operations.Storage.AppServices.Event
{
    public class AddByEventHandler : IAddByEventHandler
    {
        private readonly DataConnection _db;
        private readonly IEventMapper _mapper;

        public AddByEventHandler(DataConnection db, IEventMapper mapper)
        {
            _db = db ?? throw new ArgumentNullException(nameof(db));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        public async Task<int> AddByEvent(EventDto ev)
        {
            var eventToAdd = _mapper.Map(ev);
            return await _db.InsertAsync(eventToAdd);
        }
    }
}