using HæveautomatApp.Entities;

namespace HæveAutomatApp.Interfaces.Controller
{
    public interface IUserController
    {
        User CreateUser(string name, string password);
        void ValidatePassword(string password);
        void ValidateName(string name);
    }
}