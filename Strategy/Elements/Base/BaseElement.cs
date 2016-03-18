using System.Drawing;
using Strategy.Behaviors.Base;

namespace Strategy.Elements.Base
{
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
