using BridgePattern.Implementor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern.ConcreteImplementor
{
    class GrayColor : IColor
    {
        public string GetColor()
        {
            return "gray";
        }
    }
}
