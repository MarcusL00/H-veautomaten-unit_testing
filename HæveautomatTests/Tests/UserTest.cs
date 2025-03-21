using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using HæveautomatApp.Entities;
using HæveautomatTests.Factories;
using System.ComponentModel.DataAnnotations;
using HæveAutomatApp.Controllers;

namespace HæveautomatTests.Test
{
    [TestClass]
    public class UserTest
    {
        private UserController _userController;

        [TestInitialize]
        public void setup()
        {
            _userController = new UserController();
        }

        [TestMethod]
        public void can_create_user()
        {
            // Arrange
            var user = UserFactory.CreateUser();

            // Act
            var createdUser = _userController.CreateUser(user.Name, user.Password);

            // Assert
            Assert.IsNotNull(createdUser, "User object should not be null");
        }

        [TestMethod]
        public void can_create_user_without_name()
        {
            // Arrange
            var user = UserFactory.CreateUser(name: "");

            // Act & Assert
            Assert.ThrowsException<ValidationException>(() => _userController.CreateUser(user.Name, user.Password), "Name cannot be empty");
        }

        [TestMethod]
        public void can_create_user_without_password()
        {
            // Arrange
            var user = UserFactory.CreateUser(password: "");

            // Act & Assert
            Assert.ThrowsException<ValidationException>(() => _userController.CreateUser(user.Name, user.Password), "Password cannot be empty");
        }
    }
}