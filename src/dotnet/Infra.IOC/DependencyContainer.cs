using Domain.Core.Bus;
using Infra.Bus;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace Infra.IOC
{
    public class DependencyContainer
    {
        public static void Register(IServiceCollection services)
        {
            services.AddTransient<IEventBus, RabbitMQBus>();
        }
    }
}
