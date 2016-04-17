using System.Drawing;
using DP.Common.Attributes;
using DP.Decorator.Elements.Base;

namespace DP.Decorator.Elements
{
    [PatternSourceCode]
    public class GraphicElement : IElement
    {
        private readonly IElement _element;
        protected int _sideLength;

        public GraphicElement(IElement element, int sideLength)
        {
            _element = element;
            _sideLength = sideLength;
        }
        public virtual void Draw(Graphics graphics,Point location) =>_element.Draw(graphics,location);
    }
}
