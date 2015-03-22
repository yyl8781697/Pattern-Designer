using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TemplateMethodPattern
{
    /// <summary>
    /// 定义了一个中国人
    /// </summary>
    public class Chinese:Person
    {
        public override string SayWhat()
        {
            return "你好，世界";
        }
    }
}
