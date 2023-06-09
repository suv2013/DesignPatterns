using FactoryMethodPattern.CreditCards;

namespace FactoryMethodPattern.FactoryMethod.Concrete_Factory
{
    public class MoneyBackFactory : CreditCardFactory
    {
        protected override CreditCard MakeProduct()
        {
            CreditCard moneyBackCard = new MoneyBack();
            return moneyBackCard;
        }
    }
}
