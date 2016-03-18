using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Reflection;
using Adapter.Interfaces;

namespace Adapter
{
    public partial class AdapterForm : Form
    {
        private readonly List<IPictureControl> _pictureControlList = new List<IPictureControl>();
        private readonly List<IPictureControlExt> _pictureControlExtList = new List<IPictureControlExt>();
        public AdapterForm()
        {
            InitializeComponent();
        }

        private void AdapterForm_Load(object sender, EventArgs e)
        {
            CreateControls();
        }

        private void CreateControls()
        {
            Assembly assembly = Assembly.GetExecutingAssembly();
            var types = assembly.GetTypes().Where(t => t.GetInterface("IPictureControl") != null && !t.IsInterface);

            int x2 = 0;
            int x2a = splitContainer2.Panel2.Width / 3;
            int x3 = 0;
            int x3a = splitContainer3.Panel2.Width / 3;
            foreach (var type in types)
            {
                var control = Activator.CreateInstance(type) as Control;
                control.BackColor = Color.Gray;
                Label lb = new Label();
                lb.Text = type.Name;
                if (type.GetInterface("IPictureControlExt")!=null)
                {
                    _pictureControlExtList.Add(control as IPictureControlExt);
                    lb.Location = new Point(x3, 0);
                    lb.Size = new Size(x3a, 20);
                    splitContainer3.Panel2.Controls.Add(lb);
                    control.Location = new Point(x3, 0);
                    control.Size = new Size(x3a - 10, x3a - 10);
                    splitContainer3.Panel2.Controls.Add(control);
                    x3 += x3a;
                }
                else
                {
                    _pictureControlList.Add(control as IPictureControl);
                    lb.Location = new Point(x2, 0);
                    lb.Size = new Size(x2a, 20);
                    splitContainer2.Panel2.Controls.Add(lb);
                    control.Location = new Point(x2, 50);
                    control.Size = new Size(x2a-10, x2a-10);
                    splitContainer2.Panel2.Controls.Add(control);
                    x2 += x2a;
                }
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dialog = new OpenFileDialog())
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    foreach (var pictureControl in _pictureControlList)
                    {
                        pictureControl.Load(dialog.FileName);
                    }
                }
            }
        }

        private void btnLoadExt_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dialog = new OpenFileDialog())
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    foreach (var pictureControl in _pictureControlExtList)
                    {
                        pictureControl.Load(dialog.FileName);
                    }
                    btnReverse.Enabled = true;
                }
            }
        }

        private void btnSaveExt_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog file = new SaveFileDialog())
            {
                if (file.ShowDialog() == DialogResult.OK)
                {
                    foreach (var pictureControl in _pictureControlExtList)
                    {
                        pictureControl.Save(file.FileName);
                    }
                }
            }
        }

        private void btnReverse_Click(object sender, EventArgs e)
        {
            foreach (var pictureControl in _pictureControlExtList)
            {
                pictureControl.Reverse();
            }
        }
    }
}
