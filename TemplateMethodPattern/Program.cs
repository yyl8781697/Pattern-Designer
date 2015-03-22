using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/***************************
 * 模板方法模式(TemplateMethod Pattern)：定义一些操作中的算法骨架，
 * 而将一些步骤延迟到子类中，模板方法可以使得不改变原有的算法结构
 * 而重定义某些算法的步骤
 * *************************/
namespace TemplateMethodPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Person chinese = new Chinese();
            chinese.SayHello();

            Person american = new American();
            american.SayHello();

            Console.ReadKey();
        }
    }
}
