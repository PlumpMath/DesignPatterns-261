using System.Windows.Forms;
using DP.Adapter.Interfaces;
using DP.Common.Attributes;

namespace DP.Adapter.Inheritance
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
