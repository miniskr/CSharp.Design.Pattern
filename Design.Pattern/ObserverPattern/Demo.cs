using System;
using System.Collections.Generic;
using System.Text;

namespace Design.Pattern.ObserverPattern
{
    public class Demo
    {


        void Main(string[] args)
        {
            var account = new BankAccount(2000);
            var emailer = new Emailer("aaa@abc.com", account);
            var phone = new Mobile("13212345643", account);

            account.AddObserver(emailer);
            account.AddObserver(phone);

            account.Money = 200;
            account.WithDraw();


            var sub = new SubWithEvent
            {
                Money = 1000
            };
            var emailerEvent = new EmailerEvent("emailer event");

            sub.NotifyEvent += new NotifyEventHandler(emailerEvent.Update);

            sub.WithDraw();
        }
    }
}
