using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleFactoryPattern
{
    /***
     * 乘法操作
     * */
    public class OperationMul:Operation
    {
        public override double GetResult()
        {
            return this.NumberA * this.NumberB;
        }
    }
}
