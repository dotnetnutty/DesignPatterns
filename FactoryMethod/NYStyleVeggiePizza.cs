namespace FactoryMethod
{
    internal sealed class NYStyleVeggiePizza : Pizza
    {
        internal NYStyleVeggiePizza()
        {
            Name = "NY-style veggie pizza";
            Dough = "Thin crust";
            Sauce = "Marinara";
            Toppings.Add("Grated Reggiano Cheese");
        }
    }
}