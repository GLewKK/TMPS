using System;
using BridgePattern.Implementor;

namespace BridgePattern.ConcreteAbstraction
{
    class Triangle : Abstraction.Shape
    {
        public Triangle(IColor color) : base(color)
        {
        }

        public override void Draw()
        {
            Console.WriteLine($"Draw a {_color.GetColor()} Triangle");
        }
    }
}
