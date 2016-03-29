using Common;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Visitor.Visitors;

namespace Visitor.Elements
{
    [PatternSourceCode]
    public class EllipseElement : BaseElement
    {
        protected EllipseElement(Rectangle rect)
            :base(rect)
        {
            
        }
        public override void Accept(BaseVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
