using System.ComponentModel.DataAnnotations;
using HæveAutomatApp.Interfaces.Controller;
using HæveautomatApp.Entities;

namespace HæveAutomatApp.Controllers
{
    public class UserController : IUserController
    {

        public User CreateUser(string name, string password)
        {
            ValidateName(name);
            ValidatePassword(password);
            User user = new User(name, password);
            return user;
        }

        private void ValidatePassword(string password)
        {
            if (string.IsNullOrEmpty(password))
            {
                throw new ValidationException("Password cannot be empty");
            }
        }

        private void ValidateName(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new ValidationException("Name cannot be empty");
            }
        }

        void IUserController.ValidatePassword(string password)
        {
            if (string.IsNullOrEmpty(password))
            {
                throw new ValidationException("Password cannot be empty");
            }
        }

        void IUserController.ValidateName(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new ValidationException("Name cannot be empty");
            }

        }
    }
}