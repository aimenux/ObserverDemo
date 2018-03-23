using System;

namespace ObserverDemo.Lib1
{
    public class ConcreteObserver : Observer
    {
        private readonly string _name;

        public ConcreteSubject Subject { get; }

        public string ObserverState { get; private set; }

        public ConcreteObserver(ConcreteSubject subject, string name)
        {
            Subject = subject;
            _name = name;
        }

        public override void Update()
        {
            ObserverState = Subject.SubjectState;
            Console.WriteLine($"Yo '{_name}', state has changed to '{ObserverState}'");
        }
    }
}
