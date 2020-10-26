using AbstractFactory.IngredientFactories;
using AbstractFactory.Ingredients;
using System;
using System.Collections.Generic;

namespace AbstractFactory.Pizzas
{
    /// <summary>
    /// Clients of the abstract factory (<see cref="IPizzaIngredientFactory"/>) are
    /// the concrete instances of this class.
    /// </summary>
    internal abstract class Pizza
    {
        public string Name { get; set; }

        public Dough Dough { get; set; }

        public Sauce Sauce { get; set; }

        public Cheese Cheese { get; set; }

        public Pepperoni Pepperoni { get; set; }

        public Clam Clam { get; set; }

        protected readonly List<string> Toppings = new List<string>();

        public abstract void Prepare();

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