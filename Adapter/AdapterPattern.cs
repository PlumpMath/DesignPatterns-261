using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using DP.Adapter.Properties;
using DP.Common;
using DP.Common.Attributes;

namespace DP.Adapter
{
    [Description(@"The adapter pattern is a software design pattern that allows the interface of an existing class to be used from another interface.")]
    [DisplayName("Adapter")]
    [Category("Structurial")]
    [PatternIcon(typeof(Resources), "ac_adapter_32_16")]
    public class AdapterPattern : IPattern
    {
        private readonly Lazy<AdapterForm> _baseView = new Lazy<AdapterForm>();
        public Control GetView
        {
            get { return _baseView.Value; }
        }
    }
}
