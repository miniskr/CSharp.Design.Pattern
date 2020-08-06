using System;
using System.Collections.Generic;
using System.Text;

namespace Design.Pattern.PrototypePattern
{
    public class GameSystem
    {
        public void Run(NormalActor normalActor)
        {
            var normalActor1 = normalActor.Clone();
            var normalActor2 = normalActor.Clone();
            var normalActor3 = normalActor.Clone();
            var normalActor4 = normalActor.Clone();
            var normalActor5 = normalActor.Clone();
            var normalActor6 = normalActor.Clone();

        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            GameSystem gameSystem = new GameSystem();

            gameSystem.Run(new NormalActorA());
        }
    }
}
