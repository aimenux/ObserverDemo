using System;

namespace ObserverDemo.Lib4
{
    public class Observer : IObserver<StateChangedEventArgs>
    {
        private readonly string _name;

        public Observer(string name)
        {
            _name = name;
        }

        public void Update(object sender, StateChangedEventArgs e)
        {
            Console.WriteLine($"Yo '{_name}', state has changed to '{e.CurrentState}'");
        }
    }
}
