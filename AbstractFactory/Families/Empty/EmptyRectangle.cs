
using System.Drawing;
using AbstractFactory.Families.Base;
using Common;

namespace AbstractFactory.Families.Empty
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
