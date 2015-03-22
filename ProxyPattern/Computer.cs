using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProxyPattern
{
    /// <summary>
    /// 普通计算机
    /// </summary>
    public class Computer:IOnline
    {
        public int _speed;

        public Computer(int speed)
        {
            this._speed = speed;
        }

        public void Online()
        {
            Console.WriteLine("我上网了，速度是{0}",this._speed);
        }

    }
}
