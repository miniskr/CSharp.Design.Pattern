namespace Design.Pattern.ObserverPattern
{
    public class BankAccount : Subject
    {
        public BankAccount(double money)
            : base(money)
        {
        }
    }
}
