using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Drawing;
using Decorator.Elements.Base;
using DP.Common;

namespace Decorator.Elements
{
    [Description("Star")]
    public class StarElement : GraphicElement
    {
        public StarElement(Graphics graphics, IElement element,Rectangle rect)
            : base(graphics, element,rect)
        {
        }

        public override void Draw()
        {
            base.Draw();
            _graphics.DrawPolygon(Pens.Yellow, BaseStarElement.Calculate5StarPoints(_rect.Location,_rect.Width,_rect.Width/2));
        }
        
      
    }
}
