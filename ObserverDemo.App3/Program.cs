using System;
using ObserverDemo.Lib3;

namespace ObserverDemo.App3
{
    internal class Program
    {
        private static void Main()
        {
            var subject = new Subject();
            var observer1 = new Observer("observer1");
            var observer2 = new Observer("observer2");
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
