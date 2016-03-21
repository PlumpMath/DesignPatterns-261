using System.ComponentModel;
using Common.Elements.Base;

namespace Common.Elements
{
    [Description("Ellipse")]
    internal class EllipseElement : BaseElement
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
