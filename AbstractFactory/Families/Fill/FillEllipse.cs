
using System.Drawing;
using AbstractFactory.Families.Base;

namespace AbstractFactory.Families.Fill
{
    public class FillEllipse : BaseEllipse
    {
        public override void Draw()
        {
            Graphics.FillEllipse(Brushes.Green, Rect);
        }
    }
}
