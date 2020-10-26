using System;
using System.Collections.Generic;

namespace FactoryMethod
{
    /// <summary>
    /// Product produced by the factory by <see cref="PizzaStore"/>.
    /// </summary>
    internal abstract class Pizza
    {
        public string Name { get; set; }

        public string Dough { private get; set; }

        public string Sauce { private get; set; }

        protected readonly List<string> Toppings = new List<string>();

        public virtual void Prepare()
        {
            Console.WriteLine("Preparing " + Name);
            Console.WriteLine($"Tossing dough ({Dough})...");
            Console.WriteLine($"Adding sauce ({Sauce})...");
            Console.WriteLine("Adding toppings:");

            foreach (var topping in Toppings)
            {
                Console.WriteLine("  " + topping);
            }
        }

        public virtual void Bake()
        {
            Console.WriteLine("Bake at 350");
        }

        public virtual void Cut()
        {
            Console.WriteLine("Cut the pizza into sectors");
        }

        public virtual void Box()
        {
            Console.WriteLine("Place pizza in official box");
        }
    }
}