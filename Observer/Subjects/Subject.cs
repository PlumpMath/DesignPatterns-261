
using System.Collections.Generic;
using System.Drawing;
using Observer.Observers.Base;

namespace Observer.Subjects
{
    public class Subject : ISubject
    {
        private readonly List<BaseObserver> observerList = new List<BaseObserver>();
        private Color _elementColor;
        public void RegistrerObserver(BaseObserver observer)
        {
            observerList.Add(observer);
        }

        public void UnRegistrerObserver(BaseObserver observer)
        {
            observerList.Remove(observer);
        }
        public void NotifyObservers()
        {
            foreach (var baseObserver in observerList)
            {
                baseObserver.Update();
            }
        }

        public Color ElementColor
        {
            get { return _elementColor; }
        }
        public void SetElementColor(Color color)
        {
            _elementColor = color;
        }
    }
}
