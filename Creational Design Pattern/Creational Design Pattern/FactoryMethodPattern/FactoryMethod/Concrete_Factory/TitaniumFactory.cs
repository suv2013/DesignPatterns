using FactoryMethodPattern.CreditCards;

namespace FactoryMethodPattern.FactoryMethod.Concrete_Factory
{
    public class TitaniumFactory : CreditCardFactory
    {
        protected override CreditCard MakeProduct()
        {
            CreditCard titaniumCard = new Titanium();
            return titaniumCard;
        }
    }
}
