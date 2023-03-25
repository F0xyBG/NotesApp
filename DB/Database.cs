using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormDBConnect.DB
{
    internal class Database
    {
        static string myConnectionString = "server=localhost;uid=root;pwd=;database=it";
        public static MySqlConnection GetConnection()
        {
            MySqlConnection db = new MySqlConnection(myConnectionString);
            return db;
        }
    }
}
