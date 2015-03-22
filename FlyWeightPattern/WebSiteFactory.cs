using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;

namespace FlyWeightPattern
{
    /// <summary>
    /// 享元的工厂 在这里用来分发网站
    /// </summary>
    public class WebSiteFactory
    {
        private Hashtable _webTable = new Hashtable();

        /// <summary>
        /// 得到享元
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public WebSite GetFlyWeight(string type)
        {
            if (!this._webTable.ContainsKey(type))
            {
                this._webTable.Add(type, new ConcreteWebSite(type));
            }
            return this._webTable[type] as WebSite;
        }
    }
}
