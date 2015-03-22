using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern
{
    public class LeiFeng
    {
        public void Sweep()
        {
            Console.WriteLine("扫地");
        }

        public void Wash()
        {
            Console.WriteLine("洗衣");
        }

        public void BuyRice()
        {
            Console.WriteLine("买米");
        }
    }

    public class Undergradute : LeiFeng { }
    public class Volunteer : LeiFeng { }
}
