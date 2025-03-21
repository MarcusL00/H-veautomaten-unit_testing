using HæveautomatApp.Entities;

namespace HæveautomatTests.Factories
{
    public class AccountFactory
    {
        public static Account createAccount(User user = null, decimal balance = 4000, CreditCard creditCard = null)
        {
            user ??= UserFactory.CreateUser();
            creditCard ??= CreditCardFactory.CreateCreditCard();
            return new Account(user, balance, creditCard);
        }
    }
}