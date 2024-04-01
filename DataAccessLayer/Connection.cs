using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.IO;

namespace DataAccessLayer
{
    public class Connection
    {
        private static string GetDatabasePath()
        {

            string appDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string dbPath = Path.Combine(appDirectory, "db.accdb");
            return dbPath;
        }

        public OleDbConnection ConnectionOpen()
        {
            string connectionString = $@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={GetDatabasePath()}";
            OleDbConnection connection = new OleDbConnection(connectionString);
            connection.Open();
            return connection;

        }
    }
}
/*OleDbConnection connection = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\mertr\\Desktop\\db.accdb;");
            connection.Open();
            return connection;*/