using System;
using System.Collections.Generic;
using System.Text;

namespace Design.Pattern
{
    /// <summary>
    /// 单例模式
    /// </summary>
    public sealed class Singleton
    {
        private static Singleton _instance = null;
        private static readonly object _obj = new object();

        private Singleton()
        {
        }

        public static Singleton Instance
        {
            get
            {
                lock (_obj)
                {
                    if (_instance == null)
                    {
                        _instance = new Singleton();
                    }

                    return _instance;
                }
            }
        }
    }
}
