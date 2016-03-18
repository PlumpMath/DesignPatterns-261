
using System.Drawing;
using Observer.Observers.Base;

namespace Observer.Subjects
{
    public interface ISubject
    {
        void RegistrerObserver(BaseObserver observer);
        void UnRegistrerObserver(BaseObserver observer);
        void NotifyObservers();
        Color ElementColor { get; }
        void SetElementColor(Color color);
    }
}
