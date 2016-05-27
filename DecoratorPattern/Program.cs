using System;

namespace DecoratorPattern
{
    sealed class Program
    {
        static void Main(string[] args)
        {
            Beverage beverage = new Espresso();
            Console.WriteLine(beverage.GetDescription() + ", total £" + beverage.Cost());

            Beverage beverage2 = new HouseBlend();
            Console.WriteLine(beverage2.GetDescription() + ", total £" + beverage2.Cost());

            beverage2 = new Mocha(beverage2);
            beverage2 = new Whip(beverage2);
            Console.WriteLine(beverage2.GetDescription() + ", total £" + beverage2.Cost());
        }
    }
}