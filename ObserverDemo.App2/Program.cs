using System;
using ObserverDemo.Lib2;

namespace ObserverDemo.App2
{
    internal class Program
    {
        private static void Main()
        {
            var subject = new ConcreteSubject();
            var observer1 = new ConcreteObserver("observer1");
            var observer2 = new ConcreteObserver("observer2");
            subject.Attach(observer1);
            subject.Attach(observer2);
            subject.SubjectState = "Modified";
            subject.Detach(observer1);
            subject.Detach(observer2);
            subject.SubjectState = "Modified Again !";
            Console.ReadKey();
        }
    }
}
