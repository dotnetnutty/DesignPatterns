using AbstractFactory.Ingredients;

namespace AbstractFactory.IngredientFactories
{
    /// <summary>
    /// An abstract factory that defines a set of methods
    /// for producing a family of related products
    /// </summary>
    public interface IPizzaIngredientFactory
    {
        Dough CreateDough();
        Sauce CreateSauce();
        Cheese CreateCheese();
        Pepperoni CreatePepperoni();
        Clam CreateClam();
    }
}
