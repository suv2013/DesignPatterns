// See https://aka.ms/new-console-template for more information
using FactoryMethodPattern;
using FactoryMethodPattern.FactoryMethod;
using FactoryMethodPattern.FactoryMethod.Concrete_Factory;

Console.WriteLine("Hello, Factory Method Pattern!\n");

Console.WriteLine("Creating Platium Card!\n");
CreditCard platiumCreditCard = new PlatiumFactory().CreateProduct();
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
CreditCard titaniumCreditCard = new TitaniumFactory().CreateProduct();
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
CreditCard moneyBackCreditCard = new MoneyBackFactory().CreateProduct();
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