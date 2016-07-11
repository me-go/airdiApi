using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Web;

namespace DapperApi.Data
{
    public class SqLiteBaseRepository
    {
        public static string DbFile
        {
            get
            {
                return System.Web.Hosting.HostingEnvironment.MapPath("~/Data/") + "AIRD.db";
            }
        }

        public static SQLiteConnection SimpleDbConnection()
        {
            return new SQLiteConnection("Data Source=" + DbFile);
        }
    }
}