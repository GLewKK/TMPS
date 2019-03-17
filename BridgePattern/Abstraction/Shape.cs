using BridgePattern.Implementor;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern.Abstraction
{
    public abstract class Shape
    {
        public IColor _color;
        public Shape(IColor color)
        {
            _color = color;
        }
        public abstract void Draw();
    }
}
