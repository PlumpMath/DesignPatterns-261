using DP.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using DP.Common.Attributes;
using DP.Strategy.Properties;

namespace DP.Strategy
{
    [Description(@"The strategy pattern (policy pattern) is a software design pattern that enables an algorithm's behavior to be selected at runtime.")]
    [DisplayName("Strategy")]
    [Category("Behavioral")]
    [PatternIcon(typeof(Resources), "exchange")]
    public class StrategyPattern : IPattern
    {
        private readonly Lazy<StrategyForm> _baseView = new Lazy<StrategyForm>();
        public Control GetView
        {
            get { return _baseView.Value; }
        }
    }
}
