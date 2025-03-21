using System;
using System.ComponentModel.DataAnnotations;

namespace HæveautomatApp.Entities
{
    public class User
    {
        [Key]
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }

        public User(string name, string password)
        {
            Id = Guid.NewGuid();
            Name = name;
            Password = password;
        }
    }
}