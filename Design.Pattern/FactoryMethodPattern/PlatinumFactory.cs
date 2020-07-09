namespace Design.Pattern.FactoryMethodPattern
{
    public class PlatinumFactory : CardFactory
    {
        private readonly int _creditLimit;
        private readonly int _annualCharge;

        public PlatinumFactory(int creditLimit, int annualCharge)
        {
            this._creditLimit = creditLimit;
            this._annualCharge = annualCharge;
        }

        public override CreditCard GetCreditCard()
        {
            return new PlatinumCreditCard(this._creditLimit, this._annualCharge);
        }
    }
}
