using DecoratorPattern.Component;
using DecoratorPattern.Decorator;

namespace DecoratorPattern.ConcreteDecorator
{
    class Chocolate : ExtraDecorator
    {
        public Chocolate(Beverage beverage) : base(beverage)
        {
        }

        public override int Cost()
        {
            return base.Cost() + 15;
        }

        public override string Description()
        {
            return $"{base.Description()}, Chocolate";
        }
    }
}

