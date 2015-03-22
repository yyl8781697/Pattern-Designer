using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MementoPattern
{
    /// <summary>
    /// 定义一个游戏角色类  里面有些属性需要保存
    /// </summary>
    public class GameRole
    {
        #region 角色的一些属性
        /// <summary>
        /// 游戏者姓名
        /// </summary>
        public string Name { get; private set; }

        /// <summary>
        /// 攻击力
        /// </summary>
        public int Attack { get; private set; }

        /// <summary>
        /// 防守力
        /// </summary>
        public int Defense { get; private set; }

        /// <summary>
        /// 气血量
        /// </summary>
        public int Blood { get; private set; }

        /// <summary>
        /// 魔法量
        /// </summary>
        public int Magic { get; private set; }

        /// <summary>
        /// 经验值
        /// </summary>
        public int Experience { get;private set; }
        #endregion

        /// <summary>
        /// 初始化一个角色信息
        /// </summary>
        /// <param name="name"></param>
        /// <param name="attack"></param>
        /// <param name="defense"></param>
        /// <param name="blood"></param>
        /// <param name="magic"></param>
        /// <param name="experience"></param>
        public GameRole(string name, int attack, int defense,int blood, int magic, int experience)
        {
            this.Name = name;
            this.Attack = attack;
            this.Defense = defense;
            this.Blood = blood;
            this.Magic = magic;
            this.Experience = experience;
        }

        /// <summary>
        /// 存档 把当前的信息存储下来
        /// </summary>
        /// <returns></returns>
        public Memento Archive()
        {
            return new Memento
            {
                Attack = this.Attack,
                Defense = this.Defense,
                Blood = this.Blood,
                Experience = this.Experience,
                Magic = this.Magic
            };
        }

        /// <summary>
        /// 读取一个存档
        /// </summary>
        /// <param name="memento"></param>
        public void Read(Memento memento)
        {
            this.Attack = memento.Attack;
            this.Defense = memento.Defense;
            this.Blood = memento.Blood;
            this.Magic = memento.Magic;
            this.Experience = memento.Experience;
        }

        /// <summary>
        /// 战斗 
        /// </summary>
        /// <returns>赢了返回true，输了返回false 会减血和蓝</returns>
        public bool Fight()
        {
            Random r = new Random();
            if (r.Next(0, 100) > 50)
            {
                //赢了
                this.Attack += 5;
                this.Defense += 1;
                this.Experience += 100;
                return true;
            }
            else {
                //输掉了
                this.Blood = 1;
                this.Magic = 1;
                return false;
            }
        }

        /// <summary>
        /// 查看当前的角色信息
        /// </summary>
        public void DisplayInfo()
        {
            Console.WriteLine("姓名:{0}", this.Name);
            Console.WriteLine("攻击力:{0}", this.Attack);
            Console.WriteLine("防守力:{0}", this.Defense);
            Console.WriteLine("血量:{0}", this.Blood);
            Console.WriteLine("魔法值:{0}", this.Magic);
            Console.WriteLine("经验值:{0}\r\n", this.Experience);
        }
    }
}
