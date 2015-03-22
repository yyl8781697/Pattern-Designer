using System;
using System.Collections.Generic;
using System.Text;

namespace SingletonPattern
{
    /// <summary>
    /// Singleton Pattern(单例模式)
    /// 类的实例化不对外公开，多个使用该类时始终都是使用同一个类
    /// </summary>
    public class Program
    {
        static void Main(string[] args)
        {
            Cache cache1 = Cache.Create3();
            cache1.Set("name", "小明");
            Cache cache2 = Cache.Create3();
            Console.WriteLine(cache2.Get("name"));
            Console.ReadLine();
        }
    }
}
