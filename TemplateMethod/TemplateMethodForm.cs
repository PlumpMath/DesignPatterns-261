using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Reflection;
using DP.TemplateMethod.Methods;

namespace DP.TemplateMethod
{
    public partial class TemplateMethodForm : UserControl
    {
        private Graphics graphics;
        private Point location;
        private Type currentPaintType;
        public TemplateMethodForm()
        {
            InitializeComponent();
        }

        private void TemplateMethodForm_Load(object sender, EventArgs e)
        {
            Init();
        }

        private void Init()
        {
            graphics = panel2.CreateGraphics();
            graphics.Clear(Color.LightGray);
            location = new Point(panel1.Width / 2, panel1.Height / 2);
            Assembly assembly = Assembly.GetExecutingAssembly();
            var paintTypes = assembly.GetTypes().Where(t => t.BaseType != null && t.IsSubclassOf(typeof(BasePaint)) && !t.IsAbstract);
            InitGroupBox(groupBox1, paintTypes);
        }
        private void InitGroupBox(GroupBox groupBox, IEnumerable<Type> types)
        {
            int y = 20;
            foreach (var type in types)
            {
                var descrAttr = Attribute.GetCustomAttributes(type, typeof(DescriptionAttribute)).FirstOrDefault();
                string text = (descrAttr as DescriptionAttribute).Description;
                RadioButton rb = new RadioButton();
                rb.Text = text;
                rb.Tag = type;
                rb.Size = new Size(100, 25);
                rb.Location = new Point(20, y);
                rb.CheckedChanged -= rb_CheckedChanged;
                rb.CheckedChanged += rb_CheckedChanged;
                groupBox.Controls.Add(rb);
                rb.Checked = true;
                y += 20;
            }
        }
        void rb_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;
            if (rb.Checked)
            {
               currentPaintType = rb.Tag as Type;
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            graphics.Clear(Color.LightGray);
            BasePaint paint = Activator.CreateInstance(currentPaintType,graphics) as BasePaint;
            paint.Paint();
        }
    }
}
