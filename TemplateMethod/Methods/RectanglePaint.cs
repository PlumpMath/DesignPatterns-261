using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.ComponentModel;

namespace TemplateMethod.Methods
{
    [Description("Rectangle")]
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
