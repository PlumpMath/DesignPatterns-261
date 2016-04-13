using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using DP.Common;
using DP.Common.Attributes;
using DP.Decorator.Properties;

namespace DP.Decorator
{
    [Description(@"The decorator pattern (also known as Wrapper) is a design pattern that allows behavior to be added to an individual object, either statically or dynamically, without affecting the behavior of other objects from the same class.")]
    [DisplayName("Decorator")]
    [Category("Structurial")]
    [PatternIcon(typeof(Resources), "package")]
    public class DecoratorPattern : IPattern
    {
        private readonly Lazy<DecoratorForm> _baseView = new Lazy<DecoratorForm>();
        public Control GetView
        {
            get { return _baseView.Value; }
        }
        
    }
}
