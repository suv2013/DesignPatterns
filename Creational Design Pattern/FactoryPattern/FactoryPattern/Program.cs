using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryPattern.Factory;

namespace FactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose the type of Card you want : \n 1. MoneyBack \n 2. Titanium \n 3. Platinum");
            string cardType = "";
            switch (Convert.ToInt32(Console.ReadLine()))
            {
                case 1:
                    cardType = "MoneyBack";
                    break;
                case 2:
                    cardType = "Titanium";
                    break;
                case 3:
                    cardType = "Platinum";
                    break;
                default:
                    Console.WriteLine(" Wrong Option \n System is going for Crad type 1 \n");
                    cardType = "MoneyBack";
                    break;
            }

            ICreditCard cardDetails = CreditCardfactory.GetCreditCard(cardType);

            if (cardDetails != null)
            {
                Console.WriteLine("CardType : " + cardDetails.GetCardType());
                Console.WriteLine("CreditLimit : " + cardDetails.GetCreditLimit());
                Console.WriteLine("AnnualCharge :" + cardDetails.GetAnnualCharge());
            }
            else
            {
                Console.Write("Invalid Card Type");
            }
            Console.ReadLine();
        }
    }
}
