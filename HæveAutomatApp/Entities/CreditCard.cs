using System;
using System.ComponentModel.DataAnnotations;

namespace HæveautomatApp.Entities
{
    public class CreditCard
    {
        [Key]
        public Guid Id { get; set; }
        public string CardNumber { get; set; }
        public string Code { get; set; }

        public CreditCard(string cardNumber, string code)
        {
            Id = Guid.NewGuid();
            CardNumber = cardNumber;
            Code = code;
        }
    }
}