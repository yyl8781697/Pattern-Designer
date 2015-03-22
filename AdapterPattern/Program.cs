using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*******************
 * Adapter Pattern(适配器模式)：将一个类的接口转换成客户希望的另一个接口
 * 适配器模式使得原本由于接口不兼容而不能一起工作的那些类可以一起工作
 * *****************/
namespace AdapterPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //普通的美国选手
            Player center = new Center("abc");
            center.Attack();
            center.Defense();

            //先实例化一个正常的 中文的姚明
            ChinaCenter cym = new ChinaCenter("姚明");
            //给予姚明一个中文的教练
            Player ym = new ChinaAdapter(cym);
            ym.Attack();
            ym.Defense();

            Console.ReadLine();
        }
    }
}
