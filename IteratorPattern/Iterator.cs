using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IteratorPattern
{
    /// <summary>
    /// 迭代抽象类
    /// </summary>
    public abstract class Iterator
    {
        public abstract object First();

        public abstract bool MoveNext();

        public abstract object CuurentItem();
    }
}
