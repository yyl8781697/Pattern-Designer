using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleFactoryPattern
{
    /***
     * 减法操作
     * */
    public class OperationSub : Operation
    {
        public override double GetResult()
        {
            return this.NumberA - this.NumberB;
        }
    }
}
