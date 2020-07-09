namespace Design.Pattern.FactoryMethodPattern
{
    /// <summary>
    /// The 'Product' abstract class.
    /// </summary>
    public abstract class CreditCard
    {
        public abstract string CardType { get; }
        public abstract int CreditLimit { get; set; }
        public abstract int AnnualCharge { get; set; }
    }
}
