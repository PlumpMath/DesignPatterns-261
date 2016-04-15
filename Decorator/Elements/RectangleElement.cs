using System.ComponentModel;
using System.Drawing;
using DP.Common.Attributes;
using DP.Decorator.Elements.Base;

namespace DP.Decorator.Elements
{
    [PatternSourceCode]
    [Description("Rect")]
    public class RectangleElement : GraphicElement
    {
        public RectangleElement(IElement element, int sideLength)
            :base(element,sideLength)
        {
        }

        public override void Draw(Graphics graphics, Point location)
        {
            base.Draw(graphics,location);
            graphics.DrawRectangle(Pens.Red, new Rectangle(location, new Size(_sideLength, _sideLength)));
        }
    }
}
