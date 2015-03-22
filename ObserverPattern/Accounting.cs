using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObserverPattern
{
    /// <summary>
    /// 观察着 会计
    /// </summary>
    public class Accounting
    {
        /// <summary>
        /// 观察的对象
        /// </summary>
        public Subject subject;

        public Accounting(Subject subject)
        {
            this.subject = subject; 
        }

        /// <summary>
        /// 要做的动作
        /// </summary>
        public void GiveMenoy()
        {
            Console.WriteLine("老板因为{0}，我要计算给钱了", this.subject.SubjectState);
        }

    }
}
