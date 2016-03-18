using System.Drawing;
using System.ComponentModel;
using Strategy.Elements.Base;

namespace Strategy.Elements
{
    [Description("Ellipse")]
    public class EllipseElement : BaseElement
    {
        public override string MethodName
        {
            get { return "Ellipse"; }
        }

        public override object GetGeometryStruct
        {
            get { return Rect; }
        }
    }
}
