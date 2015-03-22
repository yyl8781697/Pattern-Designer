using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AdapterPattern
{
    /// <summary>
    /// 球员类
    /// </summary>
    public class Player
    {
        //球员的名字
        protected string _name = string.Empty;

        public Player(string name)
        {
            this._name = name;
        }

        /// <summary>
        /// 进攻
        /// </summary>
        public virtual void Attack()
        {
            Console.WriteLine(string.Format("{0}:Attack", _name));
        }

        /// <summary>
        /// 防守
        /// </summary>
        public virtual void Defense()
        {
            Console.WriteLine(string.Format("{0}:Defense", _name));
        }
    }
}
