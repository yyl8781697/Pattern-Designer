using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryPattern
{
    /// <summary>
    /// 
    /// </summary>
    public interface IDataBase
    {
        /// <summary>
        /// 执行SQL 增删改
        /// </summary>
        /// <param name="sql"></param>
        void Exectue(string sql);

        /// <summary>
        /// 查询
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        int Select(string sql);
    }


    /// <summary>
    /// ORLACLE数据库的接口
    /// </summary>
    public class OracleDataBase : IDataBase
    {
        public void Exectue(string sql)
        {
            Console.WriteLine("执行了oracle的SQL");
        }

        public int Select(string sql)
        {
            Console.WriteLine("执行了oracle的查询");
            return 0;
        }
    }

    /// <summary>
    /// SqlServer数据库的接口
    /// </summary>
    public class SqlServerDataBase : IDataBase
    {
        public void Exectue(string sql)
        {
            Console.WriteLine("执行了SqlServer的SQL");
        }

        public int Select(string sql)
        {
            Console.WriteLine("执行了SqlServer的查询");
            return 0;
        }
    }


    /// <summary>
    /// MySql数据库的接口
    /// </summary>
    public class MySqlDataBase : IDataBase
    {
        public void Exectue(string sql)
        {
            Console.WriteLine("执行了MySql的SQL");
        }

        public int Select(string sql)
        {
            Console.WriteLine("执行了MySql的查询");
            return 0;
        }
    }
}
