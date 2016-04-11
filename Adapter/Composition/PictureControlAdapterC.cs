using System;
using System.Drawing;
using System.Windows.Forms;
using Adapter.Interfaces;
using DP.Common;

namespace Adapter.Composition
{
    [PatternSourceCode]
    public class PictureControlAdapterC : Control, IPictureControl
    {
        private readonly   Lazy<PictureBox> _pictureBox = new Lazy<PictureBox>();
        public PictureControlAdapterC()
        {
            _pictureBox.Value.SizeMode = PictureBoxSizeMode.StretchImage;
            Controls.Add(_pictureBox.Value);
        }
        public void Load(string uri)
        {
            _pictureBox.Value.Load(uri);
            _pictureBox.Value.Size = Size;
        }

        public Image Image
        {
            get { return _pictureBox.Value.Image; }
            set { _pictureBox.Value.Image = value; }
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            _pictureBox.Value.Invalidate();
        }
    }
}
