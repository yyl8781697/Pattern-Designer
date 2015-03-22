using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/***************
 * 代理类，保存一个引用是的代理可以访问实体，并提供一个与
 * Subject接口相同的接口，这样代理就可以代替实体类
 * ************/
namespace ProxyPattern
{
    /// <summary>
    /// 计算机代理
    /// </summary>
    public class Proxy:IOnline
    {
        private Computer _computer;

        public Proxy(int speed)
        {
            this._computer = new Computer(speed);
        }

        public void Online()
        {
            Console.WriteLine("使用了代理 速度加了2呗");
            //加速
            this._computer._speed *=2;
            this._computer.Online();
        }
    }
}
