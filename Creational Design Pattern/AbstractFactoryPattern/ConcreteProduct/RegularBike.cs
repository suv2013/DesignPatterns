using AbstractFactoryPattern.AbstractProduct;

namespace AbstractFactoryPattern.ConcreteProduct
{
    internal class RegularBike: IBike
    {
        public void GetDetails()
        {
            Console.WriteLine("Fetching Regular Bikes ...\n");
        }
    }
}
