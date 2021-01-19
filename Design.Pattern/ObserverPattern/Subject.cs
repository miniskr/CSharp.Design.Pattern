using System.Collections.Generic;

namespace Design.Pattern.ObserverPattern
{
    public abstract class Subject
    {
        private readonly List<IObserverAccount> _observers = new List<IObserverAccount>();
        private double _money;

        public Subject(double money)
        {
            this._money = money;
        }

        public double Money
        {
            get => this._money;
            set { this._money = value; }
        }

        public void WithDraw()
        {
            foreach (var observer in this._observers)
            {
                observer.Update();
            }
        }

        public void AddObserver(IObserverAccount observer)
        {
            this._observers.Add(observer);
        }

        public void RemoveObserver(IObserverAccount observer)
        {
            this._observers.Remove(observer);
        }
    }
}
