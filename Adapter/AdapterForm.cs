using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using DP.Adapter.Interfaces;

namespace DP.Adapter
{
    public partial class AdapterForm : UserControl
    {
        private readonly List<IPictureControl> _pictureControlList = new List<IPictureControl>();
        private readonly List<IPictureControlExt> _pictureControlExtList = new List<IPictureControlExt>();
        public AdapterForm()
        {
            InitializeComponent();
        }

        private void AdapterForm_Load(object sender, EventArgs e)
        {
            Assembly assembly = Assembly.GetExecutingAssembly();
            var typesCommon = assembly.GetTypes().Where(t => t.GetInterface("IPictureControl") != null && t.GetInterface("IPictureControlExt") == null && !t.IsInterface);
            var typesExt = assembly.GetTypes().Where(t => t.GetInterface("IPictureControlExt") != null && !t.IsInterface);

            _pictureControlList.AddRange(CreateControls<IPictureControl>(panel1, typesCommon));
            _pictureControlExtList.AddRange(CreateControls<IPictureControlExt>(panel2, typesExt));
        }

        private IList<T> CreateControls<T>(Panel panel, IEnumerable<Type> types)
        {
            var list = new List<T>();
            int x3 = 0;
            int x3a = 500;
            foreach (var type in types)
            {
                T value = (T)Activator.CreateInstance(type);
                list.Add(value);
                var control = value as Control;
                control.BackColor = Color.Gray;
                Label lb = new Label();
                lb.Text = type.Name;
                lb.Location = new Point(x3, 0);
                lb.Size = new Size(x3a, 20);
                panel2.Controls.Add(lb);
                control.Location = new Point(x3, 0);
                control.Size = new Size(x3a - 50, x3a - 50);
                panel.Controls.Add(control);
                x3 += x3a;
            }
            return list;
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
                    btnSaveExt.Enabled = true;
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
