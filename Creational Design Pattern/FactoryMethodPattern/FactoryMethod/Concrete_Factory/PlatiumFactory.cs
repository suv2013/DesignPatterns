using FactoryMethodPattern.CreditCards;
using FactoryMethodPattern.Interface;

namespace FactoryMethodPattern.FactoryMethod.Concrete_Factory
{
    public class PlatiumFactory : CreditCardFactory
    {
        protected override ICreditCard MakeProduct()
        {
            ICreditCard platinumCard = new Platinum();
            return platinumCard;
        }
    }
}
