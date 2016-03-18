using System.Drawing;
using AbstractFactory.Families.Base;

namespace AbstractFactory.Families.Fill
{
    public class FillStar : BaseStar
    {
        public override void Draw()
        {
            Graphics.FillPolygon(Brushes.Yellow, Calculate5StarPoints(Rect.Location, Rect.Width, Rect.Width / 2));
        }
    }
}
