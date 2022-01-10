using System;
using System.Threading.Tasks;
using RestEase;
using Retail.Operations.Storage.Api.Contracts.Web;
using Retail.Operations.Storage.AppServices.Contracts.Operation;

namespace Retail.Operations.Storage.Api.Client
{
    class Program
    {
        static async Task Main(string[] args)
        {
            OperationDto operation = new OperationDto() {Timestamp = System.DateTime.Now, Status = 1};
            IOperationsStorageController api = RestClient.For<IOperationsStorageController>("http://localhost:5000");
            var result = await api.AddByOperation(operation);
            Console.WriteLine(result);
        }
    }
}