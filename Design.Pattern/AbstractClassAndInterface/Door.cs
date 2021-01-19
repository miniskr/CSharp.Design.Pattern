using System;
using System.Collections.Generic;
using System.Text;

namespace Design.Pattern.AbstractClassAndInterface
{
    /// <summary>
    /// 抽象类功能描述该类的基本属性
    /// </summary>
    public abstract class Door
    {
        public virtual void Open()
        {
            Console.WriteLine("Open the door");
        }
        public abstract void Close();
    }
}
