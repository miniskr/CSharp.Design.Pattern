using Design.Pattern.SampleFactoryPattern;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Design.Pattern.Test
{
    public class SampleFactoryPatternTest
    {
        [Fact]
        void CreateSampleFactory()
        {
            var road = RoadFactory.CreateRoad();
            Assert.True(road is Road);

            var building = RoadFactory.CreateBuilding();
            Assert.True(building is Building);

            var tunnel = RoadFactory.CreateTunnel();
            Assert.True(tunnel is Tunnel);

            var jungle = RoadFactory.CreateJungle();
            Assert.True(jungle is Jungle);
        }
    }
}
