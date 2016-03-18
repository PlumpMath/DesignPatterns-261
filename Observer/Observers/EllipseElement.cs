using System.Drawing;
using System.ComponentModel;
using Observer.Observers.Base;
using Observer.Subjects;

namespace Observer.Observers
{
    [Description("Ellipse")]
    public class EllipseElement : BaseObserver
    {
        public EllipseElement(Graphics graphics, Rectangle rect, ISubject subject)
            : base(graphics, rect,subject)
        {
        }

        public override void Update()
        {
            Brush brush = new SolidBrush(_subject.ElementColor);
            _graphics.FillEllipse(brush, _rect);
        }
    }
}
