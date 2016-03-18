using System.ComponentModel;
using AbstractFactory.Factories.Base;
using AbstractFactory.Families.Base;
using AbstractFactory.Families.Fill;

namespace AbstractFactory.Factories
{
    [Description("Fill")]
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
