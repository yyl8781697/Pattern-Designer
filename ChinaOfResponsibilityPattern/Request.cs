using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChinaOfResponsibilityPattern
{
    /// <summary>
    /// 申请单的信息
    /// </summary>
    public class Request
    {
        /// <summary>
        /// 申请的类别
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// 申请的内容
        /// </summary>
        public string Content { get; set; }

        /// <summary>
        /// 申请的数量
        /// </summary>
        public int Number { get; set; }
    }
}
