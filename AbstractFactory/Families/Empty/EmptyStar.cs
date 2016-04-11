using System.Drawing;
using AbstractFactory.Families.Base;
using DP.Common;

namespace AbstractFactory.Families.Empty
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
