using System.Windows.Forms;
using Adapter.Interfaces;
using DP.Common;

namespace Adapter.Inheritance
{
    [PatternSourceCode]
    public class PictureControlAdapterI :PictureBox, IPictureControl
    {
        public PictureControlAdapterI()
        {
            SizeMode = PictureBoxSizeMode.StretchImage;
        }
    }
}
