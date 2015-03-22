using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VisitorPattern
{
    /// <summary>
    /// 女人
    /// </summary>
    public class Woman:Person
    {
        public override void Accept(Visitor visitor)
        {
            visitor.GetWomanConclusion(this);
        }
    }
}
