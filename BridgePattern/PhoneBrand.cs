using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BridgePattern
{
    /// <summary>
    /// 手机牌子
    /// </summary>
    public abstract class PhoneBrand
    {
        /// <summary>
        /// 牌子的名称
        /// </summary>
        protected string brandName;

        /// <summary>
        /// 手机软件
        /// </summary>
        protected List<PhoneSoft> phoneSoftList=new List<PhoneSoft>();

        /// <summary>
        /// 当前的软件
        /// </summary>
        protected PhoneSoft currentPhoneSoft;

        public PhoneSoft PhoneSoft
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        /// <summary>
        /// 安装软件
        /// </summary>
        /// <param name="phoneSoft"></param>
        public void SetUp(PhoneSoft phoneSoft)
        {
            this.currentPhoneSoft = phoneSoft;
            phoneSoftList.Add(phoneSoft);
        }

        public abstract void Run();
    }
}
