using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BridgePattern
{
    /// <summary>
    /// 游戏软件
    /// </summary>
    public class Game:PhoneSoft
    {
        public override void Run()
        {
            Console.WriteLine("运行游戏软件");
        }
    }
}
