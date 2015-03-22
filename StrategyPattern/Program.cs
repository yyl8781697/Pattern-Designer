using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/****************************
 * 策略模式（Strategy）：他定义了算法的家族，分别封装起来，让他们之间可以相互替换
 * 此模式让宣发变化，不会影响到使用算法 的客户
 * **************************/
namespace StrategyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            double money = 0;
            CashContext context;

            money = Convert.ToDouble(Console.ReadLine());
            CashSuper cashNormal = new CashNormal();
            context=new CashContext(cashNormal);
            Console.WriteLine("无任何活动下收费："+context.GetResult(money));

            CashSuper cashRebate = new CashRebate(0.8);
            context = new CashContext(cashRebate);
            Console.WriteLine("打八折的情况下收费：" + context.GetResult(money));

            CashSuper cashReturn= new CashReturn(300,100);
            context = new CashContext(cashReturn);
            Console.WriteLine("满300送100下收费：" + context.GetResult(money));

            context = new CashContext(new List<CashSuper> { cashRebate, cashReturn });
            Console.WriteLine("先打八折，再满300 送100下收费：" + context.GetResult(money));

            context = new CashContext(new List<CashSuper> { cashReturn,cashRebate });
            Console.WriteLine("先满300 送100，再打八折：" + context.GetResult(money));

            Console.ReadKey();

        }
    }
}
