
using System.Drawing;
using AbstractFactory.Families.Base;
using Common;

namespace AbstractFactory.Families.Fill
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
