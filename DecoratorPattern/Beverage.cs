namespace DecoratorPattern
{
    public abstract class Beverage
    {
        protected string _description = "Unknown beverage";

        public virtual string GetDescription()
        {
            return _description;
        }

        public abstract decimal Cost();
    }
}