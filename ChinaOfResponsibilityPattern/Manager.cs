using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChinaOfResponsibilityPattern
{
    /// <summary>
    /// 管理者 抽象类
    /// </summary>
    public abstract class Manager
    {
        /// <summary>
        /// 管理者的姓名
        /// </summary>
        protected string name;

        /// <summary>
        /// 上一级
        /// </summary>
        protected Manager superior;

        public Manager(string name)
        {
            this.name = name;
        }

        public void SetSuperior(Manager superior)
        {
            this.superior = superior;
        }

        /// <summary>
        /// 执行申请程序
        /// </summary>
        /// <param name="requestType"></param>
        public abstract void RequestApplication(Request request);


    }
}
