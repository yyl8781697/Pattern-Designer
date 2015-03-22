using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MediatorPattern
{
    /// <summary>
    /// 联合国
    /// </summary>
    public abstract class UnitedNations
    {
        public abstract void Declare(string mesage, Country country);
    }
}
