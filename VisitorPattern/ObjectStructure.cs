using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VisitorPattern
{
    /// <summary>
    /// 实体结构
    /// </summary>
    class ObjectStructure
    {
        public IList<Person> personList = new List<Person>();

        /// <summary>
        /// 附加一个
        /// </summary>
        /// <param name="person"></param>
        public void Attach(Person person)
        {
            this.personList.Add(person);
        }

        public void Detach(Person person)
        {
            this.personList.Remove(person);
        }

        /// <summary>
        /// 展示出来
        /// </summary>
        public void Display(Visitor visitor)
        {
            foreach (Person p in personList)
            {
                p.Accept(visitor);
            }
        }
    }
}
