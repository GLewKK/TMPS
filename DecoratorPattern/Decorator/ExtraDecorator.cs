using DecoratorPattern.Component;

namespace DecoratorPattern.Decorator
{
    abstract class ExtraDecorator : Beverage
    {
        protected Beverage _beverage;

        public ExtraDecorator(Beverage beverage)
        {
            _beverage = beverage;
        }

        public void SetComponent(Beverage component)
        {
            _beverage = component;
        }

        public override int Cost()
        {
            return _beverage != null ? _beverage.Cost() : default;

        }

        public override string Description()
        {
            return _beverage != null ? _beverage.Description() : string.Empty;
        }
    }
}

