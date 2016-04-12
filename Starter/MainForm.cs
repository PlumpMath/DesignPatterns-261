using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Starter
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }        

        private void CreatePatternButton(PatternDescription patternDesc, int i)
        {
            Button btnPattern = new Button();
            btnPattern.Image = patternDesc.PatternInstance.Icon.ToBitmap();
            btnPattern.TextAlign = ContentAlignment.BottomCenter;
            btnPattern.Text = patternDesc.DisplayName;
            //btnPattern.Font = new Font(FontFamily.g, );
            btnPattern.Tag = patternDesc;
            btnPattern.Size = new Size(100, 100);
            btnPattern.Location = new Point(20 + 110 * (i%5), 20 + 100 * (i / 5));
            btnPattern.Click -= BtnPattern_Click;
            btnPattern.Click += BtnPattern_Click;
            CreatePatternToolTip(patternDesc, btnPattern);
            Controls.Add(btnPattern);
        }

        private void CreatePatternToolTip(PatternDescription patternDesc, Button btnPattern)
        {
            if (string.IsNullOrEmpty(patternDesc.Description)) return;

            ToolTip toolTipPattern = new ToolTip();
            toolTipPattern.ToolTipIcon = ToolTipIcon.Info;
            toolTipPattern.ToolTipTitle = btnPattern.Text;
            toolTipPattern.SetToolTip(btnPattern, GetToolTipWrapText(patternDesc.Description));
        }

        static string GetToolTipWrapText(string text)
        {
            StringBuilder sb = new StringBuilder();
            int curLength = 0, N = 50;
            var parts = text.Split();
            foreach (var part in parts)
            {
                if (curLength + part.Length > N)
                {
                    sb.AppendLine($" {part}");
                    curLength = 0;
                }
                else
                {
                    if (sb.Length > 0)
                        sb.Append(' ');
                    sb.Append(part);
                    curLength += part.Length;
                }
            }
            return sb.ToString();
        }

        private void BtnPattern_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            var patternType = btn.Tag as PatternDescription;
            PatternForm patternForm = new PatternForm(patternType);
            patternForm.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            var patternTypes = PatternDescription.GetPatternDescription();
            int i = 0;
            foreach (var type in patternTypes)
            {
                CreatePatternButton(type, i);
                i++;
            }
        }
    }
}
