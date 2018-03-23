using System;

namespace ObserverDemo.Lib1
{
    public class ConcreteObserver : Observer
    {
        private readonly string _name;

        public ConcreteSubject Subject { get; }

        public ConcreteObserver(ConcreteSubject subject, string name)
        {
            Subject = subject;
            _name = name;
        }

        public override void Update()
        {
            Console.WriteLine($"Yo '{_name}', state has changed to '{Subject.SubjectState}'");
        }
    }
}
