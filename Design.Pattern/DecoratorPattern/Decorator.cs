using System;

namespace Design.Pattern.DecoratorPattern
{
    public abstract class TankDecorator : Tank
    {
        private readonly Tank _tank;

        public TankDecorator(Tank tank)
            : base(tank.Name)
        {
            this._tank = tank;
        }

        public override void Shoot()
        {
            this._tank.Shoot();
        }

        public override void Run()
        {
            this._tank.Run();
        }
    }

    /// <summary>
    /// 红外功能
    /// </summary>
    public class InfraredFunctionTank : TankDecorator
    {
        public InfraredFunctionTank(Tank tank)
            : base(tank)
        {
        }

        public override void Shoot()
        {
            //Do some extension 功能扩展 且有红外功能
            Console.WriteLine("射击扩展 红外功能");
            base.Shoot();
        }

        public override void Run()
        {
            base.Run();
        }
    }

    /// <summary>
    /// 两栖功能
    /// </summary>
    public class AmphibiousFunctionTakn : TankDecorator
    {
        public AmphibiousFunctionTakn(Tank tank)
            : base(tank)
        {
        }

        public override void Run()
        {
            // 扩展 两栖功能
            Console.WriteLine("运行扩展 两栖功能");
            base.Run();
        }

        public override void Shoot()
        {
            base.Shoot();
        }
    }
}
