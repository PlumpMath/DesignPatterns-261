using System.Drawing;
using AbstractFactory.Families.Base;
using Common;

namespace AbstractFactory.Families.Fill
{
    [PatternSourceCode]
    public class FillStar : BaseStar
    {
        public override void Draw()
        {
            Graphics.FillPolygon(Brushes.Yellow, Calculate5StarPoints(Rect.Location, Rect.Width, Rect.Width / 2));
        }
    }
}
