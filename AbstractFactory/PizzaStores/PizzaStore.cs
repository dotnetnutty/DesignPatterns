using AbstractFactory.Pizzas;

namespace AbstractFactory.PizzaStores
{
    /// <summary>
    /// <para>Defines the <see cref="OrderPizza"/> method, which calls the <see cref="CreatePizza"/> method. This
    /// latter method must be implemented by the <see cref="PizzaStore"/>.</para>
    /// <para>When the <see cref="Pizza.Prepare"/> method is called within <see cref="OrderPizza"/>, the store asks the
    /// factory to prepare the ingredients. It returns a <see cref="Pizza"/> made with the ingredients specific to
    /// the <see cref="PizzaStore"/>.</para>
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
