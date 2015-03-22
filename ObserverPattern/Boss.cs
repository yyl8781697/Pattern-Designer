using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObserverPattern
{
    public class Boss:Subject
    {
        /// <summary>
        /// 通知的事件类
        /// </summary>
        public delegate void MyEvent();

        /// <summary>
        /// 通知的事间
        /// </summary>
        /// <returns></returns>
        public event MyEvent Update;

        
        public void SetState(string state)
        {
            base.SubjectState = state;
        }

        /// <summary>
        /// 进行提醒操作
        /// </summary>
        public override void Notify()
        {
            this.Update();
        }
    }
}
