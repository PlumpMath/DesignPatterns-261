
using System.Drawing;
using DP.AbstractFactory.Families.Base;
using DP.Common;
using DP.Common.Attributes;

namespace DP.AbstractFactory.Families.Fill
{
    [PatternSourceCode]
    public class FillEllipse : BaseEllipse
    {
        public override void Draw()
        {
            Graphics.FillEllipse(Brushes.Green, Rect);
        }
    }
}
