using System.Drawing;
using AbstractFactory.Families.Base;

namespace AbstractFactory.Families.Empty
{
    public class EmptyStar : BaseStar
    {
        public override void Draw()
        {
            Graphics.DrawPolygon(Pens.Yellow, Calculate5StarPoints(Rect.Location, Rect.Width, Rect.Width / 2));
        }
    }
}
