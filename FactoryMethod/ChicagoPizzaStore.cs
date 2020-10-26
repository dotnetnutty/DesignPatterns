namespace FactoryMethod
{
    /// <summary>
    /// Implements the <see cref="CreatePizza(string)"/> factory method.
    /// </summary>
    internal class ChicagoPizzaStore : PizzaStore
    {
        protected override Pizza CreatePizza(string pizzaType)
        {
            return pizzaType switch
            {
                "cheese" => new ChicagoStyleCheesePizza(),
                "veggie" => new ChicagoStyleVeggiePizza(),
                _ => null,
            };
        }
    }
}
