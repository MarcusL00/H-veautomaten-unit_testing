// filepath: c:\Users\Marcus\source\repos\Hæveautomaten\HæveAutomatApp\Entities\Account.cs
using System;
using System.ComponentModel.DataAnnotations;

namespace HæveautomatApp.Entities
{
    public class Account
    {
        [Key]
        public Guid Id { get; set; }
        public User User { get; set; }
        public decimal Balance { get; set; }
        public CreditCard CreditCard { get; set; }

        public Account(User user, decimal balance, CreditCard creditCard)
        {
            Id = Guid.NewGuid();
            User = user;
            Balance = balance;
            CreditCard = creditCard;
        }
    }
}