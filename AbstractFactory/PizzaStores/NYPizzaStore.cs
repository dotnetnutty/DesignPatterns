using AbstractFactory.IngredientFactories;
using AbstractFactory.Pizzas;

namespace AbstractFactory.PizzaStores
{
    /// <summary>
    /// Implements the <see cref="CreatePizza(string)"/> factory method.
    /// </summary>
    internal sealed class NYPizzaStore : PizzaStore
    {
        protected override Pizza CreatePizza(string pizzaType)
        {
            IPizzaIngredientFactory ingredientFactory = new NYPizzaIngredientFactory();

            Pizza pizza = null;

            switch (pizzaType)
            {
                case "cheese":
                    pizza = new CheesePizza(ingredientFactory)
                    {
                        Name = "NY-Style Cheese"
                    };
                    break;
                case "clam":
                    pizza = new ClamPizza(ingredientFactory)
                    {
                        Name = "NY-Style Clam"
                    };
                    break;
                default:
                    break;
            }

            return pizza;
        }
    }
}
