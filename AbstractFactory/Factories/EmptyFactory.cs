using System.ComponentModel;
using DP.AbstractFactory.Factories.Base;
using DP.AbstractFactory.Families.Base;
using DP.AbstractFactory.Families.Empty;
using DP.Common;
using DP.Common.Attributes;

namespace DP.AbstractFactory.Factories
{
    [Description("Empty")]
    [PatternSourceCode]
    public class EmptyFactory : IGuiFactory
    {
        public BaseEllipse CreateEllipse()
        {
            return new EmptyEllipse();
        }

        public BaseRectangle CreateRectangle()
        {
            return new EmptyRectangle();
        }

        public BaseStar CreateStar()
        {
            return new EmptyStar();
        }
    }
}
