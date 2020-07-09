namespace Design.Pattern.FactoryMethodPattern
{
    /// <summary>
    /// The 'Creator' Abstract Class.
    /// </summary>
    public abstract class CardFactory
    {
        public abstract CreditCard GetCreditCard();
    }
}
