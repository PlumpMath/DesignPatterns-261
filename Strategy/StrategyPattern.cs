using DP.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace DP.Strategy
{
    [Description(@"The strategy pattern (policy pattern) is a software design pattern that enables an algorithm's behavior to be selected at runtime.")]
    [DisplayName("Strategy")]
    [Category("Behavioral")]
    public class StrategyPattern : IPattern
    {
        private readonly Lazy<StrategyForm> _baseView = new Lazy<StrategyForm>();
        public Control GetView
        {
            get { return _baseView.Value; }
        }

        public Icon Icon
        {
            get { return Properties.Resources.exchange; }
        }
    }
}
