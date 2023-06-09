using AbstractFactoryPattern.AbstractProduct;

namespace AbstractFactoryPattern.ConcreteProduct
{
    internal class SportBike : IBike
    {
        public void GetDetails()
        {
            Console.WriteLine("Fetching Sport Bikes ...\n");
        }
    }
}
