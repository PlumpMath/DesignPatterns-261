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
        public EllipseElement(Graphics graphics, IElement element,Rectangle rect)
            : base(graphics, element,rect)
        {
        }

        public override void Draw()
        {
            base.Draw();
            _graphics.DrawEllipse(Pens.Green, _rect);
        }
    }
}
