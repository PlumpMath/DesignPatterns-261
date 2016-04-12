
using DP.Common;
using DP.Common.Attributes;

namespace DP.AbstractFactory.Families.Base
{
    [PatternSourceCode]
    public abstract class BaseEllipse:BaseElement
    {
        public override string Text
        {
            get { return "Ellipse"; }
        }

    }
}
