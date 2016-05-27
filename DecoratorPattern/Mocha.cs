namespace DecoratorPattern
{
    public sealed class Mocha : CondimentDecorator
    {
        Beverage _beverage;

        public Mocha(Beverage beverage)
        {
            _beverage = beverage;
        }

        public override decimal Cost()
        {
            return 0.20m + _beverage.Cost();
        }

        public override string GetDescription()
        {
            return _beverage.GetDescription() + ", Mocha @ 20p";
        }
    }
}