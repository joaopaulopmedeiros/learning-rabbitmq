using System.Collections.Generic;
using Banking.Domain.Entities;
using Banking.Infra.UnitOfWork.Interface;

namespace Banking.Services
{
    public class AccountService
    {
        protected IUnitOfWork _uow;

        public AccountService(IUnitOfWork uow)
        {
            this._uow = uow;
        }

        public List<Account> GetAll()
        {
            List<Account> result = _uow.GetRepository<Account>().ToList();
            return result;
        }

        public Account Add(Account model)
        {

            this._uow.GetRepository<Account>().Create(model);
            this._uow.GetRepository<Account>().SaveChanges();
            return model;
        }
    }
}