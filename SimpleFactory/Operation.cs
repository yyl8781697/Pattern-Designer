using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleFactoryPattern
{
    
    public class Operation
    {
        public int NumberA { get; set; }
        public int NumberB{get;set;}

        public virtual double GetResult()
        {
            double result = 0;
            return result;
        }
    }
}
