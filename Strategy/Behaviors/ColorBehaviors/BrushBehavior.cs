using System;
using System.ComponentModel;
using Strategy.Behaviors.ColorBehaviors.Base;
using Strategy.Elements.Base;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace Strategy.Behaviors.ColorBehaviors
{
    [Description("Brush")]
    public class BrushBehavior : BaseColorBehavior
    {
        public BrushBehavior(BaseElement element, Graphics graphics)
            :base(element,graphics)
        {
        }
        public override void Draw()
        {
            int nextColorIndex = currentIndex + 1 < _colors.Count ? currentIndex + 1 : currentIndex - 1;
            var brush = new LinearGradientBrush(new Point(10, 10), new Point(100, 100), _colors[currentIndex],
                                                _colors[nextColorIndex]);

            Type type = _graphics.GetType();
            var mi = type.GetMethod("Fill" + _element.MethodName,new Type[]{typeof(Brush), _element.GetGeometryStruct.GetType()});
            lock (lockObject)
            {
                mi.Invoke(_graphics, new object[] { brush, _element.GetGeometryStruct });
            }
            base.Draw();
            
        }
    }
}
