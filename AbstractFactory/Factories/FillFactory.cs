using System.ComponentModel;
using DP.AbstractFactory.Factories.Base;
using DP.AbstractFactory.Families.Base;
using DP.AbstractFactory.Families.Fill;
using DP.Common;
using DP.Common.Attributes;

namespace DP.AbstractFactory.Factories
{
    [Description("Fill")]
    [PatternSourceCode]
    public class FillFactory : IGuiFactory
    {
        public BaseEllipse CreateEllipse()
        {
            return new FillEllipse();
        }

        public BaseRectangle CreateRectangle()
        {
            return new FillRectangle();
        }

        public BaseStar CreateStar()
        {
            return new FillStar();
        }
    }
}
