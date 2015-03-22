using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DecoratePattern
{
    /// <summary>
    /// 服饰类，用来生成Person
    /// </summary>
    public class Finery:Person
    {
        protected Person _person;

        /// <summary>
        /// 打扮
        /// </summary>
        /// <param name="compoent"></param>
        public void Decorate(Person compoent)
        {
            this._person = compoent;
        }

        public override void Show()
        {
            if (this._person != null)
            {
                this._person.Show();
            }
        }
    }
}
