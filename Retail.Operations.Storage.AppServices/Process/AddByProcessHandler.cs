using System;
using System.Threading.Tasks;
using LinqToDB;
using LinqToDB.Data;
using Retail.Operations.Storage.AppServices.Contracts.Process;
using Retail.Operations.Storage.AppServices.Contracts.Process.Handlers;
using Retail.Operations.Storage.AppServices.Process.Mappers;

namespace Retail.Operations.Storage.AppServices.Process
{
    public class AddByProcessHandler: IAddByProcessHandler
    {
        private readonly DataConnection _db;
        private readonly IProcessMapper _mapper;

        public AddByProcessHandler(DataConnection db, IProcessMapper mapper)
        {
            _db = db ?? throw  new ArgumentNullException(nameof(db));
            _mapper = mapper ?? throw  new ArgumentNullException(nameof(mapper));
        }

        public async Task<int> AddByProcess(ProcessDto proc)
        {
            var processToAdd = _mapper.Map(proc);
            return await _db.InsertAsync(processToAdd);

            
        }
    }
}