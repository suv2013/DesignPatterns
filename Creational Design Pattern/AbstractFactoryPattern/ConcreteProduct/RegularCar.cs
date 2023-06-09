using AbstractFactoryPattern.AbstractProduct;

namespace AbstractFactoryPattern.ConcreteProduct
{
    internal class RegularCar :ICar
    {
        public void GetDetails()
        {
            Console.WriteLine("Fetching Regular Cars ...\n");
        }
    }
}
