
using System.Drawing;
using DP.AbstractFactory.Families.Base;
using DP.Common;
using DP.Common.Attributes;

namespace DP.AbstractFactory.Families.Empty
{
    [PatternSourceCode]
    public  class EmptyRectangle : BaseRectangle
    {
        public override void Draw()
        {
            Graphics.DrawRectangle(Pens.Red, Rect);
        }
    }
}
