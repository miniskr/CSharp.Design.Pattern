using System;

namespace Design.Pattern.BuilderPattern
{
    public class RomanBuilder : Builder
    {
        private readonly House _romanHouse;

        public RomanBuilder()
        {
            this._romanHouse = new House();
        }

        public override void BuildDoor()
        {
            Console.WriteLine("this Door 's style of Roman");
        }

        public override void BuildFloor()
        {
            Console.WriteLine("this Floor 's style of Roman");
        }

        public override void BuildHouseCelling()
        {
            Console.WriteLine("this Ceiling 's style of Roman");
        }

        public override void BuildWall()
        {
            Console.WriteLine("this Wall 's style of Roman");
        }

        public override void BuildWindows()
        {
            Console.WriteLine("this Windows 's style of Roman");
        }

        public override House GetHouse()
        {
            return this._romanHouse;
        }
    }
}
