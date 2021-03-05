using Banking.Infra;
using Banking.Infra.Context;
using Banking.Infra.Repository.Interface;
using Banking.Infra.UnitOfWork.Interface;
using Banking.Services;
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
            //RabbitMQBus
            services.AddTransient<IEventBus, RabbitMQBus>();

            //Banking Microservice
            services.AddTransient<IUnitOfWork, UnitOfWork<BankingContext>>();
            services.AddTransient<AccountService>();
        }
    }
}
