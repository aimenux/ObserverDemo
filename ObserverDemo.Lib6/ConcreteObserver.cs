using System;

namespace ObserverDemo.Lib6
{
    public class ConcreteObserver
    {
        private readonly string _name;

        public ConcreteObserver(string name)
        {
            _name = name;
        }

        public void Update(string value)
        {
            Console.WriteLine($"Yo '{_name}', state has changed to '{value}'");
        }
    }
}
