using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Composite
{
    /// <summary>
    /// 财务部
    /// </summary>
    class FinanceDepartment:Company
    {
        /// <summary>
        /// 人力资源部
        /// </summary>
        /// <param name="name"></param>
        public FinanceDepartment(string name)
            : base(name)
        {}

        public override void Add(Company company)
        {
            //这里就什么都不用干了 为了保持方法的统一性
        }

        public override void Remove(Company company)
        {
            //这里就什么都不用干了 为了保持方法的统一性
        }


        public override void Display(int dept)
        {
            Console.WriteLine(new String('-', dept) + base._name);
        }

        /// <summary>
        /// 财务部
        /// </summary>
        public override void LineOfDuty()
        {
            Console.WriteLine("负责公司的收入支出");
        }
    }
}
