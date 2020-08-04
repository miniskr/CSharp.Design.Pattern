using System;

namespace Design.Pattern.BuilderPattern
{
    public class ChineseBuilder : Builder
    {
        private readonly House _chineseHouse = new House();

        public override void BuildDoor()
        {
            Console.WriteLine("this Door 's style of Chinese");
        }

        public override void BuildFloor()
        {
            Console.WriteLine("this Floor 's style of Chinese");
        }

        public override void BuildHouseCelling()
        {
            Console.WriteLine("this Ceiling 's style of Chinese");
        }

        public override void BuildWall()
        {
            Console.WriteLine("this Wall 's style of Chinese");
        }

        public override void BuildWindows()
        {
            Console.WriteLine("this Windows 's style of Chinese");
        }

        public override House GetHouse()
        {
            return this._chineseHouse;
        }


    }
}
