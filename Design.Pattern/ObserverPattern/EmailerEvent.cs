using System;
using System.Collections.Generic;
using System.Text;

namespace Design.Pattern.ObserverPattern
{
    public class EmailerEvent
    {
        private readonly string _emailer;

        public EmailerEvent(string emailer)
        {
            this._emailer = emailer;
        }

        public void Update(object obj)
        {
            if (obj is SubWithEvent sub)
            {
                Console.WriteLine($"Notified: Emailer is {this._emailer}, withdraw:{sub.Money}");
            }
            else
                throw new ArgumentException("arg is not subject obj");
        }
    }
}
