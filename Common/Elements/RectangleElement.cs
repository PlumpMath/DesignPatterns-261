using System.ComponentModel;
using Common.Elements.Base;

namespace Common.Elements
{
    [Description("Rect")]
    internal class RectangleElement : BaseElement
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
