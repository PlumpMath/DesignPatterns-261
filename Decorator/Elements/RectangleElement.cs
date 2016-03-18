using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.ComponentModel;
using Decorator.Elements.Base;

namespace Decorator.Elements
{
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
