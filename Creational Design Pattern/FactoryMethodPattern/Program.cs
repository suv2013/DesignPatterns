// See https://aka.ms/new-console-template for more information
using FactoryMethodPattern.FactoryMethod;
using FactoryMethodPattern.FactoryMethod.Concrete_Factory;
using FactoryMethodPattern.Interface;

Console.WriteLine("Hello, Factory Method Pattern!\n");

Console.WriteLine("Creating Platium Card!\n");
ICreditCard platiumCreditCard = new PlatiumFactory().CreateProduct();
if(platiumCreditCard != null )
{
    Console.WriteLine("CreditCard Type : " + platiumCreditCard.GetCardType());
    Console.WriteLine("CreditCard Limit : " + platiumCreditCard.GetCreditLimit());
    Console.WriteLine("CreditCard Charges : " + platiumCreditCard.GetAnnualCharge());
}
else
{
    Console.WriteLine("Invalid Card Type");
}
Console.WriteLine("--------------");

Console.WriteLine("Creating Titanium Card!\n");
ICreditCard titaniumCreditCard = new TitaniumFactory().CreateProduct();
if (titaniumCreditCard != null)
{
    Console.WriteLine("CreditCard Type : " +   titaniumCreditCard.GetCardType());
    Console.WriteLine("CreditCard Limit : " + titaniumCreditCard.GetCreditLimit());
    Console.WriteLine("CreditCard Charges : " + titaniumCreditCard.GetAnnualCharge());
}
else
{
    Console.WriteLine("Invalid Card Type");
}
Console.WriteLine("--------------");

Console.WriteLine("Creating MoneyBack Card!\n");
ICreditCard moneyBackCreditCard = new MoneyBackFactory().CreateProduct();
if (titaniumCreditCard != null)
{
    Console.WriteLine("CreditCard Type : " + moneyBackCreditCard.GetCardType());
    Console.WriteLine("CreditCard Limit : " + moneyBackCreditCard.GetCreditLimit());
    Console.WriteLine("CreditCard Charges : " + moneyBackCreditCard.GetAnnualCharge());
}
else
{
    Console.WriteLine("Invalid Card Type");
}
Console.WriteLine("--------------");