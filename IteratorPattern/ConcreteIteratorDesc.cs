using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IteratorPattern
{
    /// <summary>
    /// 具体迭代器类 降序
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class ConcreteIteratorDesc<T>:Iterator
    {
        /// <summary>
        /// 声明一个具体的聚合类变量
        /// </summary>
        private ConcreteAggegate<T> _aggegate;

        /// <summary>
        /// 当前的计数
        /// </summary>
        private int count = -1;

        public ConcreteIteratorDesc(ConcreteAggegate<T> aggegate)
        {
            this._aggegate = aggegate;
            this.count=aggegate.Count>0?aggegate.Count:-1;
        }

        /// <summary>
        /// 获取第一个元素
        /// </summary>
        /// <returns></returns>
        public override object First()
        {
            object obj = null;
            if (this.count > -1)
            {
                obj = this._aggegate[this._aggegate.Count-1];
            }
            return obj;
        }

        /// <summary>
        /// 向后移动
        /// </summary>
        /// <returns></returns>
        public override bool MoveNext()
        {
            bool flag = false;
            if (count >0)
            {
                flag = true;
                count--;
            }
            return flag;
        }

        /// <summary>
        /// 取得当前项
        /// </summary>
        /// <returns></returns>
        public override object CuurentItem()
        {
            object obj=null;
            if (this.count > -1 && this.count<this._aggegate.Count)
            {
                obj = this._aggegate[count];
            }
            return obj;
        }
    }
}
