using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MediatorPattern
{
    /// <summary>
    /// 联合国安全组织
    /// </summary>
    public class UnitedNationSecurity:UnitedNations
    {
        /// <summary>
        /// 美国
        /// </summary>
        public USA usa { get; set; }

        /// <summary>
        /// 伊拉克
        /// </summary>
        public Iraq iraq { get; set; }

        public override void Declare(string message, Country country)
        {
            
            if (country is USA)
            {
                iraq.GetMessage(message);
            }

            if (country is Iraq)
            {
                usa.GetMessage(message);
            }
        }
    }
}
