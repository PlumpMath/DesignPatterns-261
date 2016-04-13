using DP.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using DP.Common.Attributes;
using DP.Observer.Properties;

namespace DP.Observer
{
    [Description(@"The observer pattern is a software design pattern in which an object, called the subject, maintains a list of its dependents, called observers, and notifies them automatically of any state changes, usually by calling one of their methods.")]
    [DisplayName("Observer")]
    [Category("Behavioral")]
    [PatternIcon(typeof(Resources), "eye")]
    public class ObserverPattern : IPattern
    {
        private readonly Lazy<ObserverForm> _baseView = new Lazy<ObserverForm>();
        public Control GetView
        {
            get { return _baseView.Value; }
        }
        
    }
}
