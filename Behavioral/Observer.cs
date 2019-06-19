using System.Collections.Generic;

namespace Behavioral
{
    public interface IObserver
    {
        void Update();
    }

    /// <summary>
    /// Define a one-to-many dependency between subject and observer so that when one subject changes state, all its dependents are notified and updated automatically.It is suitable for distributed push-based notifications.
    /// </summary>
    public interface ISubject
    {
        void Notify();

        void Subscribe(IObserver observer);

        void UnSubscribe(IObserver observer);
    }

    public class Observer : IObserver
    {
        private string _name;

        public Observer(string name)
        {
            _name = name;
        }

        public void Update()
        {
            System.Console.WriteLine($"{_name} notified");
        }
    }

    public class Subject : ISubject
    {
        internal List<IObserver> observers = new List<IObserver>();
        private int _itemCount;

        public int ItemCount
        {
            get
            {
                return _itemCount;
            }
            set
            {
                _itemCount = value;
                Notify();
            }
        }

        public void Notify()
        {
            observers.ForEach(x => x.Update());
        }

        public void Subscribe(IObserver observer)
        {
            observers.Add(observer);
        }

        public void UnSubscribe(IObserver observer)
        {
            observers?.Remove(observer);
        }
    }
}