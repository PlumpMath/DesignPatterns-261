using System.ComponentModel;
using Common.Elements.Base;

namespace Common.Elements
{
    [Description("Rect")]
    public class BaseRectangleElement : BaseElement
    {
        public override string MethodName
        {
            get { return "Rectangle"; }
        }

        public override object GetGeometryStruct
        {
            get { return Rect; }
        }
    }
}
