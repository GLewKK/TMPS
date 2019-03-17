using BridgePattern.Implementor;

namespace BridgePattern.ConcreteImplementor
{
    public class BlueColor : IColor
    {
        public string GetColor()
        {
            return "blue";
        }
    }

}
