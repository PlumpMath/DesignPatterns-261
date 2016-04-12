using System.Drawing;
using DP.Common.Attributes;
using DP.Decorator.Elements.Base;

namespace DP.Decorator.Elements
{
    [PatternSourceCode]
    public class GraphicElement : IElement
    {
        private IElement _element;
        protected Graphics _graphics;
        protected Rectangle _rect;

        public GraphicElement(Graphics graphics, IElement element, Rectangle rect)
        {
            _graphics = graphics;
            _element = element;
            _rect = rect;
        }
        public virtual void Draw()
        {
            _element.Draw();
        }

        //protected Pen CurrentPen
        //{
        //    get
        //    {
        //        return Pens.Cyan;
        //    }
        //}
    }
}
