using System.ComponentModel.DataAnnotations;
using HæveautomatApp.Entities;
using HæveAutomatApp.Interfaces.Controller;

namespace HæveAutomatApp.Controllers
{
    public class AccountController : IAccountController
    {
        public Account CreateAccount(User user, decimal balance, CreditCard creditCard)
        {
            ValidateUser(user);
            ValidateCreditCard(creditCard);
            return new Account(user, balance, creditCard);
        }

        public void ValidateUser(User user)
        {
            if (user == null)
            {
                throw new ValidationException("User cannot be null");
            }
        }

        public void ValidateCreditCard(CreditCard creditCard)
        {
            if (creditCard == null)
            {
                throw new ValidationException("CreditCard cannot be null");
            }
        }

        public Account Withdraw(decimal amount, Account account)
        {
            if (amount > account.Balance)
            {
                throw new ValidationException("Insufficient funds");
            }

            account.Balance -= amount;
            return account;
        }
    }
}