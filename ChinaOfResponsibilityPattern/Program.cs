using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*********************************
 * Chain Of Responsibility(职责链模式):使多个对象都有机会处理请求，从而避免请求的发送者
 * 和接收的耦合关系，将这个对象连成一条链路，并沿着这条链路传递该请求，知道有一个对象
 * 处理他位置
 * ****************************/
namespace ChinaOfResponsibilityPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Leader leader = new Leader("小组长");
            Major major = new Major("总监");
            Boss boss = new Boss("老板");

            leader.SetSuperior(major);
            leader.SetSuperior(boss);

            Request request = new Request()
            {
                Type = "请假",
                Content = "家里有事要请假",
                Number = 3
            };
            //只能先从小组长那边进行申请
            leader.RequestApplication(request);
            Request request1 = new Request()
            {
                Type = "加薪",
                Content = "工作不错要加薪",
                Number = 300
            };
            leader.RequestApplication(request1);
            Request request2 = new Request()
            {
                Type = "加薪",
                Content = "干了个大工程要加薪",
                Number = 1300
            };
            leader.RequestApplication(request2);

            Console.ReadKey();
        }
    }
}
