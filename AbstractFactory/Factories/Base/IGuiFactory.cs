
using AbstractFactory.Families.Base;
using DP.Common;

namespace AbstractFactory.Factories.Base
{
    [PatternSourceCode]
    public interface IGuiFactory
    {
        BaseEllipse CreateEllipse();
        BaseRectangle CreateRectangle();
        BaseStar CreateStar();
    }
}
