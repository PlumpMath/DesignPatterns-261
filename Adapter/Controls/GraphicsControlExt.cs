using System.Drawing;
using Adapter.Interfaces;

namespace Adapter.Controls
{
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
