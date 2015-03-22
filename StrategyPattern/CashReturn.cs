using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StrategyPattern
{
    /// <summary>
    /// 返利 满多少 多少人 比如 满300  送100
    /// </summary>
    public class CashReturn:CashSuper
    {
        /// <summary>
        /// 到的钱数  就是满多少
        /// </summary>
        private double _achieveMoney;

        /// <summary>
        /// 减少的数量
        /// </summary>
        private double _minusMoney;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="achieveMoney">需要满足的钱数</param>
        /// <param name="minusMoney">减少的钱数</param>
        public CashReturn(double achieveMoney, double minusMoney)
        {
            this._achieveMoney = achieveMoney;
            this._minusMoney = minusMoney;
        }

        /// <summary>
        /// 返利收钱
        /// </summary>
        /// <param name="money"></param>
        /// <returns></returns>
        public override double AcceptCash(double money)
        {
            if (money > this._achieveMoney)
            {
                money -= this._minusMoney;
            }

            return money;
        }
        

    }
}
