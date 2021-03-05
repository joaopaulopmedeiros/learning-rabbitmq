using System;
using System.Collections.Generic;
using System.Text;
using Banking.Infra.Repository;
using System.Linq;
using Banking.Infra.Repository.Interface;

namespace Banking.Infra.UnitOfWork.Interface
{
    public interface IUnitOfWork
    {
        IRepository<TEntity> GetRepository<TEntity>() where TEntity : class;
    }
}