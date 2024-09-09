using FactoryMethodPattern.CreditCards;
using FactoryMethodPattern.Interface;

namespace FactoryMethodPattern.FactoryMethod.Concrete_Factory
{
    public class MoneyBackFactory : CreditCardFactory
    {
        protected override ICreditCard MakeProduct()
        {
            ICreditCard moneyBackCard = new MoneyBack();
            return moneyBackCard;
        }
    }
}
