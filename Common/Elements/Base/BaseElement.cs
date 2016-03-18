using System.Drawing;

namespace Common.Elements.Base
{
    public abstract class BaseElement
    {
        public abstract string MethodName { get; }
        public abstract object GetGeometryStruct { get; }

        public IExtElement ExtElement { get; set; }

        public Rectangle Rect { get; set; }
      
    }
}
