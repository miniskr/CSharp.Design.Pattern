namespace Design.Pattern.FactoryMethodPattern
{
    /// <summary>
    /// The 'ConcreteProduct' class.
    /// </summary>
    public class MoneyBackCreditCard : CreditCard
    {
        private readonly string _cardType;
        private int _creditLimit;
        private int _annualCharge;

        public MoneyBackCreditCard(int creditLimit, int annualCharge)
        {
            this._cardType = "MoneyBack";
            this._creditLimit = creditLimit;
            this._annualCharge = annualCharge;
        }

        public override string CardType
        {
            get => this._cardType;

        }
        public override int AnnualCharge
        {
            get => this._annualCharge;
            set { this._annualCharge = value; }
        }
        public override int CreditLimit
        {
            get => this._creditLimit;
            set { this._creditLimit = value; }
        }
    }
}
