using System.Drawing;
using DP.AbstractFactory.Families.Base;
using DP.Common;
using DP.Common.Attributes;

namespace DP.AbstractFactory.Families.Empty
{
    [PatternSourceCode]
    public class EmptyStar : BaseStar
    {
        public override void Draw()
        {
            Graphics.DrawPolygon(Pens.Yellow, BaseStarElement.Calculate5StarPoints(Rect.Location, Rect.Width, Rect.Width / 2));
        }
    }
}
