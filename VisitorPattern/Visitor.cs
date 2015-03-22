using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VisitorPattern
{
    /// <summary>
    /// 访问者
    /// </summary>
    public abstract class Visitor
    {
        /// <summary>
        /// 得到男人的结论
        /// </summary>
        /// <param name="man"></param>
        public abstract void GetManConclusion(Man man);


        /// <summary>
        /// 得到女人的结论
        /// </summary>
        /// <param name="woman"></param>
        public abstract void GetWomanConclusion(Woman woman);
    }
}
