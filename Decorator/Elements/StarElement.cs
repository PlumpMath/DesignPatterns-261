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
        public StarElement(IElement element, int sideLength)
            : base(element,sideLength)
        {
        }

        public override void Draw(Graphics graphics, Point location)
        {
            base.Draw(graphics,location);
            var rect = new Rectangle(location, new Size(_sideLength, _sideLength));
            graphics.DrawPolygon(Pens.Yellow,
                BaseStarElement.Calculate5StarPoints(rect.Location, _sideLength, _sideLength/2));
        }
        
      
    }
}
