
using AbstractFactory.Families.Base;

namespace AbstractFactory.Factories.Base
{
    public interface IGuiFactory
    {
        BaseEllipse CreateEllipse();
        BaseRectangle CreateRectangle();
        BaseStar CreateStar();
    }
}
