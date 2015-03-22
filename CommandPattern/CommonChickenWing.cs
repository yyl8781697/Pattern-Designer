using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CommandPattern
{
    /// <summary>
    /// 烤鸡翅的命名
    /// </summary>
    public class CommonChickenWing:Command
    {
        public CommonChickenWing(Barbecuer receiver)
            : base(receiver)
        { }

        /// <summary>
        /// 执行烤鸡翅的命名
        /// </summary>
        public override void Excute()
        {
            base.receiver.BakeChickenWing();
        }
    }
}
