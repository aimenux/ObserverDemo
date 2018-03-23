﻿using System;

namespace ObserverDemo.Lib4
{
    public interface ISubject<out T> where T : EventArgs
    {
        void Attach(IObserver<T> observer);
        void Detach(IObserver<T> observer);
        void Notify();
    }
}
