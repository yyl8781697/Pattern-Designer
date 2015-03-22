using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Composite
{
    public class ConcreteCompany:Company
    {
        private IList<Company> _children = new List<Company>();

        public ConcreteCompany(string name)
            : base(name)
        { }

        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="company"></param>
        public override void Add(Company company)
        {
            this._children.Add(company);
        }


        /// <summary>
        /// 移除一个公司
        /// </summary>
        /// <param name="company"></param>
        public override void Remove(Company company)
        {
            this._children.Remove(company);
        }
        /// <summary>
        /// 显示
        /// </summary>
        /// <param name="dept"></param>
        public override void Display(int dept)
        {
            Console.WriteLine(new String('-', dept)+base._name);

            foreach (Company company in this._children)
            {
                company.Display(dept+2);
            }
        }

        /// <summary>
        /// 所履行的职责
        /// </summary>
        public override void LineOfDuty()
        {
            foreach (Company company in this._children)
            {
                company.LineOfDuty();
            }
        }
    }
}
