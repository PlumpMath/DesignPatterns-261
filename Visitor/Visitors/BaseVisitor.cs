using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Visitor.Elements;

namespace Visitor.Visitors
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
