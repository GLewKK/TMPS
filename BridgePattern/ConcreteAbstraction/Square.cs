using BridgePattern.Abstraction;
using BridgePattern.Implementor;
using System;

namespace BridgePattern.ConcreteAbstraction
{
    public class Square : Shape
    {
        public Square(IColor color) : base(color)
        {
        }

        public override void Draw()
        {
            Console.WriteLine($"Draws a { _color.GetColor() } square");
        }
    }
}
