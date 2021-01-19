using System;

namespace Design.Pattern.ObserverPattern
{
    public class Emailer : IObserverAccount
    {
        private readonly string _emailer;
        private readonly Subject _subject;

        public Emailer(string emailer, Subject subject)
        {
            this._emailer = emailer;
            this._subject = subject;
        }

        public void Update()
        {
            // do something...

            Console.WriteLine($"Notified: Emailer is {this._emailer}, withdraw: {this._subject.Money}.");
        }
    }
}
