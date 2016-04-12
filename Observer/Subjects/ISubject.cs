
using System.Drawing;
using DP.Observer.Observers.Base;
using DP.Common.Attributes;

namespace DP.Observer.Subjects
{
    [PatternSourceCode]
    public interface ISubject
    {
        void RegistrerObserver(BaseObserver observer);
        void UnRegistrerObserver(BaseObserver observer);
        void NotifyObservers();
        Color ElementColor { get; }
        void SetElementColor(Color color);
    }
}
