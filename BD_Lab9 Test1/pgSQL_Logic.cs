using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BD_Lab9_Test1
{
    internal class pgSQL_Logic
    {
        public static void CreateBD(string NameBD, string connect)
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(connect))
            {
                connection.Open();
                string output = "CREATE DATABASE " + NameBD;
                NpgsqlCommand command = new NpgsqlCommand(output, connection);
                command.ExecuteNonQuery();
                Console.WriteLine("База данных успешно создана:\n" + output + "\n");
            }
        }

        public static void CreateTable(string NTable, string connect)
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(connect))
            {
                connection.Open();
                string output = "CREATE TABLE " + NTable + "()";
                NpgsqlCommand command = new NpgsqlCommand(output, connection);
                command.ExecuteNonQuery();
                Console.WriteLine("Таблица успешно создана:\n" + output + "\n");
            }
        }
        public static void AddRow(string NTable, string NColumn, string DataType, string connect)
        {

            using (NpgsqlConnection connection = new NpgsqlConnection(connect))
            {
                connection.Open();
                Console.WriteLine("Задайте название столбца");
                string output = "ALTER TABLE " + NTable + " ADD " + NColumn + " " + DataType;
                NpgsqlCommand command = new NpgsqlCommand(output, connection);
                command.ExecuteNonQuery();
                Console.WriteLine("Столбец успешно добавлен:\n" + output + "\n");
            }
        }

        public static void DropRow(string NTable, string NColumn, string connect)
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(connect))
            {
                connection.Open();
                Console.WriteLine("Задайте название столбца");
                string output = "ALTER TABLE " + NTable + " DROP " + NColumn;
                NpgsqlCommand command = new NpgsqlCommand(output, connection);
                command.ExecuteNonQuery();
                Console.WriteLine("Столбец успешно убран:\n" + output + "\n");
            }
        }

        // Tusk 2

        public static DataTable ViewClientData(string connect, NpgsqlDataAdapter adapter)
        {
            DataTable dt = new DataTable();

            using (NpgsqlConnection connection = new NpgsqlConnection(connect))
            {
                connection.Open();
                adapter = new NpgsqlDataAdapter("select * FROM \"Accounts\"", connection);
                //adapter = new NpgsqlDataAdapter("select * FROM st_test", connection);
                adapter.Fill(dt);
                connection.Close();
                Console.WriteLine("Запрос выполнен");
            }
            return dt;
        }

        public static void AddClient(string Login, string Password, NpgsqlCommand command, string connect)
        {
            if (Login == "" || Password == "")
            {
                Console.WriteLine("Something wrong...");
                return;
            }
            using (NpgsqlConnection connection = new NpgsqlConnection(connect))
            {
                command = new NpgsqlCommand("INSERT INTO \"Accounts\" (\"Login_User\", \"Password_User\") values (@Login, @Password)", connection);
                connection.Open();
                command.Parameters.AddWithValue("@Login", Login);
                command.Parameters.AddWithValue("@Password", Password);
                command.ExecuteNonQuery();
                connection.Close();
                Console.WriteLine("User added");
            }
        }

        public static void DeleteClient(string id, string connect, NpgsqlCommand command)
        {
            if (id == null)
            {
                Console.WriteLine("Something wrong...");
                return;
            }

            using (NpgsqlConnection connection = new NpgsqlConnection(connect))
            {
                command = new NpgsqlCommand("DELETE FROM \"Accounts\" where \"ID_Account\" = @id", connection);
                connection.Open();
                command.Parameters.AddWithValue("@id", int.Parse(id));
                command.ExecuteNonQuery();
                connection.Close();
                Console.WriteLine("User deleted");
            }
        }
        public static void TruncateTable(string connect, NpgsqlCommand command)
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(connect))
            {
                command = new NpgsqlCommand("TRUNCATE \"Accounts\" restart identity", connection);
                connection.Open();
                command.ExecuteNonQuery();
                Console.WriteLine("Table truncated");
            }
        }


        public static void UpdateClient(string Login, string Password, string id, NpgsqlCommand command, string connect)
        {
            if (Login == "" || Password == "")
            {
                Console.WriteLine("Something wrong...");
                return;
            }
            using (NpgsqlConnection connection = new NpgsqlConnection(connect))
            {
                command = new NpgsqlCommand("UPDATE \"Accounts\" set \"Login_User\" = @Login, \"Password_User\" = @Password WHERE @id = \"ID_Account\"", connection);
                connection.Open();
                command.Parameters.AddWithValue("@id", int.Parse(id));
                command.Parameters.AddWithValue("@Login", Login);
                command.Parameters.AddWithValue("@Password", Password);
                command.ExecuteNonQuery();
                connection.Close();
                Console.WriteLine("User updated");
            }
        }









    }
}
