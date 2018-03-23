using System;
using System.Collections.Generic;

namespace ObserverDemo.Lib5
{
    public sealed class Unsubscriber : IDisposable
    {
        private readonly IObserver<string> _observer;
        private readonly ICollection<IObserver<string>> _observers;

        public Unsubscriber(ICollection<IObserver<string>> observers, IObserver<string> observer)
        {
            _observer = observer;
            _observers = observers;
        }

        public void Dispose()
        {
            if (_observers == null) return;
            if (!_observers.Contains(_observer)) return;
            _observers.Remove(_observer);
        }
    }
}
