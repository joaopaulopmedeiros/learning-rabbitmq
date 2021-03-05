using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace Banking.Infra.Repository.Interface
{
    public interface IRepository<TEntity>
    {
        List<TEntity> ToList();
        void Create(TEntity entity);
        IEnumerable<TEntity> Where(Expression<Func<TEntity, bool>> predicate);
        void SaveChanges();
    }
}