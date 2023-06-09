// See https://aka.ms/new-console-template for more information
using AbstractFactoryPattern.AbstractFactory;
using AbstractFactoryPattern.AbstractProduct;
using AbstractFactoryPattern.ConcreteFactory;

Console.WriteLine("Abstract Factory Design Pattern !\n");

IVehicleFactory regularVehicleFactory = new RegularVehicleFactory();

IBike regularBike = regularVehicleFactory.CreateBike();
regularBike.GetDetails();

ICar regularCar = regularVehicleFactory.CreateCar();
regularCar.GetDetails();

IVehicleFactory sportVehicleFactory = new SportVehicleFactory();

IBike sportBike = sportVehicleFactory.CreateBike();
sportBike.GetDetails();

ICar sportCar = sportVehicleFactory.CreateCar();
sportCar.GetDetails();
