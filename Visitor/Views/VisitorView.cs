using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Visitor.Elements;
using Visitor.Visitors;

namespace Visitor.Views
{
    public partial class VisitorView : UserControl
    {
        public VisitorView()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var rb = gbElements.Controls.OfType<RadioButton>()
                           .FirstOrDefault(n => n.Checked);
            //var element = Activator.CreateInstance(rb.Tag as Type);
            listBoxElements.Items.Add(rb.Tag);
        }

        private void btnDraw_Click(object sender, EventArgs e)
        {
            int x = 50, y = 100;
            var graphics = splitContainer1.Panel2.CreateGraphics();
            var oprb = gbOperations.Controls.OfType<RadioButton>()
                            .FirstOrDefault(n => n.Checked);
            BaseVisitor visitor = Activator.CreateInstance(oprb.Tag as Type,graphics) as BaseVisitor;
            foreach (Type type in listBoxElements.Items)
            {
                Rectangle rect = new Rectangle(x,y,100,100);
                var element = Activator.CreateInstance(type, rect);
                if(element is RectangleElement)
                    visitor.Visit(element as RectangleElement);
                else if (element is EllipseElement)
                    visitor.Visit(element as EllipseElement);
                else if (element is StarElement)
                    visitor.Visit(element as StarElement);
                x += 150;
            }
        }

        private void VisitorView_Load(object sender, EventArgs e)
        {
            var assembly =  Assembly.GetExecutingAssembly();
            LoadTypes(assembly, typeof(BaseElement), gbElements);
            LoadTypes(assembly, typeof(BaseVisitor), gbOperations);
        }

        private void LoadTypes(Assembly assembly, Type baseType, GroupBox gb)
        {
            var elementTypes = assembly.GetTypes().Where(t => t.BaseType.Equals(baseType));
            int i = 10;
            foreach (var elementType in elementTypes)
            {
                AddElement(gb,elementType, i);
                i += 25;
            }
            gb.Controls.OfType<RadioButton>().FirstOrDefault().Checked = true;

        }

        private void AddElement(GroupBox gb,Type elementType, int i)
        {
            RadioButton rb = new RadioButton();
            rb.Tag = elementType;
            rb.Text = elementType.Name;
            rb.Location = new Point(10,i);
            gb.Controls.Add(rb);
        }

    }
}
