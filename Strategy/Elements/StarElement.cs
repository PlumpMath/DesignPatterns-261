using System;
using System.ComponentModel;
using System.Drawing;
using DP.Strategy.Elements.Base;
using DP.Common;
using DP.Common.Attributes;

namespace DP.Strategy.Elements
{
    [Description("Star")]
    [PatternSourceCode]
    public class StarElement : BaseElement
    {
        public override string MethodName
        {
            get { return "Polygon"; }
        }

        public override object GetGeometryStruct
        {
            get { return BaseStarElement.Calculate5StarPoints(Rect.Location, Rect.Width, Rect.Width / 2); }
        }

      
    }
}
