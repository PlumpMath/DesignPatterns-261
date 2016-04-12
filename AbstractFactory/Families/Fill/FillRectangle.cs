
using System.Drawing;
using DP.AbstractFactory.Families.Base;
using DP.Common;
using DP.Common.Attributes;

namespace DP.AbstractFactory.Families.Fill
{
    [PatternSourceCode]
    public class FillRectangle : BaseRectangle
    {
        public override void Draw()
        {
            Graphics.FillRectangle(Brushes.Red, Rect);
        }
    }
}
