using HæveautomatApp.Entities;

namespace HæveAutomatApp.Interfaces.Controller
{
    public interface IAccountController
    {
        Account CreateAccount(User user, decimal balance, CreditCard creditCard);
        void ValidateUser(User user);
        void ValidateCreditCard(CreditCard creditCard);
        Account Withdraw(decimal amount, Account account);
    }
}