using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Visitor.Elements;

namespace Visitor.Visitors
{
    public class FillVisitor:BaseVisitor
    {
        private Brush _brush = Brushes.Blue;
        public FillVisitor(Graphics graphics)
            :base(graphics)
        {
            
        }
        public override void Visit(EllipseElement ellipse)
        {
            _graphics.FillEllipse(_brush,ellipse.Rect);
        }

        public override void Visit(RectangleElement rectangle)
        {
            _graphics.FillRectangle(_brush, rectangle.Rect);
        }

        public override void Visit(StarElement star)
        {

            //_graphics.FillEllipse(_brush, s);
        }
    }
}
