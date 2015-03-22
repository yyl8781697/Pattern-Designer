using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CommandPattern
{
    /// <summary>
    /// 烤羊肉串的命令
    /// </summary>
    public class CommandMutton:Command
    {
        public CommandMutton(Barbecuer receiver)
            : base(receiver)
        { }

        /// <summary>
        /// 执行烤羊肉串
        /// </summary>
        public override void Excute()
        {
            base.receiver.BakeMutton();
        }
    }
}
