using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Common.Views;

namespace Common
{
    public interface IPattern
    {
        BaseView GetView { get; }
        Dictionary<string, string> SourceCode { get; }
    }
}
