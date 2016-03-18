using System;
using System.Collections.Generic;
using System.ComponentModel;
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
        private readonly PatternLoader _patternLoader = new PatternLoader();
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            var names = _patternLoader.GetPatternNames();
        }
    }
}
