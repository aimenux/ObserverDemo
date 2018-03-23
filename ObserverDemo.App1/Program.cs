using System;
using ObserverDemo.Lib1;

namespace ObserverDemo.App1
{
    internal class Program
    {
        private static void Main()
        {
            var subject = new ConcreteSubject();
            var observer1 = new ConcreteObserver(subject, "observer1");
            var observer2 = new ConcreteObserver(subject, "observer2");
            subject.Attach(observer1);
            subject.Attach(observer2);
            subject.SubjectState = "Modified";
            subject.Notify();
            subject.Detach(observer1);
            subject.Detach(observer2);
            subject.SubjectState = "Modified Again !";
            subject.Notify();
            Console.ReadKey();
        }
    }
}
