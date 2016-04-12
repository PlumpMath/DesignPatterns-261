using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.ComponentModel;
using DP.Common.Attributes;

namespace DP.TemplateMethod.Methods
{
    [Description("Rectangle")]
    [PatternSourceCode]
    public class RectanglePaint:BasePaint
    {
        public RectanglePaint(Graphics graphics)
            : base(graphics)
        {
        }
        protected override void DrawImage(PointF p)
        {
            RectangleF rect = new RectangleF(p,new Size(250,250));
            _graphics.FillRectangle(_brush, rect);
        }
    }
}
