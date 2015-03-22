using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VisitorPattern
{
    /// <summary>
    /// 详细的访问者  这里主要放置一些状态
    /// </summary>
    class ConcreteVisitor
    {
    }

    /// <summary>
    /// 成功状态的对比
    /// </summary>
    public class Success : Visitor
    {
        public override void GetManConclusion(Man man)
        {
            Console.WriteLine("男人成功时，背后总有一个伟大的女人");
        }

        public override void GetWomanConclusion(Woman woman)
        {
            Console.WriteLine("女人成功时，背后总有一个不争气的难人");
        }
    }

    /// <summary>
    /// 失败状态的对比
    /// </summary>
    public class Fail : Visitor
    {
        public override void GetManConclusion(Man man)
        {
            Console.WriteLine("男人失败时，闷头喝酒，谁也不理");
        }

        public override void GetWomanConclusion(Woman woman)
        {
            Console.WriteLine("女人失败时，泪眼汪汪，谁也劝不了");
        }
    }

    public class Love : Visitor
    {
        public override void GetManConclusion(Man man)
        {
            Console.WriteLine("男人恋爱时，凡是不懂也要装懂");
        }

        public override void GetWomanConclusion(Woman woman)
        {
            Console.WriteLine("女人恋爱时，凡事懂也装不懂");
        }
    }
}
