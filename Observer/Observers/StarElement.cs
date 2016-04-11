using System;
using System.ComponentModel;
using System.Drawing;
using Observer.Observers.Base;
using Observer.Subjects;
using DP.Common;

namespace Observer.Observers
{
    [Description("Star")]
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
