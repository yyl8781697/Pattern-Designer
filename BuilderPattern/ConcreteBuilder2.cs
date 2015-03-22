using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BuilderPattern
{
    /// <summary>
    /// 详细的构造过程
    /// </summary>
    public class ConcreteBuilder2:Builder
    {
        private Product product = new Product();

        /// <summary>
        /// 构建x部件
        /// </summary>
        public override void BuildPartA()
        {
            this.product.Add("x");
        }

        /// <summary>
        /// 构建y部件
        /// </summary>
        public override void BuildPartB()
        {
            this.product.Add("y");
        }

        /// <summary>
        /// 得到构建后的产品
        /// </summary>
        /// <returns></returns>
        public override Product GetResult()
        {
            return this.product;
        }
    }
}
