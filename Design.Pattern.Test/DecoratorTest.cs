using System;
using System.Collections.Generic;
using System.Text;
using Design.Pattern.DecoratorPattern;
using Xunit;

namespace Design.Pattern.Test
{
    public class DecoratorTest
    {
        [Fact]
        public void Test()
        {
            var t90 = new T90("T90");
            t90.Run();
            t90.Shoot();
            var infraredT90 = new InfraredFunctionTank(t90);
            infraredT90.Shoot();
            var amphibious = new AmphibiousFunctionTakn(t90);
            var infAndAmphi = new AmphibiousFunctionTakn(infraredT90);
            infAndAmphi.Shoot();
            infAndAmphi.Run();

            Assert.NotNull(t90);
            Assert.Equal("T90", t90.Name);
            Assert.NotNull(infraredT90);
            Assert.NotNull(amphibious);
            Assert.NotNull(infAndAmphi);
        }
    }
}
