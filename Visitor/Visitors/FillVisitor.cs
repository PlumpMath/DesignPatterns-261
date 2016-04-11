using System.Drawing;
using Visitor.Elements;
using DP.Common;

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
            _graphics.FillPolygon(_brush, BaseStarElement.Calculate5StarPoints(star.Rect.Location, star.Rect.Width, star.Rect.Width / 2));
            //_graphics.FillEllipse(_brush, s);
        }
    }
}
