using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


/****************************
 * 代理模式（Proxy）：为其他对象提供了一种代理以控制这个对象的访问
 * * **************************/
namespace ProxyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //普通计算机上网
            Computer computer = new Computer(3);
            computer.Online();

            //代理计算机上网
            Proxy proxy = new Proxy(3);
            proxy.Online();

            Console.ReadKey();
        }
    }
}
