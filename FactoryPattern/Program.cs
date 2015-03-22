using System;
using System.Collections.Generic;
using System.Text;

/**
 * Factory Pattern(工厂模式)
 * */
namespace FactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            IFactory factory;
            LeiFeng student;
            factory = new UndergraduteFactory();
            student = factory.CreateLeiFeng();
            student.BuyRice();
            student.Sweep();
            student.Wash();

            factory = new VolunteerFactory();
            student = factory.CreateLeiFeng();
            student.BuyRice();
            student.Sweep();
            student.Wash();
            Console.ReadLine();
        }
    }
}
