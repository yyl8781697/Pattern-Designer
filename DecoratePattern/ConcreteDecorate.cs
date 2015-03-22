using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DecoratePattern
{
    /// <summary>
    /// 用来集中装扮的
    /// </summary>
    public class ConcreteDecorate
    {
    }

    /// <summary>
    /// t恤
    /// </summary>
    public class TShirts : Finery
    {
        public override void Show()
        {
            Console.WriteLine("穿大t恤 ");
            base.Show();
        }
    }

    /// <summary>
    /// 垮裤
    /// </summary>
    public class BigTrouse : Finery
    {
        public override void Show()
        {
            Console.WriteLine("垮裤 ");
            base.Show();
        }
    }

    /// <summary>
    /// 破球鞋
    /// </summary>
    public class WearSneakers : Finery
    {
        public override void Show()
        {
            Console.WriteLine("破球鞋 ");
            base.Show();
        }
    }

    /// <summary>
    /// 穿西装
    /// </summary>
    public class WearSuit:Finery
    {
        public override void Show()
        {
            Console.WriteLine("穿西装");
            base.Show();
        }
    }

    /// <summary>
    /// 领带
    /// </summary>
    public class WearTie : Finery
    {
        public override void Show()
        {
            Console.WriteLine("带领带");
            base.Show();
        }
    }


}
