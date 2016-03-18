using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using Decorator.Elements.Base;

namespace Decorator.Elements
{
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
