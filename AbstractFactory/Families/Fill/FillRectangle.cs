
using System.Drawing;
using AbstractFactory.Families.Base;
using Common;

namespace AbstractFactory.Families.Fill
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
