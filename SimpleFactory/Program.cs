using System;
using System.Collections.Generic;
using System.Text;

/*********************************
 * Simple Factory Pattern（访问者模式）
 * 
 * 本例用户计算器的实现
 * *****************************/
namespace SimpleFactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Operation oper;
            oper = OperationFactory.CreateOperate("+");
            oper.NumberA = 1;
            oper.NumberB = 2;
            Console.WriteLine(oper.GetResult());

            oper = OperationFactory.CreateOperate("-");
            oper.NumberA = 1;
            oper.NumberB = 2;
            Console.WriteLine(oper.GetResult());

            oper = OperationFactory.CreateOperate("*");
            oper.NumberA = 1;
            oper.NumberB = 2;
            Console.WriteLine(oper.GetResult());

            try
            {
                oper = OperationFactory.CreateOperate("/");
                oper.NumberA = 1;
                oper.NumberB = 0;
                Console.WriteLine(oper.GetResult());
            }
            catch (Exception e)
            {
                Console.WriteLine("异常：" + e.Message);
            }
            

            Console.ReadLine();
        }
    }
}
