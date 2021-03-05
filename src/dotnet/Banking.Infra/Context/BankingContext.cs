using Microsoft.EntityFrameworkCore;
using System;
using Banking.Domain.Entities;

namespace Banking.Infra.Context
{
    public class BankingContext : DbContext
    {
        public DbSet<Account> Accounts { get; set; }

        public BankingContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) 
        {
        
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        
        }

    }
}
