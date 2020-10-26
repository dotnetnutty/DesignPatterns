using AbstractFactory.Ingredients;

namespace AbstractFactory.IngredientFactories
{
    /// <summary>
    /// Factory that produces the Chicago family of products
    /// </summary>
    internal sealed class ChicagoPizzaIngredientFactory : IPizzaIngredientFactory
    {
        public Cheese CreateCheese()
        {
            return new ShreddedMozzarellaCheese();
        }

        public Clam CreateClam()
        {
            return new FrozenClam();
        }

        public Dough CreateDough()
        {
            return new ThickCrustDough();
        }

        public Pepperoni CreatePepperoni()
        {
            return new SlicedPepperoni();
        }

        public Sauce CreateSauce()
        {
            return new PlumTomSauce();
        }
    }
}
