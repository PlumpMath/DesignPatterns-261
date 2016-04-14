using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using DP.AbstractFactory.Factories.Base;
using DP.AbstractFactory.Families.Base;

namespace DP.AbstractFactory
{
    public partial class AbstractFactoryForm : UserControl
    {
        private Type _currentFactoryType;
        private List<BaseElement> _elements;
        public AbstractFactoryForm()
        {
            InitializeComponent();
        }

        private void AbstractFactoryForm_Load(object sender, EventArgs e)
        {
            Assembly assembly = Assembly.GetExecutingAssembly();
            var types = assembly.GetTypes().Where(t => t.GetInterface("IGuiFactory")!=null);
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
                groupBox1.Controls.Add(rb);
                rb.Checked = true;
                y += 20;
            }
        }
        void rb_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;
            if (rb.Checked)
            {
                _currentFactoryType = rb.Tag as Type;
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            CreateAndDraw();
        }

        private void CreateAndDraw()
        {
            var factory = Activator.CreateInstance(_currentFactoryType) as IGuiFactory;
            var ellipse = factory.CreateEllipse();
            var rectElement = factory.CreateRectangle();
            var star = factory.CreateStar();
            _elements = new List<BaseElement>() { ellipse, rectElement, star };
            DrawElements();

        }
        private void DrawElements()
        {
            var graphics = panel2.CreateGraphics();
            graphics.Clear(Color.LightGray);
            if(_elements==null) return;
            var h = ClientSize.Height/((_elements.Count+1));
            var w  = ClientSize.Width /( (_elements.Count + 1));
            var y = w/2;
            var x = h/2;
            foreach (var baseElement in _elements)
            {
                Rectangle rect = new Rectangle(x, y, h, w);
                baseElement.Graphics = graphics;
                baseElement.Rect = rect;
                baseElement.Draw();
                x += w;
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            DrawElements();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            _elements = null;
            DrawElements();
        }
    }
}
