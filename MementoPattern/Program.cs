using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/****************************
 * Memento Pattern(备忘录模式)：在不破坏原有类的封装性下、
 * 捕获这个对象的内部状态，并且存储到另一个类中。
 * 这样以后就可以让该对象获取到原先保存到的状态
 * ***************************/
namespace MementoPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //创建一个角色
            GameRole xiaoming=new GameRole("小明",100,50,1000,300,345);

            xiaoming.DisplayInfo();

            //一个存储进度的类
            CareTaker taker = new CareTaker();
            //把信息存档
            taker[0] = xiaoming.Archive();
            Console.WriteLine(xiaoming.Fight() ? "大战boss赢了" : "大战boss输掉了");

            //大战boss之后的信息
            xiaoming.DisplayInfo();

            //读取存档
            xiaoming.Read(taker[0]);

            //显示读取之后的信息
            xiaoming.DisplayInfo();

            Console.Read();

        }
    }
}
