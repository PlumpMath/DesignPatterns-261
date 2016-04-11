using System;
using System.ComponentModel;
using System.Drawing;
using Strategy.Elements.Base;
using DP.Common;

namespace Strategy.Elements
{
    [Description("Star")]
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
