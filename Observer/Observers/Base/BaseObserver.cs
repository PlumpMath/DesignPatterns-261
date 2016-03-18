
using System.Drawing;
using Observer.Subjects;

namespace Observer.Observers.Base
{
    public abstract class BaseObserver
    {
        protected readonly ISubject _subject;
        protected Graphics _graphics;
        protected Rectangle _rect;
        protected BaseObserver(Graphics graphics,Rectangle rect,ISubject subject)
        {
            _graphics = graphics;
            _rect = rect;
            _subject = subject;
        }
        public abstract void Update();
        public void Register()
        {
            _subject.RegistrerObserver(this);
        }

        public void UnRegister()
        {
            _subject.UnRegistrerObserver(this);
        }

    }
}
