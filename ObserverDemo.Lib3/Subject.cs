namespace ObserverDemo.Lib3
{
    public class Subject : ISubject
    {
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

        public delegate void StateChangingEventHandler(ISubject subject);

        public event StateChangingEventHandler OnStateChangedEvent;

        public void Attach(IObserver observer)
        {
            OnStateChangedEvent += observer.Update;
        }

        public void Detach(IObserver observer)
        {
            OnStateChangedEvent -= observer.Update;
        }

        public void Notify()
        {
            OnStateChangedEvent?.Invoke(this);
        }
    }
}
