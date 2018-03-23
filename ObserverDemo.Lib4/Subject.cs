using System;

namespace ObserverDemo.Lib4
{
    public class Subject : ISubject<StateChangedEventArgs>
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

        public event EventHandler<StateChangedEventArgs> StateChanged;

        public void Attach(IObserver<StateChangedEventArgs> observer)
        {
            StateChanged += observer.Update;
        }

        public void Detach(IObserver<StateChangedEventArgs> observer)
        {
            StateChanged -= observer.Update;
        }

        public void Notify()
        {
            StateChanged?.Invoke(this, new StateChangedEventArgs {CurrentState = SubjectState});
        }
    }
}
