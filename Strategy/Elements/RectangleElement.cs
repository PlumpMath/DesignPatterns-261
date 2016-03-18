using System.Drawing;
using System.ComponentModel;
using Strategy.Elements.Base;

namespace Strategy.Elements
{
    [Description("Rect")]
    public class RectangleElement : BaseElement
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
