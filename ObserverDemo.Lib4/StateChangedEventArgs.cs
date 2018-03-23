using System;

namespace ObserverDemo.Lib4
{
    public class StateChangedEventArgs : EventArgs
    {
        public string CurrentState { get; set; }
    }
}
