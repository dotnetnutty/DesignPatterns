using System;

namespace FactoryMethod
{
    /// <summary>
    /// Factory Method has Creator classes (Pizza stores) and Product classes (Pizzas).
    /// </summary>
    internal static class Program
    {
        static void Main(string[] args)
        {
            var nyStore = new NYPizzaStore();
            var chicagoPizzaStore = new ChicagoPizzaStore();

            var pizza1 = nyStore.OrderPizza("cheese");
            Console.WriteLine($"Person 1 ordered {pizza1.Name}");

            Console.WriteLine("---");

            var pizza2 = chicagoPizzaStore.OrderPizza("cheese");
            Console.WriteLine($"Person 2 ordered {pizza2.Name}");
        }
    }
}
