using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MementoPattern
{
    /// <summary>
    /// 存储存档信息 
    /// </summary>
    public class CareTaker
    {
        /// <summary>
        /// 最多可以存储4个进度
        /// </summary>
        private Memento[] memento = new Memento[4];

        public Memento this[int index]
        {
            get
            {
                if (index > 3)
                {
                    //超过最大存储直接返回null
                    return null;
                }
                else {
                    return this.memento[index];
                }
            }
            set
            {
                //在有效范围内才进行存储
                if (index <= 3)
                {
                    this.memento[index] = value;
                }
            }
        }
    }
}
