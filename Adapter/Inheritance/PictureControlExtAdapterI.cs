using System.Drawing;
using Adapter.Interfaces;
using DP.Common;

namespace Adapter.Inheritance
{
    [PatternSourceCode]
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
