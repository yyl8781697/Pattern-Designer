using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/**********************************
 * 原型模式（Prototype）：用原型实例来创建指定对象的种类
 * 并通过拷贝这些原型来创建新的对象
 * ******************************/

namespace PrototypePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Person tom = new Person();
            tom.Name = "tom";
            tom.Age = 23;
            tom.SetContact("11@.com", "ningbo", "152");

            Person peter = (Person)tom.Clone();
            peter.Name = "peter";
            peter.Age = 24;
            peter.SetContact("22@.com", "jiaxing", "138");

            tom.Display();
            peter.Display();

            Console.Read();
        }
    }
}
