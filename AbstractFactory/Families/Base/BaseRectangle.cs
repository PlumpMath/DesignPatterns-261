
using DP.Common;
using DP.Common.Attributes;

namespace DP.AbstractFactory.Families.Base
{
    [PatternSourceCode]
    public abstract class BaseRectangle : BaseElement
    {
        public override string Text
        {
            get { return "Rectangle"; }
        }

    }
}
