namespace DecoratorPattern
{
    public sealed class Whip : CondimentDecorator
    {
        Beverage _beverage;

        public Whip(Beverage beverage)
        {
            _beverage = beverage;
        }

        public override decimal Cost()
        {
            return 0.39m + _beverage.Cost();
        }

        public override string GetDescription()
        {
            return _beverage.GetDescription() + ", Whip @ 39p";
        }
    }
}