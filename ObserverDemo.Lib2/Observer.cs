namespace ObserverDemo.Lib2
{
    public abstract class Observer : IObserver
    {
        public abstract void Update(ISubject subject);
    }
}
