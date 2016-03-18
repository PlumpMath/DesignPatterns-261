
using System.Drawing;
using AbstractFactory.Families.Base;

namespace AbstractFactory.Families.Fill
{
    public class FillRectangle : BaseRectangle
    {
        public override void Draw()
        {
            Graphics.FillRectangle(Brushes.Red, Rect);
        }
    }
}
