using System.Drawing;
using System.ComponentModel;
using Observer.Observers.Base;
using Observer.Subjects;

namespace Observer.Observers
{
    [Description("Rect")]
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
