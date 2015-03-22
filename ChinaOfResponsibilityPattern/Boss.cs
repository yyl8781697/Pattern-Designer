using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChinaOfResponsibilityPattern
{
    /// <summary>
    /// 大老板
    /// </summary>
    public class Boss:Manager
    {
        public Boss(string name) : base(name) { }

        /// <summary>
        /// 技术总监执行申请
        /// </summary>
        /// <param name="request"></param>
        public override void RequestApplication(Request request)
        {
            if (("请假".Equals(request.Type) && request.Number <= 10) || ("加薪".Equals(request.Type) && request.Number <= 1000))
            {
                Console.WriteLine("{0}：数量{1}被{2}批准了", request.Content, request.Number, base.name);
            }
            else
            {
                Console.WriteLine("{0}：数量{1}被{2}不批准", request.Content, request.Number, base.name);
            }
        }
    }
}
