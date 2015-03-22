using System;
using System.Collections.Generic;
using System.Text;

/**
 * Abstract Factory Pattern(抽象工厂模式):
 * 提供一个创建一些列相关或者相互依赖对象的接口，而无需指定他们具体的类
 * 
 * 本例以更换数据库为例
 * */
namespace AbstractFactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            IDataBase database = DataAccess.CreateDataBase();
            //这里用户只需要写SQL语句就可以，不需要管具体使用的数据库，
            //而关于具体使用的数据库一般是用XML来配置，当然更好是直接使用反射来做，这样可以更好的IOC
            database.Exectue("create ....");
            database.Select("select ...");
            Console.ReadLine();

        }
    }
}
