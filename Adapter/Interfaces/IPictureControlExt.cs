using DP.Common.Attributes;

namespace DP.Adapter.Interfaces
{
    [PatternSourceCode]
    public interface IPictureControlExt : IPictureControl
    {
        void Save(string fileName);
        void Reverse();
    }
}
