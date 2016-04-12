using DP.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace DP.TemplateMethod
{
    [Description(@"The template method pattern is a behavioral design pattern that defines the program skeleton of an algorithm in a method, called template method, which defers some steps to subclasses.")]
    [DisplayName("TemplateMethod")]
    [Category("Behavioral")]
    public class TemplateMethodPattern : IPattern
    {
        private readonly Lazy<TemplateMethodForm> _baseView = new Lazy<TemplateMethodForm>();
        public Control GetView
        {
            get { return _baseView.Value; }
        }

        public Icon Icon
        {
            get { return Properties.Resources.skeleton; }
        }
    }
}
