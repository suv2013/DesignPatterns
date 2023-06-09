using AbstractFactoryPattern.AbstractProduct;

namespace AbstractFactoryPattern.ConcreteProduct
{
    internal class SportCar :ICar
    {
        public void GetDetails()
        {
            Console.WriteLine("Fetching Sport Cars ...\n");
        }
    }
}
