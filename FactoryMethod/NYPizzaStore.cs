namespace FactoryMethod
{
    /// <summary>
    /// Implements the <see cref="CreatePizza(string)"/> factory method.
    /// </summary>
    internal class NYPizzaStore : PizzaStore
    {
        protected override Pizza CreatePizza(string pizzaType)
        {
            return pizzaType switch
            {
                "cheese" => new NYStyleCheesePizza(),
                "veggie" => new NYStyleVeggiePizza(),
                _ => null,
            };
        }
    }
}
