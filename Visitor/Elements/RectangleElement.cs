using System.Drawing;
using DP.Common.Attributes;
using DP.Visitor.Visitors;

namespace DP.Visitor.Elements
{
    [PatternSourceCode]
    public class RectangleElement : BaseElement
    {
        public RectangleElement(Rectangle rect)
            :base(rect)
        {

        }
        public override void Accept(BaseVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
