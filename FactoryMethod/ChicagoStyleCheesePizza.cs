using System;

namespace FactoryMethod
{
    /// <summary>
    /// Cheese pizza produced by the <see cref="ChicagoPizzaStore"/>.
    /// </summary>
    internal sealed class ChicagoStyleCheesePizza : Pizza
    {
        internal ChicagoStyleCheesePizza()
        {
            Name = "Chicago-style cheese pizza";
            Dough = "Extra-thick crust";
            Sauce = "Plum tom";
            Toppings.Add("Shredded mozzarella");
        }

        public override void Cut()
        {
            Console.WriteLine("Cut into squares");
        }
    }
}
