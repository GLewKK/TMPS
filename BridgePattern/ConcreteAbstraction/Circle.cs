using BridgePattern.Abstraction;
using BridgePattern.Implementor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern.ConcreteAbstraction
{
    class Circle : Shape
    {
        public Circle(IColor color) : base(color)
        {
        }

        public override void Draw()
        {
            Console.WriteLine($"Draws a { _color.GetColor() } circle");
        }
    }
}
