using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BridgePattern
{
    /// <summary>
    /// 三星
    /// </summary>
    public class Samsung:PhoneBrand
    {
        public Samsung()
        {
            base.brandName = "三星";
        }

        public override void Run()
        {
            Console.WriteLine(base.brandName);
            base.currentPhoneSoft.Run();
        }
    }
}
