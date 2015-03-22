using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FlyWeightPattern
{
    /// <summary>
    /// 网站的用户账号
    /// </summary>
    public class User
    {
        public User(string name)
        {
            this.Name = name;
        }

        public string Name { get; set; }
    }
}
