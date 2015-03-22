using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StatePattern
{
    public class Work
    {
        private State current;

        public Work()
        {
            //初始化一个上午的状态
            this.current = new ForenoonState();
        }

        /// <summary>
        /// 定义一个小时的属性
        /// </summary>
        public int Hour { get; set; }

        /// <summary>
        /// 设置一个新的状态
        /// </summary>
        /// <param name="state"></param>
        public void SetState(State state)
        {
            this.current = state;
        }

        /// <summary>
        /// 写程序
        /// </summary>
        public void WriteProgram()
        {
            this.current.WriteProgram(this);
        }
    }
}
