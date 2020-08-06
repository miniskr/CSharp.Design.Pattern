using System;
using System.Collections.Generic;
using System.Text;

namespace Design.Pattern.AbstractClassAndInterface
{
    public abstract class Door
    {
        public virtual void Open()
        {
            Console.WriteLine("Open the door");
        }
        public abstract void Close();
    }
}
