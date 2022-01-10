using System.Threading.Tasks;
using LinqToDB;
using LinqToDB.Data;
using Retail.Operations.Storage.AppServices.Contracts.Operation;
using Retail.Operations.Storage.AppServices.Contracts.Operation.Handlers;
using Retail.Operations.Storage.AppServices.Operation.Mappers;

namespace Retail.Operations.Storage.AppServices.Operation
{
    public class AddByOperationHandler: IAddByOperationHandler
    {
        private readonly DataConnection _db;
        private readonly IOperationMapper _mapper;

        public AddByOperationHandler(DataConnection db, IOperationMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }

        public async Task<int> AddByOperation(OperationDto op)
        {
            var operationToAdd = _mapper.Map(op);
            return await _db.InsertAsync(operationToAdd);
        }
    }
}