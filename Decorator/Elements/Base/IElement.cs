using System.Drawing;
using DP.Common.Attributes;

namespace DP.Decorator.Elements.Base
{
    [PatternSourceCode]
    public interface IElement 
    {
        void Draw(Graphics graphics, Point location);
    }
}
