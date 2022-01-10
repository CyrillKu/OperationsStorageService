using Microsoft.Extensions.DependencyInjection;
using Retail.Operations.Storage.AppServices.CommandHandler;
using Retail.Operations.Storage.AppServices.Contracts.CommandHandler;
using Retail.Operations.Storage.AppServices.Contracts.Event.Handlers;
using Retail.Operations.Storage.AppServices.Contracts.Operation.Handlers;
using Retail.Operations.Storage.AppServices.Contracts.Process.Handlers;
using Retail.Operations.Storage.AppServices.Event;
using Retail.Operations.Storage.AppServices.Event.Mappers;
using Retail.Operations.Storage.AppServices.Operation;
using Retail.Operations.Storage.AppServices.Operation.Mappers;
using Retail.Operations.Storage.AppServices.Process;
using Retail.Operations.Storage.AppServices.Process.Mappers;

namespace Retail.Operations.Storage.AppServices.Infrastructure
{
    public static class ServiceCollectionExtensions
    {
        public static void AddOperationsHandlersAndMappers(this IServiceCollection services)
        {
            services.AddTransient<IAddByEntityCommandHandler, AddByEntityCommandHandler>();
            services.AddTransient<IAddByEventHandler, AddByEventHandler>();
            services.AddTransient<IAddByProcessHandler, AddByProcessHandler>();
            services.AddTransient<IAddByOperationHandler, AddByOperationHandler>();
            services.AddTransient<IEventMapper, EventMapper>();
            services.AddTransient<IProcessMapper, ProcessMapper>();
            services.AddTransient<IOperationMapper, OperationMapper>();
            services.AddTransient<ICommand, EmptyCommand>();
        }
    }
}