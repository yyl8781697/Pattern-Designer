using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*********************************
 * Bridge Pattern(桥接模式)：将抽象
 * 部分与他的实现部分分离，使他们都是独立变化
 * ******************************/
namespace BridgePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game();
            Music music = new Music();

            //实例化一个Nokia的手机
            Nokia nokia = new Nokia();
            nokia.SetUp(game);
            nokia.Run();
            nokia.SetUp(music);
            nokia.Run();

            Console.WriteLine();

            //实例化一个Samsung的手机
            Samsung samsung = new Samsung();
            samsung.SetUp(game);
            samsung.Run();
            samsung.SetUp(music);
            samsung.Run();

            Console.ReadKey();


        }
    }
}
