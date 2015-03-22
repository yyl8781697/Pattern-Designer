using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StatePattern
{
    /// <summary>
    /// 状态的抽象类
    /// </summary>
    public abstract class State
    {
        /// <summary>
        /// 这个状态时需要写程序的
        /// </summary>
        /// <param name="work"></param>
        public abstract void WriteProgram(Work work);
    }
}
