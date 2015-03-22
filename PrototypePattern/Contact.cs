using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrototypePattern
{   
    /// <summary>
    ///这个是人的联系方式类  主要是用此类的引用类型特点来说明深浅复制 
    /// </summary>
    public class Contact:ICloneable
    {
        /// <summary>
        /// 邮箱
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// 家庭地址
        /// </summary>
        public string Adress { get; set; }

        /// <summary>
        /// 联系电话
        /// </summary>
        public string Telephone { get; set; }

        public object Clone()
        {
            return (Contact)this.MemberwiseClone();
        }
    }
}
