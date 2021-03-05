using System;
using System.Collections.Generic;
using System.Text;
using Banking.Infra.UnitOfWork.Interface;
using Banking.Infra.Repository.Interface;
using Banking.Infra.Context;
using Microsoft.Extensions.Configuration;

namespace Banking.Infra
{
    public class UnitOfWork<TContext> :
            IUnitOfWork where TContext : BankingContext
    {
        private Dictionary<Type, object> _repositories;
        public TContext Context { get; }
        private readonly IConfiguration _config;

        public UnitOfWork(TContext context, IConfiguration config)
        {
            Context = context;
            _config = config;
        }

        public IRepository<TEntity> GetRepository<TEntity>() where TEntity : class
        {
            if (_repositories == null) _repositories = new Dictionary<Type, object>();

            var type = typeof(TEntity);
            if (!_repositories.ContainsKey(type)) _repositories[type] = new Repository<TEntity>(Context);
            return (IRepository<TEntity>)_repositories[type];
        }
    }
}