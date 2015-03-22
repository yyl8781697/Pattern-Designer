using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TemplateMethodPattern
{
    /// <summary>
    /// 定义一个美国人
    /// </summary>
    public class American:Person
    {
        /// <summary>
        /// 覆写了父类  修改了实现的步骤
        /// </summary>
        /// <returns></returns>
        public override string SayWhat()
        {
            return "Hello World";
        }
    }
}
