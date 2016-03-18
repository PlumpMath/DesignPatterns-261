using System.Windows.Forms;
using Adapter.Interfaces;

namespace Adapter.Inheritance
{
    public class PictureControlAdapterI :PictureBox, IPictureControl
    {
        public PictureControlAdapterI()
        {
            SizeMode = PictureBoxSizeMode.StretchImage;
        }
    }
}
