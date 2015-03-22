using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BridgePattern
{
    /// <summary>
    /// 诺基亚
    /// </summary>
    public class Nokia:PhoneBrand
    {
        public Nokia()
        {
            base.brandName = "诺基亚";
        }

        public override void Run()
        {
            Console.WriteLine(base.brandName);
            base.currentPhoneSoft.Run();
        }
    }
}
