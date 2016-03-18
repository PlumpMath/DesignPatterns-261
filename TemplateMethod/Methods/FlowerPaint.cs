using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.ComponentModel;

namespace TemplateMethod.Methods
{
    [Description("Flower")]
    public class FlowerPaint:BasePaint
    {
        public FlowerPaint(Graphics graphics)
            : base(graphics)
        {
        }
        protected override void DrawImage(PointF p)
        {
            var bmp = new Bitmap(TemplateMethod.Properties.Resources._4_1);
            _graphics.DrawImage(bmp, p);
        }
    }
}
