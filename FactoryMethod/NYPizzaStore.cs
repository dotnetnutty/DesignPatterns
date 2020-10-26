namespace FactoryMethod
{
    internal class NYPizzaStore : PizzaStore
    {
        protected override Pizza CreatePizza(string pizzaType)
        {
            switch (pizzaType)
            {
                case "cheese":
                    return new NYStyleCheesePizza();
                case "veggie":
                    return new NYStyleVeggiePizza();
                default:
                    return null;
            }
        }
    }
}
