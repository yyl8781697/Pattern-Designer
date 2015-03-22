using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StrategyPattern
{
    /// <summary>
    /// 收银的基类
    /// </summary>
    public abstract class CashSuper
    {
        /// <summary>
        /// 收银数
        /// </summary>
        /// <param name="money">原价</param>
        /// <returns></returns>
        public abstract double AcceptCash(double money);
    }
}
