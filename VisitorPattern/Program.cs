using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*********************************
 * Visitor Pattern（访问者模式）：表示一个作用于某个对象中各个元素的操作，
 * 他可以使你不改变这个元素类的前提下定义作用这些元素的新操作
 * 
 * 适用于数据结构相对稳定的系统（本例中的Person类型只有男人和女人  比较稳定）
 * *****************************/
namespace VisitorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //创建实体集
            ObjectStructure structure = new ObjectStructure();
            //添加男人和女人
            structure.Attach(new Man());
            structure.Attach(new Woman());

            //实例化一个成功的访问者类型
            Success success = new Success();
            structure.Display(success);

            //实例化一个失败的访问者类型
            Fail fail = new Fail();
            structure.Display(fail);

            //实例化一个恋爱的访问者类型
            Love love = new Love();
            structure.Display(love);

            Console.ReadKey();
        }
    }
}
