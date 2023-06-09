using FactoryMethodPattern.CreditCards;

namespace FactoryMethodPattern.FactoryMethod.Concrete_Factory
{
    public class PlatiumFactory : CreditCardFactory
    {
        protected override CreditCard MakeProduct()
        {
            CreditCard platinumCard = new Platinum();
            return platinumCard;
        }
    }
}
