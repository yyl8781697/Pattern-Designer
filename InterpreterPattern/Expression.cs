using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InterpreretPattern
{
    /// <summary>
    /// 定义表达式  
    /// </summary>
    public abstract class Expression
    {
        /// <summary>
        /// 解释器
        /// </summary>
        /// <param name="context"></param>
        public void Interpreter(PlayContext context)
        {
            if (string.IsNullOrEmpty(context.PlayText))
            {
                return;
            }
            else {
                //取第一位
                string playKey = context.PlayText.Substring(0, 1);
                //去掉当前的音符
                context.PlayText = context.PlayText.Substring(2);
                double palyValue = Convert.ToDouble(context.PlayText.Substring(0, context.PlayText.IndexOf(" ")));
                context.PlayText = context.PlayText.Substring(context.PlayText.IndexOf(" ") + 1);

                this.Excute(playKey, palyValue);
            }
        }

        public abstract void Excute(string key, double value);
    }
}
