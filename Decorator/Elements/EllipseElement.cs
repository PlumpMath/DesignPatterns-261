using System.ComponentModel;
using System.Drawing;
using DP.Common.Attributes;
using DP.Decorator.Elements.Base;

namespace DP.Decorator.Elements
{
    [Description("Ellipse")]
    [PatternSourceCode]
    public class EllipseElement : GraphicElement
    {
        public EllipseElement(IElement element, int sideLength)
            : base(element,sideLength)
        {
        }

        public override void Draw(Graphics graphics, Point location)
        {
            base.Draw(graphics,location);
            graphics.DrawEllipse(Pens.Green, new Rectangle(new Point(location.X - _sideLength / 2, location.Y - _sideLength / 2), new Size(_sideLength, _sideLength)));
        }
    }
}
