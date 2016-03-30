using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using Common;

namespace Starter
{
    public partial class Wizard97Pattern : Form
    {
        private readonly PatternLoader _patternLoader = new PatternLoader();
        private Type _currentPatternType = null;
        public Wizard97Pattern()
        {
            InitializeComponent();
        }

        private void wizardPageContainer1_Finished(object sender, EventArgs e)
        {
            Close();
        }


        private void wizardPage2_Initialize(object sender, AeroWizard.WizardPageInitEventArgs e)
        {
            var pattern = Activator.CreateInstance(_currentPatternType) as IPattern;
            var sourceCode = _patternLoader.GetSourceCode(_currentPatternType);
            //wizardPage2.Controls.Add(pattern.GetView);
        }
        private void tabControlPattern_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbCode.Enabled = tabControlPattern.SelectedTab == tabPageSourceCode;
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            wizardPageContainer1.PreviousPage();
        }
    }
}
