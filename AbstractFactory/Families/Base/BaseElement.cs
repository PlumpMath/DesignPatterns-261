
using System.Drawing;

namespace AbstractFactory.Families.Base
{
    public abstract class BaseElement
    {
        public abstract string Text { get; }
        public abstract void Draw();
        public Rectangle Rect { get; set; }
        public Graphics Graphics { get; set; }
    }
}
