using System;

namespace Design.Pattern.DecoratorPattern
{
    public class T50 : Tank
    {
        public T50(string name)
            : base(name)
        {

        }

        public override void Run()
        {
            Console.WriteLine("T50坦克平均每时运行30公里");
        }

        public override void Shoot()
        {
            Console.WriteLine("T50坦克平均每秒射击5发子弹");
        }
    }

    public class T75 : Tank
    {
        public T75(string name)
            : base(name)
        {

        }

        public override void Run()
        {
            Console.WriteLine("T75坦克平均每时运行35公里");
        }

        public override void Shoot()
        {
            Console.WriteLine("T75坦克平均每秒射击10发子弹");
        }
    }

    public class T90 : Tank
    {
        public T90(string name)
            : base(name)
        {

        }
        public override void Run()
        {
            Console.WriteLine("T90坦克平均每秒射击10发子弹");
        }

        public override void Shoot()
        {
            Console.WriteLine("T90坦克平均每时运行40公里");
        }
    }
}
