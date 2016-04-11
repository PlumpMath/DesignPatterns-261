
using DP.Common;
using System.Drawing;

namespace Adapter.Interfaces
{
    [PatternSourceCode]
    public interface IPictureControl
    {
        void Load(string uri);
        Image Image { get; set; }
    }
}
