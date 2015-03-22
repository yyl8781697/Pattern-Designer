using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObserverPattern
{
    /// <summary>
    /// 主题对象的基类
    /// </summary>
    public abstract class Subject
    {
        /// <summary>
        /// 就一个提醒操作
        /// </summary>
        public abstract void Notify();

        /// <summary>
        /// 状态
        /// </summary>
        public string SubjectState { get; protected set; }

    }
}
