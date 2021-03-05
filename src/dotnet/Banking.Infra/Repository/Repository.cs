using System;
using System.Collections.Generic;
using System.Text;
using Banking.Infra.Context;
using System.Linq;
using Banking.Infra.Repository.Interface;
using System.Linq.Expressions;

namespace Banking.Infra
{

    public class Repository<TEntity> : IRepository<TEntity>
            where TEntity : class
    {
        private readonly BankingContext _context;

        public Repository(BankingContext context) => _context = context;

        public List<TEntity> ToList()
        {
            return _context.Set<TEntity>().ToList();
        }

        public void Create(TEntity entity)
        {
            if (entity == null) throw new ArgumentNullException("entity");
            _context.Set<TEntity>().Add(entity);
        }

        public IEnumerable<TEntity> Where(Expression<Func<TEntity, bool>> predicate)
        {
            return _context.Set<TEntity>().Where(predicate).AsEnumerable();
        }

        public void SaveChanges() => _context.SaveChanges();

    }
}