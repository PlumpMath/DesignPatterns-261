using System.Drawing;
using Adapter.Interfaces;
using DP.Common;

namespace Adapter.Controls
{
    [PatternSourceCode]
    public partial class GraphicsControlExt : GraphicsControl, IPictureControlExt
    {
        public GraphicsControlExt()
        {
            InitializeComponent();
        }

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
