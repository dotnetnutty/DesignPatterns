namespace DecoratorPattern
{
    public sealed class HouseBlend : Beverage
    {
        public HouseBlend()
        {
            _description = "House Blend Coffee";
        }

        public override decimal Cost()
        {
            return 0.89m;
        }
    }
}