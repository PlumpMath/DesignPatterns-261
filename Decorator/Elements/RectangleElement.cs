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
            graphics.DrawRectangle(Pens.Red, new Rectangle(new Point(location.X-_sideLength/2,location.Y-_sideLength/2), new Size(_sideLength, _sideLength)));
        }
    }
}
