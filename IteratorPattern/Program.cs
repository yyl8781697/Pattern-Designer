using System;
using System.Collections.Generic;
using System.Linq;
/*****************************
 * Itertor pattern(迭代器模式)：提供一个方法按顺序遍历某个聚合对象的
 * 内部元素，而不暴露该对象的内部表示
 * ********************************/

namespace IteratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            ConcreteAggegate<string> aggegate = new ConcreteAggegate<string>();
            aggegate[0] = "小明";
            aggegate[1] = "小红";
            aggegate[2] = "小丁";
            aggegate[3] = "小白";

            
            //顺序读取
            Iterator iterator = new ConcreteIterator<string>(aggegate);

            Console.WriteLine("顺序读取");
            while (iterator.MoveNext())
            {
                Console.WriteLine(iterator.CuurentItem());
            }

            iterator = new ConcreteIteratorDesc<string>(aggegate);

            //逆序读取
            Console.WriteLine("逆序读取");
            while (iterator.MoveNext())
            {
                Console.WriteLine(iterator.CuurentItem());
            }

            Console.ReadKey();
            
        }
    }
}
