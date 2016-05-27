namespace DecoratorPattern
{
    public sealed class Espresso : Beverage
    {
        public Espresso()
        {
            _description = "Espresso";
        }

        public override decimal Cost()
        {
            return 1.99m;
        }
    }
}