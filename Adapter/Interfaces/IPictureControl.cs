
using System.Drawing;

namespace Adapter.Interfaces
{
    public interface IPictureControl
    {
        void Load(string uri);
        Image Image { get; set; }
    }
}
