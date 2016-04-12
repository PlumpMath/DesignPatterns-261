
using DP.AbstractFactory.Families.Base;
using DP.Common;
using DP.Common.Attributes;

namespace DP.AbstractFactory.Factories.Base
{
    [PatternSourceCode]
    public interface IGuiFactory
    {
        BaseEllipse CreateEllipse();
        BaseRectangle CreateRectangle();
        BaseStar CreateStar();
    }
}
