using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/****************************
 * 装饰模式（Decorate）：动态的给一个对象添加一些额外的职责，
 * 就添加功能而言，装饰模式比生成子类更加灵活
 * **************************/
namespace DecoratePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person("Tom");

            TShirts tShirts = new TShirts();
            BigTrouse bigTrouse = new BigTrouse();
            WearSneakers wearSneakers = new WearSneakers();
            WearSuit wearSuit = new WearSuit();
            WearTie wearTie = new WearTie();

            tShirts.Decorate(p);
            bigTrouse.Decorate(tShirts);
            wearSneakers.Decorate(bigTrouse);
            wearSuit.Decorate(wearSneakers);

            wearSuit.Show();
            Console.Read();

        }
    }
}
