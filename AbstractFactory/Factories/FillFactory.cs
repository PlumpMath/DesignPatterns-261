using System.ComponentModel;
using AbstractFactory.Factories.Base;
using AbstractFactory.Families.Base;
using AbstractFactory.Families.Fill;
using Common;

namespace AbstractFactory.Factories
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
