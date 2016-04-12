using System.Drawing;
using System.ComponentModel;
using DP.Observer.Observers.Base;
using DP.Observer.Subjects;
using DP.Common.Attributes;

namespace DP.Observer.Observers
{
    [Description("Rect")]
    [PatternSourceCode]
    public class RectangleElement : BaseObserver
    {
        public RectangleElement(Graphics graphics, Rectangle rect, ISubject subject)
            : base(graphics, rect, subject)
        {
        }

        public override void Update()
        {
            Brush brush = new SolidBrush(_subject.ElementColor);
            _graphics.FillRectangle(brush, _rect);
        }
    }
}
