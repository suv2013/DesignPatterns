using AbstractFactoryPattern.AbstractFactory;
using AbstractFactoryPattern.AbstractProduct;
using AbstractFactoryPattern.ConcreteProduct;

namespace AbstractFactoryPattern.ConcreteFactory
{
    internal class SportVehicleFactory : IVehicleFactory
    {
        public IBike CreateBike()
        {
            SportBike bike = new SportBike();
            return bike;
        }

        public ICar CreateCar()
        {
            SportCar car = new SportCar();
            return car;
        }
    }
}
