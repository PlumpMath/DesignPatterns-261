using System.Drawing;
using DP.Common.Attributes;

namespace DP.Adapter.Interfaces
{
    [PatternSourceCode]
    public interface IPictureControl
    {
        void Load(string uri);
        Image Image { get; set; }
    }
}
