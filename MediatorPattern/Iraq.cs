using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MediatorPattern
{
    public class Iraq:Country
    {
        public Iraq(UnitedNations unitedNations)
            : base(unitedNations)
        { }

        public void Declare(string message)
        {
            this.unitedNations.Declare(message, this);
        }

        /// <summary>
        /// 得到消息
        /// </summary>
        /// <param name="message"></param>
        public void GetMessage(string message)
        {
            Console.WriteLine("伊拉克收到消息：" + message);
        }
    }
}
