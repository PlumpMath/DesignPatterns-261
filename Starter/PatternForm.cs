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
            Text = _patternDesc.DisplayName;
            _typeSourceList = TypeSource.GetTypesSourceCode(patternDesc.PatternType);
        }

        private void PatternForm_Load(object sender, EventArgs e)
        {
            cmbFileName.DataSource = _typeSourceList.ToList();//.Select(t => t.TypeDef.Name).ToList();
            //cmbLanguage.DataSource = _typeSourceList.Select(t => t.TypeDef.Name);
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
            fastColoredTextBox1.Text = typeSource.SourceCode[language];
        }
    }
}
