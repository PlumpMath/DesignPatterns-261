using System;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using Observer.Observers.Base;
using Observer.Subjects;

namespace Observer
{
    public partial class ObserverForm : Form
    {
        private int sideLength = 50;
        private Graphics graphics;
        //private Point location;
        private ISubject _subject;
        public ObserverForm()
        {
            InitializeComponent();
        }

        private void radioButton_CheckedChanged(object sender, System.EventArgs e)
        {
            RadioButton rb = sender as RadioButton;
            _subject.SetElementColor(getColor(rb.Text));
        }

        private Color getColor(string name)
        {
            switch (name)
            {
                case  "Red":
                    return Color.Red;
                case "Green":
                    return Color.Green;
                case "Blue":
                    return Color.Blue;
            }
            throw new Exception("Color not find");
        }

        private void ObserverForm_Load(object sender, System.EventArgs e)
        {
            _subject = new Subject(); 
            _subject.SetElementColor(Color.Red);
            graphics = panel2.CreateGraphics();
            int x = 100;
            Assembly assembly = Assembly.GetExecutingAssembly();
            var types = assembly.GetTypes().Where(t => t.BaseType != null && t.BaseType.Equals(typeof(BaseObserver)) && !t.IsAbstract);
            int y = 20;
            foreach (var type in types)
            {
                var descrAttr = Attribute.GetCustomAttributes(type, typeof(DescriptionAttribute)).FirstOrDefault();
                string text = (descrAttr as DescriptionAttribute).Description;
                CheckBox btn = new CheckBox();
                btn.Text = text;
                btn.Location = new Point(20, y);
                btn.Size = new Size(100, 20);
                var location = new Point(x, panel2.Height / 2);
                var rect = new Rectangle(location, new Size(sideLength, sideLength));
                BaseObserver graphicElement = Activator.CreateInstance(type, graphics, rect,_subject) as BaseObserver;
                btn.Tag = graphicElement;
                btn.CheckedChanged -= btn_CheckedChanged;
                btn.CheckedChanged += btn_CheckedChanged;
                groupBox1.Controls.Add(btn);
                y += 20;
                x+=100;
            }
        }

        void btn_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox box = sender as CheckBox;
            BaseObserver graphicElement = box.Tag as BaseObserver;
            if (box.Checked)
                _subject.RegistrerObserver(graphicElement);
            else
                _subject.UnRegistrerObserver(graphicElement);
        }

        private void btnDraw_Click(object sender, EventArgs e)
        {
            graphics.Clear(Color.LightGray);
            _subject.NotifyObservers();
        }
    }
}
