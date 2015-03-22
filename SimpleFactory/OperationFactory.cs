using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleFactoryPattern
{
    /**
     * 操作工厂
     * */
    public class OperationFactory
    {
        public static Operation CreateOperate(string operate)
        {
            Operation oper = null;
            switch (operate)
            {
                case "+": oper = new OperationAdd();
                    break;
                case "-": oper = new OperationSub();
                    break;
                case "*": oper = new OperationMul();
                    break;
                case "/": oper = new OperationDiv();
                    break;
            }

            return oper;
        }
    }
}
