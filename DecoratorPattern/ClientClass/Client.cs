using DecoratorPattern.Component;
using System;

namespace DecoratorPattern.ClientClass
{
    public class Client
    {
        public void ClientCode(Beverage beverage)
        {
            Console.WriteLine($"Description: {beverage.Description()}");
            Console.WriteLine($"Final Cost: { beverage.Cost()}");
        }
    }
}

