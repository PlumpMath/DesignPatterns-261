using System.Collections.Generic;
using System.Drawing;
using Strategy.Behaviors.Base;
using Strategy.Elements.Base;

namespace Strategy.Behaviors.ColorBehaviors.Base
{
    public abstract class BaseColorBehavior : BaseBehavior
    {
        protected List<Color> _colors;
        protected int currentIndex;

        protected BaseColorBehavior(BaseElement element, Graphics graphics)
            :base(element,graphics)
        {
            _colors = new List<Color>() { Color.Red, Color.Green, Color.Blue };
        }
        public override void Draw()
        {
            currentIndex = (currentIndex + 1) % _colors.Count;
        }
    }
}
