using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrototypePattern
{
    /// <summary>
    /// 人的实体类 用来克隆复制
    /// </summary>
    public class Person:ICloneable
    {
        /// <summary>
        /// 年龄
        /// </summary>
        public int Age { get; set; }

        /// <summary>
        /// 姓名
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 联系方式
        /// </summary>
        public Contact contact { get; set; }

        public Person()
        { 
        
        }

        /// <summary>
        /// 私有的构造  用于深复制联系方式
        /// </summary>
        /// <param name="contact"></param>
        private Person(Contact contact)
        {
            this.contact = contact;
        }

        /// <summary>
        /// 设置联系方式
        /// </summary>
        /// <param name="email"></param>
        /// <param name="address"></param>
        /// <param name="telephone"></param>
        public void SetContact(string email, string address, string telephone)
        {
            this.contact = new Contact
            {
                Email = email,
                Adress = address,
                Telephone = telephone
            };
        }

        public void Display()
        {
            Console.WriteLine("姓名：{0}，年龄：{1}", this.Name, this.Age);
            Console.WriteLine("联系方式：{0},{1},{2}", this.contact.Email, this.contact.Adress, this.contact.Telephone);
        }


        /// <summary>
        /// 克隆 深度复制
        /// </summary>
        /// <returns></returns>
        public object Clone()
        {
            Person person = new Person(this.contact);
            person.Age = this.Age;
            person.Name = this.Name;
            return person;
            //return this.MemberwiseClone();
        }



        
    }
}
