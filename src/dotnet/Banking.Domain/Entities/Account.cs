using System;

namespace Banking.Domain.Entities
{
    public class Account
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public decimal Balance { get; set; }
    }
}
