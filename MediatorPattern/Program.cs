using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*****************************
 * Mediator Pattern(中介者模式):用一个中介者对象来封装一系列的对象交互。
 * 中介者使各个对象不需要显示的相互引用，从而使耦合松散，而且可以独立地
 * 改变他们之间的变化
 * *************************/
namespace MediatorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //申明联合国安全组织
            UnitedNationSecurity security = new UnitedNationSecurity();

            //申明国家
            USA usa = new USA(security);
            Iraq iraq = new Iraq(security);

            //指定好国家
            security.iraq = iraq;
            security.usa = usa;

            //宣布
            usa.Declare("你有核武器  我们要发动战争");
            iraq.Declare("我们没有核武器，不怕被侵略");

            Console.ReadKey();

        }
    }
}
