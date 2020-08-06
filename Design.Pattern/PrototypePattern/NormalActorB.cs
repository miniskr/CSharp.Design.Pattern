using System;
using System.Collections.Generic;
using System.Text;

namespace Design.Pattern.PrototypePattern
{
    public class NormalActorB : NormalActor
    {
        public override NormalActor Clone()
        {
            Console.WriteLine("NormalActorB is called.");

            return (NormalActor)this.MemberwiseClone();
        }
    }
}
