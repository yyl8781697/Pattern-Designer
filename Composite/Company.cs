using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Composite
{
    /// <summary>
    /// 公司类 组合的基本单位
    /// </summary>
    public abstract class Company
    {
        protected string _name;

        public Company(string name)
        {
            this._name = name;
        }

        public abstract void Add(Company company);

        public abstract void Remove(Company company);

        public abstract void Display(int dept);

        public abstract void LineOfDuty();

    }
}
