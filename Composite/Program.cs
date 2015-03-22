using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/**********************
 * Cmposite Pattern(组合模式)：将对象组合成树形结构以表示“部分-整体”的层次结构
 * 组合模式是的用户对单个对象和组合对象具有同一的使用性
 * ********************/

namespace Composite
{
    class Program
    {
        static void Main(string[] args)
        { 
            //在北京是总部 有人力资源和财务部 两大部门
            ConcreteCompany beijing = new ConcreteCompany("北京总部");
            beijing.Add(new HRDepartment("北京人力资源"));
            beijing.Add(new FinanceDepartment("北京财务部"));

            //在伤害是一个分公司  也有他的人力资源和财务部
            ConcreteCompany shanghai = new ConcreteCompany("上海分公司");
            shanghai.Add(new HRDepartment("上海人力资源"));
            shanghai.Add(new FinanceDepartment("上海财务部"));

            //在南京只是一个办事处  只有人力资源部
            ConcreteCompany nanjing = new ConcreteCompany("南京办事处");
            nanjing.Add(new HRDepartment("南京人力资源"));

            //在杭州也是一个办事处 也同时只有财务部
            ConcreteCompany hangzhou = new ConcreteCompany("杭州办事处");
            hangzhou.Add(new FinanceDepartment("杭州财务中心"));

            //南京和杭州离上海比较近  归属上海管
            shanghai.Add(nanjing);
            shanghai.Add(hangzhou);

            //当然了 上海分公司也是归属北京总部管的
            beijing.Add(shanghai);

            beijing.Display(2);
            beijing.LineOfDuty();

            Console.WriteLine("\r\n南京的招不到人，上海分公司将其解散了\r\n");
            shanghai.Remove(nanjing);

            beijing.Display(2);
            beijing.LineOfDuty();

            Console.Read();
        }
    }
}
