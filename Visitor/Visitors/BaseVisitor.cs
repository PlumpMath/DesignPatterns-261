using System.Drawing;
using DP.Visitor.Elements;

namespace DP.Visitor.Visitors
{
    public abstract class BaseVisitor
    {
        protected readonly Graphics _graphics;

        public BaseVisitor(Graphics graphics)
        {
            _graphics = graphics;
        }
        public abstract void Visit(EllipseElement ellipse);
        public abstract void Visit(RectangleElement rectangle);
        public abstract void Visit(StarElement star);
    }
}
