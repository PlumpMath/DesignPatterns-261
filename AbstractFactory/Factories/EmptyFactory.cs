using System.ComponentModel;
using AbstractFactory.Factories.Base;
using AbstractFactory.Families.Base;
using AbstractFactory.Families.Empty;

namespace AbstractFactory.Factories
{
    [Description("Empty")]
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
