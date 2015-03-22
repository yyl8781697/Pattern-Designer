using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AdapterPattern
{
    /// <summary>
    /// 中国的中锋 只会中文
    /// </summary>
    public class ChinaCenter:ChinaPlayer
    {


        public ChinaCenter(string name):base(name)
        {

        }

        /// <summary>
        /// 重写进攻的方法
        /// </summary>
        public override void 进攻()
        {
            Console.WriteLine(string.Format("中锋{0}:进攻", Name));
        }

        /// <summary>
        /// 重写防守的方法
        /// </summary>
        public override void 防守()
        {
            Console.WriteLine(string.Format("中锋{0}:防守", Name));
        }
    }
}
