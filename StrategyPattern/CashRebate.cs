using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StrategyPattern
{
    /// <summary>
    /// 在打折活动下使用
    /// </summary>
    public class CashRebate:CashSuper
    {
        /// <summary>
        /// 折扣数
        /// </summary>
        private double _rebate;

        /// <summary>
        /// 初始化活动的折扣数
        /// </summary>
        /// <param name="rebate">折扣数</param>
        public CashRebate(double rebate)
        {
            this._rebate = rebate;
        }

        /// <summary>
        /// 打折后返回
        /// </summary>
        /// <param name="money"></param>
        /// <returns></returns>
        public override double AcceptCash(double money)
        {
            return this._rebate * money;
        }
    }
}
