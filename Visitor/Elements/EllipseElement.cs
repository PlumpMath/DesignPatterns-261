using System.Drawing;
using DP.Common.Attributes;
using DP.Visitor.Visitors;

namespace DP.Visitor.Elements
{
    [PatternSourceCode]
    public class EllipseElement : BaseElement
    {
        public EllipseElement(Rectangle rect)
            :base(rect)
        {
            
        }
        public override void Accept(BaseVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
