using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StrategyPattern
{
    /// <summary>
    /// 这个就是策略类
    /// </summary>
    public class CashContext
    {
        /// <summary>
        /// 规则集合
        /// </summary>
        private List<CashSuper> _listCash=new List<CashSuper>();

        /// <summary>
        /// 初始化收钱的规则
        /// </summary>
        /// <param name="cash"></param>
        public CashContext(CashSuper cash)
        {
            this._listCash.Add(cash);
        }

        /// <summary>
        /// 多规则一起合并收钱
        /// </summary>
        /// <param name="listCash"></param>
        public CashContext(List<CashSuper> listCash)
        {
            this._listCash.AddRange(listCash);
        }

        /// <summary>
        /// 得到结果
        /// </summary>
        /// <param name="money">元商品价格</param>
        /// <returns></returns>
        public double GetResult(double money)
        {
            foreach (CashSuper cash in this._listCash)
            {
                money = cash.AcceptCash(money);
            }

            return money;
        }
    }
}
