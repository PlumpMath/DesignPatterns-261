
using Common;

namespace AbstractFactory.Families.Base
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
