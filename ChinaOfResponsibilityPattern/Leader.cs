using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChinaOfResponsibilityPattern
{
    /// <summary>
    /// 小组长
    /// </summary>
    public class Leader:Manager
    {
        public Leader(string name)
            : base(name)
        { }

        /// <summary>
        /// 小组长执行申请
        /// </summary>
        /// <param name="request"></param>
        public override void RequestApplication(Request request)
        {
            if ("请假".Equals(request.Type) && request.Number <= 2)
            {
                Console.WriteLine("{0}：数量{1}被{2}批准了", request.Content, request.Number, base.name);
            }
            else {
                base.superior.RequestApplication(request);
            }
        }
    }
}
