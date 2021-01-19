using System;
using System.Reflection;

namespace Design.Pattern.BuilderPattern
{
    public class Client
    {
        public void Main(string[] args)
        {
            var director = new Director();

            Console.WriteLine(@"Please Enter House No: \n
                                1:Chinese House \n
                                2:Roman House");
            string No = Console.ReadLine();

            string houseType = "House.";
            if (No == "1")
                houseType += "ChineseBuilder";
            else if (No == "2")
                houseType += "RomanBuilder";
            else
                throw new InvalidOperationException("Invalid input option.");

            Builder builder = (Builder)Assembly.Load("House").CreateInstance(houseType);

            director.Construct(builder);

            House house = builder.GetHouse();

            house.Show();

            Console.ReadLine();
        }
    }
}
