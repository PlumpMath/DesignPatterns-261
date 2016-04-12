using System;
using System.Drawing;
using System.Timers;
using DP.Strategy.Elements.Base;
using DP.Common.Attributes;

namespace DP.Strategy.Behaviors.Base
{
    [PatternSourceCode]
    public abstract class BaseBehavior
    {
        private readonly Timer _timer;
        protected BaseElement _element;
        protected Graphics _graphics;
        protected object lockObject = new object();

        protected BaseBehavior(BaseElement element, Graphics graphics)
        {
            _element = element; 
            _graphics = graphics;
            _timer = new Timer(1000);
            _timer.Elapsed -= _timer_Elapsed;
            _timer.Elapsed += _timer_Elapsed;
        }

        void _timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            Draw();
        }

        public void Start()
        {
            _timer.Start();
        }
        public void Stop()
        {
            _timer.Stop();
        }

        public abstract void Draw();

    }
}
