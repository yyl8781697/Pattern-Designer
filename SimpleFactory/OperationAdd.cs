using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleFactoryPattern
{
    /***
     * 加法操作
     * */
    public class OperationAdd:Operation
    {
        public override double GetResult()
        {
            return this.NumberA + this.NumberB;
        }
    }
}
