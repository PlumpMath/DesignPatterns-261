using System.Drawing;
using System.ComponentModel;
using DP.Strategy.Elements.Base;
using DP.Common.Attributes;

namespace DP.Strategy.Elements
{
    [Description("Ellipse")]
    [PatternSourceCode]
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
