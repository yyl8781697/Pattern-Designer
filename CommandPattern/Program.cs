using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/****************************************
 * Command Pattern(命名模式)：将一个请求封装为一个对象，从而使你
 * 可用不同的请求对客户进行参数化,
 * 对请求排队或记录请求日志，以及支持可撤销的操作
 * *************************************/
namespace CommandPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //创建一个服务员
            Waiter girl = new Waiter();
            //创建一个真正的执行着
            Barbecuer receiver = new Barbecuer();
            //创建一个烤羊肉串的命令
            CommandMutton mutton = new CommandMutton(receiver);
            //创建一个烤鸡翅的命令
            CommonChickenWing chickenWing = new CommonChickenWing(receiver);

            girl.SetCommand(mutton);
            girl.SetCommand(chickenWing);
            girl.Execute();

            Console.ReadKey();

        }
    }
}
