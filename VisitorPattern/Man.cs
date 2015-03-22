using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VisitorPattern
{
    /// <summary>
    /// 男人 接收一个访问者  然后进行相应的操作
    /// </summary>
   public class Man:Person
    {
        public override void Accept(Visitor visitor)
        {
            visitor.GetManConclusion(this);
        }
    }
}
