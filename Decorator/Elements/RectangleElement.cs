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
        public RectangleElement(Graphics graphics, IElement element, Rectangle rect)
            :base(graphics, element,rect)
        {
        }

        public override void Draw()
        {
            base.Draw();
            _graphics.DrawRectangle(Pens.Red, _rect);
        }
    }
}
