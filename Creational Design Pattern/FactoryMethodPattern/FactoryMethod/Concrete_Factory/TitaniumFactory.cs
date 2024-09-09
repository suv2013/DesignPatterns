using FactoryMethodPattern.CreditCards;
using FactoryMethodPattern.Interface;

namespace FactoryMethodPattern.FactoryMethod.Concrete_Factory
{
    public class TitaniumFactory : CreditCardFactory
    {
        protected override ICreditCard MakeProduct()
        {
            ICreditCard titaniumCard = new Titanium();
            return titaniumCard;
        }
    }
}
