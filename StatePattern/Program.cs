using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/***********************
 * State Pattern(状态模式):当一个对象的内在状态允许改变其行为，
 * 这个对象看起来像是改变了其类
 * 
 * 状态模式主要解决的是当空值一个对象状态转换的条件表达式过于复杂时，
 * 把状态的逻辑转移到不同状态的一系列类当中，可以吧复杂的判断逻辑简单化
 * *********************/
namespace StatePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            ///定义一个工作者
            Work i = new Work();
            i.Hour = 9;
            i.WriteProgram();

            i.Hour = 11;
            i.WriteProgram();

            i.Hour = 15;
            i.WriteProgram();

            i.Hour = 18;
            i.WriteProgram();

            Console.ReadLine();
        }
    }
}
