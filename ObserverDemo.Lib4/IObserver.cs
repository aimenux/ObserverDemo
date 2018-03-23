using System;

namespace ObserverDemo.Lib4
{
    public interface IObserver<in T> where T : EventArgs
    {
        void Update(object sender, T e);
    }
}
