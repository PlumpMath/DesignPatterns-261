using System.ComponentModel;
using System.Drawing;
using DP.Common;
using DP.Common.Attributes;
using DP.Decorator.Elements.Base;

namespace DP.Decorator.Elements
{
    [PatternSourceCode]
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
