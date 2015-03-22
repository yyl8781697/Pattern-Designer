using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StatePattern
{
    /// <summary>
    /// 上午的状态
    /// </summary>
    public class ForenoonState : State
    {
        public override void WriteProgram(Work work)
        {
            if (work.Hour < 11)
            {
                Console.WriteLine("当前时间是{0}，精神百倍的工作",work.Hour);
            }
            else {
                //如果过了12点 则设置一个中午的状态
                work.SetState(new NoonState());
                work.WriteProgram();
            }
        }
    }

    /// <summary>
    /// 中午的状态
    /// </summary>
    public class NoonState : State
    {
        public override void WriteProgram(Work work)
        {
            if (work.Hour < 13)
            {
                Console.WriteLine("当前时间是{0}，有点累，休息一下",work.Hour);
            }
            else {
                work.SetState(new AfterNoonState());
                work.WriteProgram();
            }
        }
    }

    /// <summary>
    /// 下午的状态
    /// </summary>
    public class AfterNoonState : State
    {
        public override void WriteProgram(Work work)
        {
            if (work.Hour < 17)
            {
                Console.WriteLine("当前时间是{0}，还是要继续工作啊",work.Hour);
            }
            else {
                work.SetState(new EveningState());
                work.WriteProgram();
            }
        }
    }

    /// <summary>
    /// 傍晚的状态
    /// </summary>
    public class EveningState : State
    {
        public override void WriteProgram(Work work)
        {
            if (work.Hour < 19)
            {
                Console.WriteLine("当前时间是{0}，哎，再加点班",work.Hour);
            }
            else {
                Console.WriteLine("不早了，回家吃饭");
            }
        }
    }
}
