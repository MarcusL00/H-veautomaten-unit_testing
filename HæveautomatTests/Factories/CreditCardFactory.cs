using HæveautomatApp.Entities;

namespace HæveautomatTests.Factories
{
    public class CreditCardFactory
    {
        public static CreditCard CreateCreditCard(string cardNumber = "8654 4345 5343 23431", string code = "1234")
        {
            
            return new CreditCard(cardNumber, code);
        }
    }
}