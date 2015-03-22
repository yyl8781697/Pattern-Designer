using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObserverPattern
{
    /// <summary>
    /// 
    /// </summary>
    public class Scheme
    {
         /// <summary>
        /// 观察的对象
        /// </summary>
        public Subject subject;

        public Scheme(Subject subject)
        {
            this.subject = subject; 
        }

        /// <summary>
        /// 要做的动作
        /// </summary>
        public void GivePlne()
        {
            Console.WriteLine("老板因为{0}，我要策划一个方案了", this.subject.SubjectState);
        }
    }
}
