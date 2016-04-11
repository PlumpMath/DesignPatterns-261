using ICSharpCode.ILSpy;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DP.Common;
using ICSharpCode.ILSpy.VB;

namespace Starter
{
    public partial class PatternForm : Form
    {
        private readonly PatternDescription _patternDesc;
        private IEnumerable<TypeSource> _typeSourceList;
        public PatternForm()
        {
            InitializeComponent();
        }

        public PatternForm(PatternDescription patternDesc)
            :this()
        {
            _patternDesc = patternDesc;
        }

        private void PatternForm_Load(object sender, EventArgs e)
        {
            Text = _patternDesc.DisplayName;
            _typeSourceList = TypeSource.GetTypesSourceCode(_patternDesc.PatternType);
            cmbFileName.DataSource = _typeSourceList.OrderBy(f => f.TypeDef.Name).ToList(); //.Select(t => t.TypeDef.Name).ToList();
            //cmbLanguage.DataSource = _typeSourceList.Select(t => t.TypeDef.Name);

            var pattenr = Activator.CreateInstance(_patternDesc.PatternType) as IPattern;
            var userControl = pattenr.GetView;
            userControl.Dock = DockStyle.Fill;
            tabPageUI.Controls.Add(userControl);
            Size = new Size(userControl.Size.Width,userControl.Size.Height+70);
        }

        private void cmbFileName_SelectedIndexChanged(object sender, EventArgs e)
        {
            TypeSource typeSource = cmbFileName.SelectedItem as TypeSource;
            cmbLanguage.DataSource = typeSource.SourceCode.Keys.ToList();
        }

        private void cmbLanguage_SelectedIndexChanged(object sender, EventArgs e)
        {
            TypeSource typeSource = cmbFileName.SelectedItem as TypeSource;
            Language language = cmbLanguage.SelectedItem as Language;
            fastColoredTextBox1.Language = GetTextLanguageType(language);
            fastColoredTextBox1.Text = typeSource.SourceCode[language];
        }

        private FastColoredTextBoxNS.Language GetTextLanguageType(Language language)
        {
            if(language is CSharpLanguage)
                return FastColoredTextBoxNS.Language.CSharp;
            if (language is VBLanguage)
                return FastColoredTextBoxNS.Language.VB;
            return FastColoredTextBoxNS.Language.Custom;
        }
    }
}
