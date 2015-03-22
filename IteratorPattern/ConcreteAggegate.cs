using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IteratorPattern
{
    /// <summary>
    /// 具体的聚合类
    /// </summary>
    public class ConcreteAggegate<T>:Aggegate<T>
    {
        private IList<T> list = new List<T>();

        /// <summary>
        /// 从自身类创建迭代器
        /// </summary>
        /// <returns></returns>
        public override ConcreteIterator<T> CreateIterator()
        {
            return new ConcreteIterator<T>(this);
        }

        /// <summary>
        /// 返回当前的数量x
        /// </summary>
        public int Count {
            get {
                return this.list.Count;
            }
        }
        
        /// <summary>
        /// 创建一个索引器
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public T this[int index]
        {
            get {
                return this.list[index];
            }
            set {
                this.list.Insert(index, value);
            }
        }



    }
}
