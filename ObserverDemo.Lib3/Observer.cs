using System;

namespace ObserverDemo.Lib3
{
    public class Observer : IObserver
    {
        private readonly string _name;

        public Observer(string name)
        {
            _name = name;
        }

        public void Update(ISubject subject)
        {
            if (!(subject is Subject obj)) return;
            Console.WriteLine($"Yo '{_name}', state has changed to '{obj.SubjectState}'");
        }
    }
}
