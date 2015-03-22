using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TemplateMethodPattern
{
    /// <summary>
    /// 定义一个人的模板类
    /// </summary>
    public class Person
    {
        /// <summary>
        /// 人 都能问好
        /// </summary>
        public void SayHello()
        {
            Console.WriteLine(SayWhat());
        }

        /// <summary>
        /// 说了什么 虚方法 供子类修改
        /// </summary>
        /// <returns></returns>
        public virtual string SayWhat()
        {
            return "";
        }
    }
}
