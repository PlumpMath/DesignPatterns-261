using System.Drawing;
using DP.Common.Attributes;
using DP.Visitor.Visitors;

namespace DP.Visitor.Elements
{
    [PatternSourceCode]
    public abstract class BaseElement
    {
        public abstract void Accept(BaseVisitor visitor);
        public Rectangle Rect { get; private set; }

        protected BaseElement(Rectangle rect)
        {
            Rect = rect;
        }

        public override string ToString()
        {
            return GetType().Name;
        }
    }
}
