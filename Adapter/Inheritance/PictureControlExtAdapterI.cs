using System.Drawing;
using DP.Adapter.Interfaces;
using DP.Common.Attributes;

namespace DP.Adapter.Inheritance
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
