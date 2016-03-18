using System.Drawing;
using Adapter.Interfaces;

namespace Adapter.Inheritance
{
    public class PictureControlExtAdapterI : PictureControlAdapterI, IPictureControlExt
    {
        public void Save(string fileName)
        {
           Image.Save(fileName);
        }

        public void Reverse()
        {
            Image.RotateFlip(RotateFlipType.Rotate180FlipY);
            Invalidate();
        }
    }
}
