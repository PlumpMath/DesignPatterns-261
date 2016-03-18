using System.Drawing;
using Adapter.Interfaces;

namespace Adapter.Composition
{
    public class PictureControlExtAdapterC : PictureControlAdapterC, IPictureControlExt
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
