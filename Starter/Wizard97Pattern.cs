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

        private void wizardPageContainer1_SelectedPageChanged(object sender, EventArgs e)
        {
        }

        private void wizardPage1_Initialize(object sender, AeroWizard.WizardPageInitEventArgs e)
        {
            var patternTypes =  _patternLoader.GetPatternTypes();
            int i = 0;
            foreach (var type in patternTypes)
            {
                CreatePatternButton(type,i);
                i++;
            }
        }

        private void CreatePatternButton(Type type, int i)
        {
            Button btnPattern = new Button();
            var dnAttr = type.GetCustomAttribute(typeof(DisplayNameAttribute)) as DisplayNameAttribute;
            btnPattern.Text = dnAttr != null ? dnAttr.DisplayName : type.Name;
            btnPattern.Tag = type;
            btnPattern.Size = new Size(100, 100);
            btnPattern.Location = new Point(20 + 50 * i, 20 + 50 * (i / 3));
            btnPattern.Click -= BtnPattern_Click;
            btnPattern.Click += BtnPattern_Click;
            btnPattern.Tag = type;
            CreatePatternToolTip(type,btnPattern);
            wizardPage1.Controls.Add(btnPattern);
        }

        private void CreatePatternToolTip(Type type, Button btnPattern)
        {
            var descrAttr = type.GetCustomAttribute(typeof (DescriptionAttribute)) as DescriptionAttribute;
            if (descrAttr != null)
            {
                ToolTip toolTipPattern = new ToolTip();
                toolTipPattern.ToolTipIcon = ToolTipIcon.Info;
                toolTipPattern.ToolTipTitle = btnPattern.Text;
                toolTipPattern.SetToolTip(btnPattern, GetToolTip(descrAttr.Description));
            }
        }

        static string GetToolTip(string text)
        {
            StringBuilder sb = new StringBuilder();
            int i=0,lasti = 0;
            var parts = text.Split();
            //parts.TakeWhile(count=>)
            while (i<text.Length && i>-1)
            {
                i = text.IndexOf(' ',i+1);
                if (i - lasti > 50)
                {
                    sb.AppendLine(text.Substring(lasti, i));
                    lasti = i;
                }
            }
            return sb.ToString();
        }

        private void BtnPattern_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            _currentPatternType =  btn.Tag as Type;
            wizardPageContainer1.NextPage();
            //pattern.GetView
        }

        private void wizardPage2_Initialize(object sender, AeroWizard.WizardPageInitEventArgs e)
        {
            var pattern = Activator.CreateInstance(_currentPatternType) as IPattern;
            wizardPage2.Controls.Add(pattern.GetView);

        }
    }
}
