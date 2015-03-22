using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StrategyPattern
{
    /// <summary>
    /// 正常收银  没任何活动
    /// </summary>
    public class CashNormal:CashSuper
    {
        public CashNormal()
        {

        }

        /// <summary>
        /// 重写父类 返回应收钱数
        /// </summary>
        /// <param name="money">原价</param>
        /// <returns></returns>
        public override double AcceptCash(double money)
        {
            return money;
        }
    }
}
