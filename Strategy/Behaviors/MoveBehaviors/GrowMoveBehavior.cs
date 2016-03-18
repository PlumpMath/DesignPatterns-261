using System;
using System.ComponentModel;
using Strategy.Behaviors.Base;
using Strategy.Elements.Base;
using System.Drawing;

namespace Strategy.Behaviors.MoveBehaviors
{
    [Description("Grow")]
    public class GrowMoveBehavior : BaseBehavior
    {
        protected int iteration;
        protected bool isdecrement;
        public GrowMoveBehavior(BaseElement element, Graphics graphics)
            :base(element,graphics)
        {
        }
        public override void Draw()
        {
            _graphics.Clear(Color.LightGray);
            Type type = _graphics.GetType();
            var currentRect = _element.Rect;
            _element.Rect = new Rectangle(currentRect.Location, new Size(currentRect.Width+iteration*10, currentRect.Height+iteration*10));
            var mi = type.GetMethod("Fill" + _element.MethodName,new Type[]{typeof(Brush), _element.GetGeometryStruct.GetType()});
            lock (lockObject)
            {
                mi.Invoke(_graphics, new object[] { Brushes.Green, _element.GetGeometryStruct });
            }

            if (iteration == 10)
                isdecrement = true;
            else if (iteration == 0)
                isdecrement = false;

             if (isdecrement) iteration--;
             else iteration++;
            //TODO неправильно то, что поведение управляет элементом. Надо создавать копию элемента.
            _element.Rect = currentRect;
        }
    }
}
