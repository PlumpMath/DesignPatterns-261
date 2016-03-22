using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.Elements;
using Visitor.Elements;

namespace Visitor.Visitors
{
    public class EmptyVisitor : BaseVisitor
    {
        private Pen _pen = Pens.Blue;

        public EmptyVisitor(Graphics graphics)
            : base(graphics)
        {

        }

        public override void Visit(EllipseElement ellipse)
        {
            _graphics.DrawEllipse(_pen, ellipse.Rect);
        }

        public override void Visit(RectangleElement rectangle)
        {
            _graphics.DrawRectangle(_pen, rectangle.Rect);
        }

        public override void Visit(StarElement star)
        {
            _graphics.DrawPolygon(_pen,
                BaseStarElement.Calculate5StarPoints(star.Rect.Location, star.Rect.Width, star.Rect.Width/2));
            //_graphics.FillEllipse(_brush, s);
        }
    }
}
