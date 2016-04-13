using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using DP.Common;
using DP.Common.Attributes;
using DP.Visitor.Properties;
using DP.Visitor.Views;

namespace DP.Visitor
{
    [Description(@"The visitor design pattern is a way of separating an algorithm from an object structure on which it operates. A practical result of this separation is the ability to add new operations to existing object structures without modifying those structures. It is one way to follow the open/closed principle.")]
    [DisplayName("Visitor")]
    [Category("Behavioral")]
    [PatternIcon(typeof(Resources), "system_users")]
    public class VisitorPattern : IPattern
    {
        private readonly Lazy<VisitorView> _baseView = new Lazy<VisitorView>();

        Control IPattern.GetView
        {
            get { return _baseView.Value; }
        }
    }
}
