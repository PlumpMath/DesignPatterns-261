using System.Drawing;
using DP.Strategy.Behaviors.Base;
using DP.Common.Attributes;

namespace DP.Strategy.Elements.Base
{
    [PatternSourceCode]
    public abstract class BaseElement
    {
        private BaseBehavior _behavior;
        public abstract string MethodName { get; }
        public abstract object GetGeometryStruct { get; }

        public Rectangle Rect { get; set; }

        public void SetBehavior(BaseBehavior behavior)
        {
            _behavior = behavior;
        }

        public void PerformBehavior()
        {
            _behavior.Draw();
        }
    }
}
