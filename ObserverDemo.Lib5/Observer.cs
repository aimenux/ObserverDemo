using System;

namespace ObserverDemo.Lib5
{
    public class Observer : IObserver<string>
    {
        private readonly string _name;

        public Observer(string name)
        {
            _name = name;
        }

        public void OnNext(string value)
        {
            Console.WriteLine($"Yo '{_name}', state has changed to '{value}'");
        }

        public void OnError(Exception error)
        {
            Console.WriteLine($"Oups '{_name}', error '{error.Message}' has occured !");
        }

        public void OnCompleted()
        {
            Console.WriteLine($"Oh '{_name}', no more update !");
        }
    }
}
