
using System.Drawing;
using DP.AbstractFactory.Families.Base;
using DP.Common;
using DP.Common.Attributes;

namespace DP.AbstractFactory.Families.Empty
{
    [PatternSourceCode]
    public class EmptyEllipse : BaseEllipse
    {
        public override void Draw()
        {
            Graphics.DrawEllipse(Pens.Green, Rect);
        }
    }
}
