using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BridgePattern
{
    /// <summary>
    /// 音乐软件
    /// </summary>
    public class Music:PhoneSoft
    {
        public override void Run()
        {
            Console.WriteLine("运行音乐软件");
        }
    }
}
