using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HæveautomatApp.Entities;

namespace HæveAutomatApp.Interfaces
{
    public interface ICreditCardController
    {
        CreditCard CreateCreditCard(string cardNumber, string code);
        void ValidateCode(string code);

        void ValidateCardNumber(string cardNumber);
    }
}