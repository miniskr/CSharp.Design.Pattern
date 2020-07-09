using System;

namespace Design.Pattern
{
    /// <summary>
    /// 单例模式,带线程锁
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


    /// <summary>
    /// 使用Lazy实现单例模式
    /// </summary>
    public sealed class SingletonUseLazy
    {
        private static readonly Lazy<SingletonUseLazy> _lazy =
            new Lazy<SingletonUseLazy>(() => new SingletonUseLazy());

        private SingletonUseLazy() 
        {
        }

        public static SingletonUseLazy Instance { get { return _lazy.Value; } }
    }
}
