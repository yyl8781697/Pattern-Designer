using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VisitorPattern
{
    /// <summary>
    /// 人物
    /// </summary>
    public abstract class Person
    {
        /// <summary>
        /// 接收一个访问者
        /// </summary>
        /// <param name="visitor"></param>
        public abstract void Accept(Visitor visitor);
    }
}
