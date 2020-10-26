namespace FactoryMethod
{
    /// <summary>
    /// Abstract creator class.
    /// Defines an abstract factory method that the
    /// subclasses must implement to produce products.
    /// </summary>
    internal abstract class PizzaStore
    {
        internal Pizza OrderPizza(string pizzaType)
        {
            var pizza = CreatePizza(pizzaType);

            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();

            return pizza;
        }

        protected abstract Pizza CreatePizza(string pizzaType);
    }
}
