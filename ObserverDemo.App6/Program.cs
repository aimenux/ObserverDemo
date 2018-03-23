using System;
using ObserverDemo.Lib6;

namespace ObserverDemo.App6
{
    internal class Program
    {
        private static void Main()
        {
            using (var subject = new ConcreteSubject())
            {
                var observer1 = new ConcreteObserver("observer1");
                var observer2 = new ConcreteObserver("observer2");

                using (subject.Subscribe(observer1))
                using (subject.Subscribe(observer2))
                {
                    subject.SubjectState = "Modified";
                }

                subject.SubjectState = "Modified Again !";
            }

            Console.ReadKey();
        }
    }
}
