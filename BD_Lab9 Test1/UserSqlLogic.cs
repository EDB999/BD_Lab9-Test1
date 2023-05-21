using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;

namespace BD_Lab9_Test1
{
    internal class UserSqlLogic
    {

        public static DataTable ViewUserData(string connect, NpgsqlDataAdapter adapter)
        {
            DataTable dt = new DataTable();

            using (NpgsqlConnection connection = new NpgsqlConnection(connect))
            {
                connection.Open();
                adapter = new NpgsqlDataAdapter("SELECT * FROM \"Marks\"", connection);
                adapter.Fill(dt);
                connection.Close();
                Console.WriteLine("Запрос выполнен");
            }
            return dt;
        }
        
    }
}
