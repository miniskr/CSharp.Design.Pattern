using System;

namespace Design.Pattern.ObserverPattern
{
    public class Mobile : IObserverAccount
    {
        private readonly string _phoneNomber;
        private readonly Subject _subject;

        public Mobile(string phoneNomber, Subject subject)
        {
            this._phoneNomber = phoneNomber;
            this._subject = subject;
        }

        public void Update()
        {
            Console.WriteLine($"Notified: phone nomber:{this._phoneNomber}, withdraw:{this._subject.Money}.");
        }
    }
}
