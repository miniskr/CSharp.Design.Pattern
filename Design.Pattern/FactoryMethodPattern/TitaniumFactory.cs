namespace Design.Pattern.FactoryMethodPattern
{
    public class TitaniumFactory : CardFactory
    {
        private readonly int _creditLimit;
        private readonly int _annualCharge;

        public TitaniumFactory(int creditLimit, int annualCharge)
        {
            this._creditLimit = creditLimit;
            this._annualCharge = annualCharge;
        }

        public override CreditCard GetCreditCard()
        {
            return new TitaniumCreditCard(this._creditLimit, this._annualCharge);
        }
    }
}
