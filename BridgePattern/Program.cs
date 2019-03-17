using BridgePattern.ConcreteAbstraction;
using BridgePattern.ConcreteImplementor;
using System;

namespace BridgePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            RedColor red = new RedColor();
            Circle circle = new Circle(red);
            circle.Draw();
            Console.ReadKey();

        }
    }
}
