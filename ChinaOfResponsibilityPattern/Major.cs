using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChinaOfResponsibilityPattern
{
    /// <summary>
    /// 技术总监
    /// </summary>
    public class Major:Manager
    {
        public Major(string name)
            : base(name)
        { }

        /// <summary>
        /// 技术总监执行申请
        /// </summary>
        /// <param name="request"></param>
        public override void RequestApplication(Request request)
        {
            if (("请假".Equals(request.Type) && request.Number <= 5) || ("加薪".Equals(request.Type) && request.Number <= 300))
            {
                Console.WriteLine("{0}：数量{1}被{2}批准了", request.Content, request.Number, base.name);
            }
            else
            {
                base.superior.RequestApplication(request);
            }
        }
    }
}
