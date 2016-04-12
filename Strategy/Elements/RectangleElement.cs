using System.Drawing;
using System.ComponentModel;
using DP.Strategy.Elements.Base;
using DP.Common.Attributes;

namespace DP.Strategy.Elements
{
    [Description("Rect")]
    [PatternSourceCode]
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
