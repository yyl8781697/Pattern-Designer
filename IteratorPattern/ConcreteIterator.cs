using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IteratorPattern
{
    /// <summary>
    /// 具体迭代器类
    /// </summary>
    public class ConcreteIterator<T>:Iterator
    {
        /// <summary>
        /// 声明一个具体的聚合类变量
        /// </summary>
        private ConcreteAggegate<T> _aggegate;

        /// <summary>
        /// 当前的计数
        /// </summary>
        private int count = -1;

        public ConcreteIterator(ConcreteAggegate<T> aggegate)
        {
            this._aggegate = aggegate;
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
                obj = this._aggegate[0];
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
            if (count < this._aggegate.Count - 1)
            {
                flag = true;
                count++;
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
            if (this.count > -1)
            {
                obj = this._aggegate[count];
            }
            return obj;
        }




    }
}
