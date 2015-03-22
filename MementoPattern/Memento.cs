using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MementoPattern
{
    /// <summary>
    /// 存档信息
    /// </summary>
    public class Memento
    {
        /// <summary>
        /// 攻击力
        /// </summary>
        public int Attack { get; set; }

        /// <summary>
        /// 防守力
        /// </summary>
        public int Defense { get; set; }

        /// <summary>
        /// 气血量
        /// </summary>
        public int Blood { get; set; }

        /// <summary>
        /// 魔法量
        /// </summary>
        public int Magic { get; set; }

        /// <summary>
        /// 经验值
        /// </summary>
        public int Experience { get; set; }
    }
}
