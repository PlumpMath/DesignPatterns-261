
using Common;

namespace AbstractFactory.Families.Base
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
