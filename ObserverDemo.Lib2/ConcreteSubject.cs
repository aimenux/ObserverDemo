namespace ObserverDemo.Lib2
{
    public class ConcreteSubject : Subject
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
    }
}
