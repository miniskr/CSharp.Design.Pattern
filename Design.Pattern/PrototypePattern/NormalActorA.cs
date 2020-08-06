using System;
using System.Collections.Generic;
using System.Text;

namespace Design.Pattern.PrototypePattern
{
    public class NormalActorA : NormalActor
    {
        public override NormalActor Clone()
        {
            Console.WriteLine("NormalActorA is called.");

            return (NormalActor)this.MemberwiseClone();
        }
    }
}
