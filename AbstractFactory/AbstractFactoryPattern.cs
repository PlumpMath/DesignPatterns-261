using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DP.AbstractFactory.Properties;
using DP.Common;
using DP.Common.Attributes;

namespace DP.AbstractFactory
{
    [Description(@"The abstract factory pattern provides a way to encapsulate a group of individual factories that have a common theme without specifying their concrete classes.")]
    [DisplayName("AbstractFactory")]
    [Category("Creational")]
    [PatternIcon(typeof(Resources),"factory")]
    public class AbstractFactoryPattern : IPattern
    {
        private readonly Lazy<AbstractFactoryForm> _baseView = new Lazy<AbstractFactoryForm>();
        public Control GetView
        {
            get { return _baseView.Value; }
        }
    }
}
