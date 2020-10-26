namespace FactoryMethod
{
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
