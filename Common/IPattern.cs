using System.Drawing;
using System.Windows.Forms;

namespace DP.Common
{
    public interface IPattern
    {
        Control GetView { get; }
        Icon Icon { get; }
    }
}
