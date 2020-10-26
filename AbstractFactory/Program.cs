using AbstractFactory.PizzaStores;
using System;

namespace AbstractFactory
{
    internal static class Program
    {
        static void Main(string[] args)
        {
            var nyStore = new NYPizzaStore();
            var chicagoPizzaStore = new ChicagoPizzaStore();

            var pizza1 = nyStore.OrderPizza("cheese");
            Console.WriteLine($"Person 1 ordered {pizza1.Name} ({pizza1.Dough.DoughType})");

            Console.WriteLine("---");

            var pizza2 = chicagoPizzaStore.OrderPizza("cheese");
            Console.WriteLine($"Person 2 ordered {pizza2.Name} ({pizza2.Dough.DoughType})");
        }
    }
}
