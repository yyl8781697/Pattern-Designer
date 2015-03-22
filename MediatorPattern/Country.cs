using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MediatorPattern
{
    /// <summary>
    /// 国家类
    /// </summary>
    public class Country
    {
        /// <summary>
        /// 联合国组织
        /// </summary>
        protected UnitedNations unitedNations;

        protected Country(UnitedNations unitedNations)
        {
            this.unitedNations = unitedNations;
        }
    }
}
