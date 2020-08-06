using Design.Pattern.PrototypePattern;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Design.Pattern.Test
{
    public class PrototypePatternTest
    {
        [Fact]
        public void TestPortotype()
        {
            GameSystem gameSystem = new GameSystem();

            gameSystem.Run(new NormalActorA());
        }
    }
}
