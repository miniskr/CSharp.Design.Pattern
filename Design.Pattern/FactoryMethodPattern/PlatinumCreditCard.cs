namespace Design.Pattern.FactoryMethodPattern
{
    /// <summary>
    /// The 'ConcreteProduct' class.
    /// </summary>
    public class PlatinumCreditCard : CreditCard
    {
        private int _creditLimit;
        private int _annualCharge;
        private readonly string _cardType;

        public PlatinumCreditCard(int creditLimit, int annualCharge)
        {
            this._cardType = "Platinum";
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
