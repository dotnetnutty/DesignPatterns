namespace FactoryMethod
{
    internal class ChicagoPizzaStore : PizzaStore
    {
        protected override Pizza CreatePizza(string pizzaType)
        {
            switch (pizzaType)
            {
                case "cheese":
                    return new ChicagoStyleCheesePizza();
                case "veggie":
                    return new ChicagoStyleVeggiePizza();
                default:
                    return null;
            }
        }
    }
}
