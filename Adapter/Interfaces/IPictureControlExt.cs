
using DP.Common;

namespace Adapter.Interfaces
{
    [PatternSourceCode]
    public interface IPictureControlExt : IPictureControl
    {
        void Save(string fileName);
        void Reverse();
    }
}
