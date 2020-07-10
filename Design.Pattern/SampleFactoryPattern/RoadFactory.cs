using System;
using System.Collections.Generic;
using System.Text;

namespace Design.Pattern.SampleFactoryPattern
{
    public class RoadFactory
    {
        public static Road CreateRoad() => new Road();

        public static Building CreateBuilding() => new Building();

        public static Tunnel CreateTunnel() => new Tunnel();

        public static Jungle CreateJungle() => new Jungle();
    }
}
