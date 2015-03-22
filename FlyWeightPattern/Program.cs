using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*******************************************
 * FlyWeight Pattern(享元模式)：运用共享技术有效地支持
 * 大量颗粒度的对象
 * ***************************************/
namespace FlyWeightPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //声明一个享元工厂
            WebSiteFactory factory = new WebSiteFactory();

            //不同的用户使用不同类型的网站 
            //这里的四个网站其实只是使用了两个实例

            User xiaohua = new User("小花");
            factory.GetFlyWeight("博客").Use(xiaohua);
            
            User xiaocao = new User("小草");
            factory.GetFlyWeight("博客").Use(xiaocao);

            User zhangsan = new User("张三");
            factory.GetFlyWeight("新闻系统").Use(zhangsan);

            User lisi = new User("李四");
            factory.GetFlyWeight("新闻系统").Use(lisi);

            Console.ReadKey();
        }
    }
}
