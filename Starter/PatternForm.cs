using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Starter
{
    public partial class PatternForm : Form
    {
        private readonly Type _patternType;
        public PatternForm()
        {
            InitializeComponent();
        }

        public PatternForm(Type patternType)
            :this()
        {
            _patternType = patternType;
        }

        private void PatternForm_Load(object sender, EventArgs e)
        {

        }
    }
}
