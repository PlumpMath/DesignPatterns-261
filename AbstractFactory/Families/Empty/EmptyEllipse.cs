
using System.Drawing;
using AbstractFactory.Families.Base;
using Common;

namespace AbstractFactory.Families.Empty
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
