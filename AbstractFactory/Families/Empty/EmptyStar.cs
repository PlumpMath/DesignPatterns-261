using System.Drawing;
using AbstractFactory.Families.Base;
using Common;

namespace AbstractFactory.Families.Empty
{
    [PatternSourceCode]
    public class EmptyStar : BaseStar
    {
        public override void Draw()
        {
            Graphics.DrawPolygon(Pens.Yellow, Calculate5StarPoints(Rect.Location, Rect.Width, Rect.Width / 2));
        }
    }
}
