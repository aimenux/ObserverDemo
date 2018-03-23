using System;
using ObserverDemo.Lib5;

namespace ObserverDemo.App5
{
    internal class Program
    {
        private static void Main()
        {
            var subject = new Subject();
            var observer1 = new Observer("observer1");
            var observer2 = new Observer("observer2");
            using (subject.Subscribe(observer1))
            using (subject.Subscribe(observer2))
            {
                subject.SubjectState = "Modified";
            }
            subject.SubjectState = "Modified Again !";
            Console.ReadKey();
        }
    }
}
