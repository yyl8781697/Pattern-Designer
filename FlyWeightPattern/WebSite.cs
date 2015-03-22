using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FlyWeightPattern
{
    /// <summary>
    /// 
    /// </summary>
    public abstract class WebSite
    {
        /// <summary>
        /// 网站的使用
        /// </summary>
        public abstract void Use(User user);
    }
}
