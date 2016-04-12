using System.Drawing;
using System.ComponentModel;
using DP.Observer.Observers.Base;
using DP.Observer.Subjects;
using DP.Common.Attributes;

namespace DP.Observer.Observers
{
    [Description("Ellipse")]
    [PatternSourceCode]
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
