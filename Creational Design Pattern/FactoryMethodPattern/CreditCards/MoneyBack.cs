﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryMethodPattern.Interface;

namespace FactoryMethodPattern.CreditCards
{
    class MoneyBack : ICreditCard
    {
        public string GetCardType()
        {
            return "MoneyBack";
        }
        public int GetCreditLimit()
        {
            return 15000;
        }
        public int GetAnnualCharge()
        {
            return 500;
        }
    }
}
