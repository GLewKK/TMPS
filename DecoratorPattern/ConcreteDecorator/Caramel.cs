using DecoratorPattern.Component;
using DecoratorPattern.Decorator;

namespace DecoratorPattern.ConcreteDecorator
{
    class Caramel : ExtraDecorator
    {
        public Caramel(Beverage comp) : base(comp)
        {
        }

        public override int Cost()
        {
            return base.Cost() + 10;
        }

        public override string Description()
        {
            return $"{base.Description()}, Caramel";
        }
    }
}

