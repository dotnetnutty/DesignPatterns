using AbstractFactory.Ingredients;

namespace AbstractFactory.IngredientFactories
{
    /// <summary>
    /// Factory that produces the NY family of products
    /// </summary>
    internal sealed class NYPizzaIngredientFactory : IPizzaIngredientFactory
    {
        public Cheese CreateCheese()
        {
            return new ReggianoCheese();
        }

        public Clam CreateClam()
        {
            return new FreshClam();
        }

        public Dough CreateDough()
        {
            return new ThinCrustDough();
        }

        public Pepperoni CreatePepperoni()
        {
            return new SlicedPepperoni();
        }

        public Sauce CreateSauce()
        {
            return new MarinaraSauce();
        }
    }
}
