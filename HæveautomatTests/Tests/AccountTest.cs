using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.ComponentModel.DataAnnotations;
using HæveautomatApp.Entities;
using HæveautomatTests.Factories;
using HæveAutomatApp.Controllers;

namespace HæveautomatTests.Test
{
    [TestClass]
    public class AccountTest
    {
        private AccountController _accountController;

        [TestInitialize]
        public void setup()
        {
            _accountController = new AccountController();
        }

        [TestMethod]
        public void can_create_account()
        {
            // Arrange
            decimal balance = 40000;
            var user = UserFactory.CreateUser();
            var creditCard = CreditCardFactory.CreateCreditCard();

            // Act
            var account = _accountController.CreateAccount(user, balance, creditCard);

            // Assert
            Assert.IsNotNull(account, "Account object should not be null");
            Assert.AreEqual(40000, account.Balance, "Account object should match the provided value");
        }

        [TestMethod]
        public void cannot_create_account_without_user()
        {
            // Arrange
            decimal balance = 40000;
            var creditCard = CreditCardFactory.CreateCreditCard();

            // Act & Assert
            Assert.ThrowsException<ValidationException>(() => _accountController.CreateAccount(null, balance, creditCard), "User cannot be null");
        }

        [TestMethod]
        public void cannot_create_account_without_credit_card()
        {
            // Arrange
            decimal balance = 40000;
            var user = UserFactory.CreateUser();

            // Act & Assert
            Assert.ThrowsException<ValidationException>(() => _accountController.CreateAccount(user, balance, null), "CreditCard cannot be null");
        }

        [TestMethod]
        public void can_withdraw_money()
        {
            // Arrange
            decimal balance = 40000;
            var user = UserFactory.CreateUser();
            var creditCard = CreditCardFactory.CreateCreditCard();
            var account = _accountController.CreateAccount(user, balance, creditCard);
            decimal withdrawAmount = 5000;

            // Act
            var updatedAccount = _accountController.Withdraw(withdrawAmount, account);

            // Assert
            Assert.AreEqual(35000, updatedAccount.Balance, "Account balance should be reduced by the withdrawn amount");
        }

        [TestMethod]
        public void cannot_withdraw_insufficient_funds()
        {
            // Arrange
            decimal balance = 40000;
            var user = UserFactory.CreateUser();
            var creditCard = CreditCardFactory.CreateCreditCard();
            var account = _accountController.CreateAccount(user, balance, creditCard);
            decimal withdrawAmount = 50000;

            // Act & Assert
            Assert.ThrowsException<ValidationException>(() => _accountController.Withdraw(withdrawAmount, account), "Insufficient funds");
        }
    }
}