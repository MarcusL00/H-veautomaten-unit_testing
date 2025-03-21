using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.ComponentModel.DataAnnotations;
using HæveautomatApp.Entities;
using HæveautomatTests.Factories;
using HæveAutomatApp.Controllers;

namespace HæveautomatTests.Test
{
    [TestClass]
    public class CreditCardTest
    {
        private CreditCardController _creditCardController;
        [TestInitialize]
        public void setup()
        {
            _creditCardController = new CreditCardController();
        }
        [TestMethod]
        public void can_create_credit_card()
        {
            var creditCard = CreditCardFactory.CreateCreditCard();

            Assert.IsNotNull(creditCard, "CreditCard object should not be null");
        }

        [TestMethod]
        public void cannot_create_credit_card_without_cardnumber()
        {
            // Act & Assert
            Assert.ThrowsException<ValidationException>(() => _creditCardController.CreateCreditCard(cardNumber: "", code: "123"), "Card number cannot be empty");
        }

        [TestMethod]
        public void cannot_create_credit_card_without_code()
        {
            // Act & Assert
            Assert.ThrowsException<ValidationException>(() => _creditCardController.CreateCreditCard(cardNumber: "4215 3234 6734 1234", code: ""), "Code cannot be empty");
        }
    }
} 