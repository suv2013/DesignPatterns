using AbstractFactoryPattern.AbstractFactory;
using AbstractFactoryPattern.AbstractProduct;
using AbstractFactoryPattern.ConcreteProduct;

namespace AbstractFactoryPattern.ConcreteFactory
{
    internal class RegularVehicleFactory : IVehicleFactory
    {
        public IBike CreateBike()
        {
            RegularBike regularBike = new RegularBike();
            return regularBike;
        }

        public ICar CreateCar()
        {
            RegularCar regularCar = new RegularCar();
            return regularCar;
        }
    }
}
