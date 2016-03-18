
namespace Adapter.Interfaces
{
    public interface IPictureControlExt : IPictureControl
    {
        void Save(string fileName);
        void Reverse();
    }
}
