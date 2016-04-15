using System;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using DP.Decorator.Elements;
using DP.Decorator.Elements.Base;

namespace DP.Decorator
{
    public partial class DecoratorForm : UserControl
    {
        private int sideLength = 50;
        private IElement _currentElement;
        private Point location;
        public DecoratorForm()
        {
            InitializeComponent();
        }

        private void Init()
        {
            location = new Point(panel1.Width / 2, panel1.Height / 2);
            _currentElement = new Element();
            Assembly assembly =  Assembly.GetExecutingAssembly();
            var types = assembly.GetTypes().Where(t => t.BaseType!=null && t.BaseType.Equals(typeof(GraphicElement)));
            int x=10;
            foreach (var type in types)
            {
                var descrAttr = Attribute.GetCustomAttributes(type, typeof(DescriptionAttribute)).FirstOrDefault();
                string text = "Add" + (descrAttr as DescriptionAttribute).Description;
                Button btn = AddButton(text,x);
                btn.Tag = type;
                btn.Click -= btnGeneric_Click;
                btn.Click += btnGeneric_Click;
                x += 120;
            }
            var clearBtn =  AddButton("Clear",x);
            clearBtn.Click += delegate(object sender, EventArgs e)
            {
                _currentElement = new Element();
                sideLength = 50;
                panel1.CreateGraphics().Clear(Color.LightGray);
            };
        }

        private Button AddButton(string text, int x)
        {
            Button btn = new Button();
            btn.Text = text;
            btn.Size = new Size(100, 25);
            btn.Location = new Point(x, 20);
            panel2.Controls.Add(btn);
            return btn;
        }

        private void btnGeneric_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            Type type = btn.Tag as Type;
            var rect = new Rectangle(location, new Size(sideLength, sideLength));
            GraphicElement graphicElement = Activator.CreateInstance(type, _currentElement, sideLength) as GraphicElement;
            sideLength += 50;
            graphicElement.Draw(panel1.CreateGraphics(),new Point(panel1.ClientSize.Width/2,panel1.ClientSize.Height/2));
            _currentElement = graphicElement;
        }       

        private void Form1_Load(object sender, EventArgs e)
        {
            Init();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            if (_currentElement == null)
            {
                base.OnPaint(e);
                return;
            }
            _currentElement.Draw(panel1.CreateGraphics(), new Point(panel1.ClientSize.Width / 2, panel1.ClientSize.Height / 2));
        }
    }
}
