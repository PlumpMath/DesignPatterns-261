using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Common;

namespace Visitor
{
    public class VisitorPattern : IPattern
    {
        Control IPattern.GetView { get; }
        public Dictionary<string, string> SourceCode { get; }
    }
}
