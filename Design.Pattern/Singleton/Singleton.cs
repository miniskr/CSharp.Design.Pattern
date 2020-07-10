using System;

namespace Design.Pattern
{
    /* 
     * 单例模式使用场景：
     * 1. 要求生成唯一序列号的场景；
     * 2. 项目需要一个共享访问点或共享数据，例如一个web计数器；
     * 3. 创建一个对象需要消耗很多资源，例如IO或访问数据库；
     * 4. 需要定义大量静态常量或静态方法，例如工具类；
     */

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
