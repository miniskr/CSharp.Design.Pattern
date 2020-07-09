namespace Design.Pattern.FactoryMethodPattern
{
    public class MoenyBackFactory : CardFactory
    {
        private readonly int _creditLimit;
        private readonly int _annualCharge;

        public MoenyBackFactory(int creditLimit, int annualCharge)
        {
            this._creditLimit = creditLimit;
            this._annualCharge = annualCharge;
        }

        public override CreditCard GetCreditCard()
        {
            return new MoneyBackCreditCard(this._creditLimit, this._annualCharge);
        }
    }
}
