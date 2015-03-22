using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AdapterPattern
{
    /// <summary>
    /// 前锋
    /// </summary>
    public  class Center:Player
    {
        public Center(string name)
            : base(name)
        { 
            
        }

        /// <summary>
        /// 重写进攻的方法
        /// </summary>
        public override void Attack()
        {
            Console.WriteLine(string.Format("center{0}:attack", _name));
        }

        /// <summary>
        /// 重写防守的方法
        /// </summary>
        public override void Defense()
        {
            Console.WriteLine(string.Format("center{0}:defense", _name));
        }
    }
}
