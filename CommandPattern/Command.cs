using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CommandPattern
{
    /// <summary>
    /// 命名
    /// </summary>
    public abstract class Command
    {
        protected Barbecuer receiver;

        public Command(Barbecuer receiver)
        {
            this.receiver=receiver;
        }

        /// <summary>
        /// 执行
        /// </summary>
        public abstract void Excute();
    }
}
