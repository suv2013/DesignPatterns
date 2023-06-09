using AbstractFactoryPattern.AbstractProduct;

namespace AbstractFactoryPattern.AbstractFactory
{
    internal interface IVehicleFactory
    {
        IBike CreateBike();

        ICar CreateCar();
    }
}
