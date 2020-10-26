namespace FactoryMethod
{
    internal sealed class NYStyleCheesePizza : Pizza
    {
        internal NYStyleCheesePizza()
        {
            Name = "NY-style cheese pizza";
            Dough = "Thin crust";
            Sauce = "Marinara";
            Toppings.Add("Grated Reggiano Cheese");
        }
    }
}