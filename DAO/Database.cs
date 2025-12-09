using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSB_2.DAO
{
    internal class Database
    {
        private readonly string mySqlConnection = "server=10.28.65.35;uid=root;pwd=root;database=gsb-2";
        public MySqlConnection GetConnection()
        {
            return new MySqlConnection(mySqlConnection);
        }
    }
}
