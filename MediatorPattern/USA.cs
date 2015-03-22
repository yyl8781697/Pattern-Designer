using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MediatorPattern
{
    public class USA:Country
    {
        public USA(UnitedNations unitedNations)
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
            Console.WriteLine("美国收到消息：" + message);
        }
    }
}
