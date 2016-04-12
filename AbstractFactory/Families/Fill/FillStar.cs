using System.Drawing;
using DP.AbstractFactory.Families.Base;
using DP.Common;
using DP.Common.Attributes;

namespace DP.AbstractFactory.Families.Fill
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
