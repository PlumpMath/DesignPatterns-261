
using AbstractFactory.Families.Base;
using Common;

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
