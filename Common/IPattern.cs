using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Common
{
    public interface IPattern
    {
        Control GetView { get; }
        Dictionary<string, string> SourceCode { get; }
    }
}
