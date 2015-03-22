using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DecoratePattern
{
    /// <summary>
    /// Person类  相当于Compoent
    /// </summary>
    public class Person
    {
        private string _name;

        public Person()
        { 
        
        }

        public Person(string name)
        {
            this._name = name;
        }

        public virtual void Show()
        {
            Console.WriteLine("装扮的{0}", this._name);
        }
    }
}
