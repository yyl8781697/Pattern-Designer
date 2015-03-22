using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern
{
    public interface IFactory
    {
        LeiFeng CreateLeiFeng();
    }

    public class UndergraduteFactory:IFactory{
        public LeiFeng CreateLeiFeng()
        {
            return new Undergradute();
        }
    }

    public class VolunteerFactory : IFactory
    {
        public LeiFeng CreateLeiFeng()
        {
            return new Volunteer();
        }
    }
}
