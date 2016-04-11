using System.Drawing;
using AbstractFactory.Families.Base;
using DP.Common;

namespace AbstractFactory.Families.Fill
{
    [PatternSourceCode]
    public class FillStar : BaseStar
    {
        public override void Draw()
        {
            Graphics.FillPolygon(Brushes.Yellow, BaseStarElement.Calculate5StarPoints(Rect.Location, Rect.Width, Rect.Width / 2));
        }
    }
}
