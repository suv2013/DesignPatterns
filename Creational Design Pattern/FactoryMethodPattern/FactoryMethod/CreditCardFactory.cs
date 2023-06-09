namespace FactoryMethodPattern.FactoryMethod
{
    public abstract class CreditCardFactory
    {
        protected abstract CreditCard MakeProduct();

        public CreditCard CreateProduct()
        {
            CreditCard creditCard = this.MakeProduct();
            return creditCard;
        }
    }
}
