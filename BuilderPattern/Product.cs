using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BuilderPattern
{
    /// <summary>
    /// 产品类 用于构建的产品
    /// </summary>
    public class Product
    {
        private IList<string> list = new List<string>();

        /// <summary>
        /// 产品添加一个部件
        /// </summary>
        /// <param name="part"></param>
        public void Add(string part)
        {
            this.list.Add(part);
        }

        /// <summary>
        /// 产品的展示
        /// </summary>
        public void Show()
        {
            foreach (string part in list)
            {
                Console.WriteLine(part);
            }
        }
    }
}
