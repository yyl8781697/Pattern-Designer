using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IteratorPattern
{
    /// <summary>
    /// 聚合抽象类(个人感觉这个抽象类 可有可无)
    /// </summary>
    public abstract class Aggegate<T>
    {
        public abstract ConcreteIterator<T> CreateIterator();
    }
}
