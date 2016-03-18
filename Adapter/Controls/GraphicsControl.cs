using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;
using Adapter.Interfaces;

namespace Adapter.Controls
{
    public partial class GraphicsControl : UserControl, IPictureControl
    {
        private Image _image;
        public GraphicsControl()
        {
            InitializeComponent();
        }

        public new void Load(string uri)
        {
            _image =  Image.FromFile(uri);
            Invalidate();
        }

        public Image Image
        {
            get { return _image; }
            set { _image = value; }
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            if(_image!=null)
                e.Graphics.DrawImage(_image,0,0);
        }
    }
}
