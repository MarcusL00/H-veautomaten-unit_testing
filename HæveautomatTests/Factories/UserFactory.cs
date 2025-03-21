using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HæveautomatApp.Entities;

namespace HæveautomatTests.Factories
{
    public class UserFactory
    {
        public static User CreateUser(string name = "Marcus", string password = "password")
        {
            return new User(name, password);
        }
    }
}