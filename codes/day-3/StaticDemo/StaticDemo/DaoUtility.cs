using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticDemo
{
    static class DaoUtility
    {
        static string dbConnectionString;
        static DaoUtility()
        {
            dbConnectionString = "server=;database=;uid=;pwd=;";
        }
        public static string GetConnection
        {
            get => dbConnectionString;
        }
        public static void OpenConnection()
        {

        }
        public static void CloseConnection()
        {

        }
    }

    //class X : DaoUtility
    //{
    //    public X() { }
    //}
}
