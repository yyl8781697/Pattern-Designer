using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CommandPattern
{
    /// <summary>
    /// 服务员 记录着
    /// </summary>
    public class Waiter
    {
        private IList<Command> list = new List<Command>();

        /// <summary>
        /// 设置一个命名
        /// </summary>
        /// <param name="command"></param>
        public void SetCommand(Command command)
        {
            this.list.Add(command);
        }

        /// <summary>
        /// 取消该命令
        /// </summary>
        /// <param name="command"></param>
        public void CancelCommand(Command command)
        {
            this.list.Remove(command);
        }

        public void Execute()
        {
            foreach (Command command in list)
            {
                command.Excute();
            }
        }
    }
}
