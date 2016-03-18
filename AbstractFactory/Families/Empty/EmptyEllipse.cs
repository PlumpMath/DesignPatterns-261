
using System.Drawing;
using AbstractFactory.Families.Base;

namespace AbstractFactory.Families.Empty
{
    public class EmptyEllipse : BaseEllipse
    {
        public override void Draw()
        {
            Graphics.DrawEllipse(Pens.Green, Rect);
        }
    }
}
