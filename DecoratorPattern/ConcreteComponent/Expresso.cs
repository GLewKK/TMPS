using DecoratorPattern.Component;

namespace DecoratorPattern.ConcreteComponent
{
    class Expresso : Beverage
    {
        public override int Cost()
        {
            return 20;
        }

        public override string Description()
        {
            return "Expresso";
        }
    }
}

