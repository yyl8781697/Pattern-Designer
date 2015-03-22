using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AdapterPattern
{
    /// <summary>
    /// 一个中英文的翻译 适配器
    /// </summary>
    public class ChinaAdapter:Player
    {
        /// <summary>
        /// 定义一个中国的中锋
        /// </summary>
        private ChinaPlayer _chinaPlayer;

        public ChinaAdapter(ChinaPlayer chinaPlayer)
            : base(chinaPlayer.Name)
        {
            this._chinaPlayer = chinaPlayer;
        }

        /// <summary>
        /// 重写进攻的方法
        /// </summary>
        public override void Attack()
        {
            this._chinaPlayer.进攻();
        }

        /// <summary>
        /// 重写防守的方法
        /// </summary>
        public override void Defense()
        {
            this._chinaPlayer.防守();
        }
    }
}
