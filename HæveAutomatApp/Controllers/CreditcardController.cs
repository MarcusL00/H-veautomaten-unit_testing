using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using HæveautomatApp.Entities;
using HæveAutomatApp.Interfaces;

namespace HæveAutomatApp.Controllers
{
    public class CreditCardController : ICreditCardController
    {

        public CreditCard CreateCreditCard(string cardNumber, string code)
        {

            ValidateCardNumber(cardNumber);
            ValidateCode(code);
            CreditCard creditCard = new CreditCard(cardNumber, code);
            return creditCard;
        }

        public void ValidateCode(string code)
        {
            if (string.IsNullOrEmpty(code))
            {
                throw new ValidationException("Password cannot be empty");
            }
        }

        public void ValidateCardNumber(string cardNumber)
        {
            if (string.IsNullOrEmpty(cardNumber))
            {
                throw new ValidationException("Password cannot be empty");
            }
        }
    }
}
