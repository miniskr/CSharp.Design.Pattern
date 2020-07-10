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

            var platinumCreditCard = factory.GetCreditCard();

            Assert.False(platinumCreditCard is MoneyBackCreditCard);
            Assert.False(platinumCreditCard is TitaniumCreditCard);
            Assert.True(platinumCreditCard is PlatinumCreditCard);
        }
    }
}
