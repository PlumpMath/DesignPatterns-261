using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace TemplateMethod.Methods
{
    public abstract class BasePaint
    {
        protected Graphics _graphics;
        protected readonly Font _font;
        protected readonly Brush _brush;
        public BasePaint(Graphics graphics)
        {
            _graphics = graphics;
            _font = new Font("Arial",12);
            _brush = new SolidBrush(Color.Red);
        }
        public void Paint()
        {
            PointF point = new PointF(100, 20);
            DrawCaption(point);
            point.Y += 50;
            DrawImage(point);
            point.Y += 400;
            DrawFooter(point);
        }
        protected void DrawCaption(PointF p)
        {
            _graphics.DrawString("Draw begin",_font,_brush,p);
        }

        protected abstract void DrawImage(PointF p);
        protected void DrawFooter(PointF p)
        {
            _graphics.DrawString("Draw end", _font, _brush, p);
        }
    }
}
