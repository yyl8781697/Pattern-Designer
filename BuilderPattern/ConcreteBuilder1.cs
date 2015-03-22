using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BuilderPattern
{
    public class ConcreteBuilder1:Builder
    {
        private Product product = new Product();

        /// <summary>
        /// 构建A部件
        /// </summary>
        public override void BuildPartA()
        {
            this.product.Add("a");
        }

        /// <summary>
        /// 构建B部件
        /// </summary>
        public override void BuildPartB()
        {
            this.product.Add("b");
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
