using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Common;
using Visitor.Views;

namespace Visitor
{
    [Description(@"The visitor design pattern is a way of separating an algorithm from an object structure on which it operates. A practical result of this separation is the ability to add new operations to existing object structures without modifying those structures. It is one way to follow the open/closed principle.")]
    [DisplayName("Visitor")]
    [Category("Behavioral")]
    public class VisitorPattern : IPattern
    {
        private readonly Lazy<VisitorView> _baseView = new Lazy<VisitorView>();
        Control IPattern.GetView
        {
            get { return _baseView.Value; }
        }
        public Dictionary<string, string> SourceCode { get; }
    }
}
