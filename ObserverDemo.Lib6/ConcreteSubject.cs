using System;
using System.Reactive.Subjects;

namespace ObserverDemo.Lib6
{
    public class ConcreteSubject : IDisposable
    {
        private readonly Subject<string> _subject = new Subject<string>();

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

        public IDisposable Subscribe(ConcreteObserver observer)
        {
            return _subject?.Subscribe(observer.Update);
        }

        public void Notify()
        {
            if (!string.IsNullOrWhiteSpace(SubjectState))
            {
                _subject?.OnNext(SubjectState);
                return;
            }

            var exception = new Exception("Bad state !");
            _subject?.OnError(exception);
        }

        public void Dispose()
        {
            _subject?.Dispose();
        }
    }
}
