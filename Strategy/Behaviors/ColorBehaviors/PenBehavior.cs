using System;
using System.ComponentModel;
using Strategy.Behaviors.ColorBehaviors.Base;
using Strategy.Elements.Base;
using System.Drawing;

namespace Strategy.Behaviors.ColorBehaviors
{
    [Description("Pen")]
    public class PenBehavior : BaseColorBehavior
    {
        public PenBehavior(BaseElement element, Graphics graphics)
            :base(element,graphics)
        {
        }

        public override void Draw()
        {
            var pen = new Pen(_colors[currentIndex]);
            Type type = _graphics.GetType();
            var mi = type.GetMethod("Draw" + _element.MethodName, new Type[] { typeof(Pen), _element.GetGeometryStruct.GetType() });
            lock (lockObject)
            {
                mi.Invoke(_graphics, new object[] { pen, _element.GetGeometryStruct });
            }
            base.Draw();
        }
    }
}
