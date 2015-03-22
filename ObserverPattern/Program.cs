using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/********************
 * Observer Pattern(观察折模式):定义了一种一对多的依赖关系，
 * 让多个观察对象同时监听某一个观察主题对象，
 * 这个主题对象在发生变化时会通知所有的观察对象，使他们能够更新自己
 * ********************/
namespace ObserverPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Boss boss = new Boss();

            //会计在观察老板
            Accounting accouting = new Accounting(boss);


            //策划也在观察老板
            Scheme scheme = new Scheme(boss);

            //把事件添加上去
            boss.Update += new Boss.MyEvent(accouting.GiveMenoy);
            boss.Update += new Boss.MyEvent(scheme.GivePlne);

            boss.SetState("过生日了");
            boss.Notify();

            Console.ReadLine();


        }
    }
}
