using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace Starter
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            var path = Assembly.GetEntryAssembly().Location;
            foreach (var file in Directory.GetFiles(path, "*.dll|*.exe"))
            {
                Assembly.LoadFile(file);
                //Assembly.e
            }
        }
    }
}
