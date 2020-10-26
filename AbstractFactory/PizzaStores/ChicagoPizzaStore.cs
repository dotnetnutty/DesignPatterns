using AbstractFactory.IngredientFactories;
using AbstractFactory.Pizzas;

namespace AbstractFactory.PizzaStores
{
    /// <summary>
    /// Implements the <see cref="CreatePizza(string)"/> factory method.
    /// </summary>
    internal sealed class ChicagoPizzaStore : PizzaStore
    {
        protected override Pizza CreatePizza(string pizzaType)
        {
            IPizzaIngredientFactory ingredientFactory = new ChicagoPizzaIngredientFactory();

            Pizza pizza = null;

            switch (pizzaType)
            {
                case "cheese":
                    pizza = new CheesePizza(ingredientFactory)
                    {
                        Name = "Chicago-Style Cheese"
                    };
                    break;
                case "clam":
                    pizza = new ClamPizza(ingredientFactory)
                    {
                        Name = "Chicago-Style Clam"
                    };
                    break;
                default:
                    break;
            }

            return pizza;
        }
    }
}
