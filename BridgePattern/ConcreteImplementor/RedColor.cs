using BridgePattern.Implementor;

namespace BridgePattern.ConcreteImplementor
{
    public class RedColor : IColor
    {
        public string GetColor()
        {
            return "red";
        }
    }
}
