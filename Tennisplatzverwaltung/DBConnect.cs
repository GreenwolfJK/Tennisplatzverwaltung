using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Tennisplatzverwaltung_Brockwitz
{
    class DBConnect
    {
        MySqlConnection connection = null;
        private String myConnectionString = "SERVER=localhost;" +
                                            "DATABASE=schlegel;" +
                                            "UID=schlegel;" +
                                            "PASSWORD=InKo-5509;";

        public DBConnect()
        {
            connection = new MySqlConnection(myConnectionString);
        }

        public bool openDatabase()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch (Exception e1)
            {
                Console.WriteLine(e1.Message);
                return false;
            }
        }

        public MySqlDataReader executeQuery(String sql)
        {
            MySqlCommand command = connection.CreateCommand();
            command.CommandText = sql;
            MySqlDataReader reader;
            reader = command.ExecuteReader();
            return reader;
        }

        public bool closeDatabase()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (Exception e2)
            {
                Console.WriteLine(e2.Message);
                return false;
            }
        }
    }
}
