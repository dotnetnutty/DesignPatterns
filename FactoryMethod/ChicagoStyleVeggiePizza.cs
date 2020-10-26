using System;

namespace FactoryMethod
{
    /// <summary>
    /// Veggie pizza produced by the <see cref="ChicagoPizzaStore"/>.
    /// </summary>
    internal sealed class ChicagoStyleVeggiePizza : Pizza
    {
        internal ChicagoStyleVeggiePizza()
        {
            Name = "Chicago-style veggie pizza";
            Dough = "Extra-thick crust";
            Sauce = "Plum tom";
            Toppings.Add("Shredded mozzarella");
        }

        public override void Cut()
        {
            Console.WriteLine("Cutting into squares");
        }
    }
}
