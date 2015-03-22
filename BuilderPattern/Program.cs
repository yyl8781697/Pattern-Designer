using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/**********************
 * Builder Pattern(建造者模式)：它主要用于构建一些复杂的对象
 * 这些对象对内部的构建顺序通常是稳定的，但是对象内部的构建
 * 通常面临着复杂的方法
 * *******************/
namespace BuilderPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Director director = new Director();

            //声明一个精细构建1的类
            ConcreteBuilder1 cb1 = new ConcreteBuilder1();
            //通过统一的构造
            director.Construct(cb1);
            //得到构造后的结果
            Product p1=cb1.GetResult();

            //声明一个精细构建2的类
            ConcreteBuilder2 cb2 = new ConcreteBuilder2();
            //通过统一的构造
            director.Construct(cb2);
            //得到构造后的结果
            Product p2=cb2.GetResult();

            p1.Show();
            p2.Show();
            Console.ReadKey();
        }
    }
}
