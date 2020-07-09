using Design.Pattern.FactoryMethodPattern;
using Xunit;

namespace Design.Pattern.Test
{
    public class FactoryMethodPatternTest
    {
        [Fact]
        public void FactoryMethodTest()
        {
            CardFactory factory = null;

            factory = new MoenyBackFactory(50000, 0);

            var moneyCreditCard = factory.GetCreditCard();

            Assert.True(moneyCreditCard is MoneyBackCreditCard);
            Assert.False(moneyCreditCard is TitaniumCreditCard);
            Assert.False(moneyCreditCard is PlatinumCreditCard);


            factory = new TitaniumFactory(100000, 500);

            var titaniumCreditCard = factory.GetCreditCard();

            Assert.False(titaniumCreditCard is MoneyBackCreditCard);
            Assert.True(titaniumCreditCard is TitaniumCreditCard);
            Assert.False(titaniumCreditCard is PlatinumCreditCard);


            factory = new PlatinumFactory(500000, 1000);

            var PlatinumCreditCard = factory.GetCreditCard();

            Assert.False(PlatinumCreditCard is MoneyBackCreditCard);
            Assert.False(PlatinumCreditCard is TitaniumCreditCard);
            Assert.True(PlatinumCreditCard is PlatinumCreditCard);

        }
    }
}
