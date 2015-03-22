using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleFactoryPattern
{
    /***
     * 除法操作
     * */
    public class OperationDiv:Operation
    {
        public override double GetResult()
        {
            if (this.NumberB == 0)
                throw new Exception("除数不能为0");
            return this.NumberA / this.NumberB;
        }
    }
}
