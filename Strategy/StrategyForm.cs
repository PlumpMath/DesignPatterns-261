using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using DP.Strategy.Behaviors.Base;
using DP.Strategy.Elements.Base;

namespace DP.Strategy
{
    public partial class StrategyForm : UserControl
    {
        private int sideLength = 100;
        private Graphics graphics;
        private Point location;
        private Type currentElementType;
        private Type currentBehaviorType;
        private BaseBehavior currentBehavior;
        public StrategyForm()
        {
            InitializeComponent();
        }

        private void Init()
        {
            graphics = panel1.CreateGraphics();
            graphics.Clear(Color.LightGray);
            location = new Point(panel1.Width / 2, panel1.Height / 2);
            Assembly assembly = Assembly.GetExecutingAssembly();
            var elementTypes = assembly.GetTypes().Where(t => t.BaseType != null && t.IsSubclassOf(typeof(BaseElement)) && !t.IsAbstract);
            var behaviorTypes =
                assembly.GetTypes().Where(
                    t => t.BaseType != null && t.IsSubclassOf(typeof (BaseBehavior)) && !t.IsAbstract);
            InitGroupBox(groupBox1, elementTypes);
            InitGroupBox(groupBox2, behaviorTypes);
        }

        private  void InitGroupBox(GroupBox groupBox,IEnumerable<Type> types)
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
                if (rb.Parent.Name == "groupBox1")
                    currentElementType = rb.Tag as Type;
                else
                    currentBehaviorType = rb.Tag as Type;
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Init();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            graphics.Clear(Color.LightGray);
            BaseElement element = Activator.CreateInstance(currentElementType) as BaseElement;
            element.Rect = new Rectangle(location, new Size(sideLength, sideLength));
            currentBehavior = Activator.CreateInstance(currentBehaviorType, new object[] { element, graphics }) as BaseBehavior;
            currentBehavior.Start();
            btnStop.Enabled = true;
            btnStart.Enabled = false;
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            currentBehavior.Stop();
            btnStop.Enabled = false;
            btnStart.Enabled = true;
        }
    }
}
