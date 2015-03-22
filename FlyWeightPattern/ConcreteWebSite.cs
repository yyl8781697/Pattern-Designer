using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FlyWeightPattern
{
    /// <summary>
    /// 具体的网站类
    /// </summary>
    public class ConcreteWebSite:WebSite
    {
        /// <summary>
        /// 网站分类
        /// </summary>
        private string _type;

        public ConcreteWebSite(string type)
        {
            this._type = type;
        }

        /// <summary>
        /// 重载抽象网站 
        /// </summary>
        /// <param name="user"></param>
        public override void Use(User user)
        {
            Console.WriteLine("{0}正在使用{1}网站", user.Name, this._type);
        }
    }
}
