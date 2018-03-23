using System;

namespace ObserverDemo.Lib2
{
    public class ConcreteObserver : Observer
    {
        private readonly string _name;

        public ConcreteObserver(string name)
        {
            _name = name;
        }

        public override void Update(ISubject subject)
        {
            if (!(subject is ConcreteSubject obj)) return;
            Console.WriteLine($"Yo '{_name}', state has changed to '{obj.SubjectState}'");
        }
    }
}
