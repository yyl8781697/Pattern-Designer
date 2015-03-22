using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryPattern
{
    public class DataAccess
    {
        private static readonly string db = "SqlServer";

        public static IDataBase CreateDataBase()
        {
            IDataBase database;
            switch (db)
            {
                case "Oracle": database = new OracleDataBase();
                    break;
                case "SqlServer": database = new SqlServerDataBase();
                    break;
                case "MySql": database = new MySqlDataBase();
                    break;
                default: database = new SqlServerDataBase();
                    break;
            }

            return database;
        }
    }
}
