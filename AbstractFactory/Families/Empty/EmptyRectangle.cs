
using System.Drawing;
using AbstractFactory.Families.Base;

namespace AbstractFactory.Families.Empty
{
    public  class EmptyRectangle : BaseRectangle
    {
        public override void Draw()
        {
            Graphics.DrawRectangle(Pens.Red, Rect);
        }
    }
}
