using System;
using System.ComponentModel;
using System.Drawing;
using DP.Observer.Observers.Base;
using DP.Observer.Subjects;
using DP.Common;
using DP.Common.Attributes;

namespace DP.Observer.Observers
{
    [Description("Star")]
    [PatternSourceCode]
    public class StarElement : BaseObserver
    {
        public StarElement(Graphics graphics, Rectangle rect, ISubject subject)
            : base(graphics, rect, subject)
        {
        }

        public override void Update()
        {
            Brush brush = new SolidBrush(_subject.ElementColor);
            _graphics.FillPolygon(brush, BaseStarElement.Calculate5StarPoints(_rect.Location, _rect.Width, _rect.Width / 2));
        }      
    }
}
