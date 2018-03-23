using System;
using System.Collections.Generic;

namespace ObserverDemo.Lib5
{
    public class Subject : IObservable<string>
    {
        private readonly ICollection<IObserver<string>> _observers = new List<IObserver<string>>();

        private string _state;

        public string SubjectState
        {
            get => _state;
            set
            {
                _state = value;
                Notify();
            }
        }

        public IDisposable Subscribe(IObserver<string> observer)
        {
            if (!_observers.Contains(observer)) _observers.Add(observer);
            return new Unsubscriber(_observers, observer);
        }

        public void Notify()
        {
            if (string.IsNullOrWhiteSpace(SubjectState))
            {
                foreach (var observer in _observers)
                {
                    observer.OnError(new Exception("Bad state !"));
                }
            }
            else
            {
                foreach (var observer in _observers)
                {
                    observer.OnNext(SubjectState);
                }
            }
        }
    }
}
