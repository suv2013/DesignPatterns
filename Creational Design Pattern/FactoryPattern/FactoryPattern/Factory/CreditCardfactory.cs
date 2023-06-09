using FactoryPattern.CreditCards;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern.Factory
{
    class CreditCardfactory
    {
        public static ICreditCard GetCreditCard(string cardType)
        {
            ICreditCard creditCard = null;

            if (cardType == "MoneyBack")
            {
                creditCard = new MoneyBack();
            }
            else if (cardType == "Titanium")
            {
                creditCard = new Titanium();
            }
            else if (cardType == "Platinum")
            {
                creditCard = new Platinum();
            }
            return creditCard;
        }
    }
}
