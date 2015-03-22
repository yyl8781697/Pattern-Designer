using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AdapterPattern
{
    /// <summary>
    /// 中国的球员类
    /// </summary>
    public class ChinaPlayer
    {
        //球员的名字
        public string Name{get;set;}

        public ChinaPlayer(string name)
        {
            this.Name = name;
        }

        /// <summary>
        /// 进攻
        /// </summary>
        public virtual void 进攻()
        {
            Console.WriteLine(string.Format("{0}:进攻", Name));
        }

        /// <summary>
        /// 防守
        /// </summary>
        public virtual void 防守()
        {
            Console.WriteLine(string.Format("{0}:防守", Name));
        }
    }
}
