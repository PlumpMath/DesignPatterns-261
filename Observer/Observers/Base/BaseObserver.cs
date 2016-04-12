
using System.Drawing;
using DP.Observer.Subjects;
using DP.Common.Attributes;

namespace DP.Observer.Observers.Base
{
    [PatternSourceCode]
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
