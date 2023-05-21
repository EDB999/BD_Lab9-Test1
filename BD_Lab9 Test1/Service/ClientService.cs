using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BD_Lab9_Test1.Service
{
    internal class ClientService
    {
        public DataTable OrderSalaryGroup(NpgsqlDataAdapter adapter, string connect)
        {
            var dt = new DataTable();

            using (NpgsqlConnection connection = new NpgsqlConnection(connect))
            {
                connection.Open();
                adapter = new NpgsqlDataAdapter(
                        @"SELECT public.""Accounts"".""Login_User"" AS Login, ""Password_User"" AS Password FROM public.""Accounts""
                        JOIN public.""Marks"" AS Account ON ""Accounts"".""ID_Account"" = public.""Marks"".""ID_Account""
                        GROUP BY public.""Accounts"".""Login_User"", ""Password_User"""
                        , connection
                );
                adapter.Fill(dt);
                connection.Close();
                Console.WriteLine("Запрос осуществлён");
            }
            return dt;
        }

        public DataTable OrderSalaryHaving(NpgsqlDataAdapter adapter, string connect)
        {
            DataTable dt = new DataTable();

            using (NpgsqlConnection connection = new NpgsqlConnection(connect))
            {
                connection.Open();

                adapter = new NpgsqlDataAdapter( 
                        @"SELECT public.""st_test"".""n"" AS Имя, ""s"" AS Фамилия, COUNT(""st_test"".""ID_ST"") AS id, ""p"" AS Отчество from public.""st_test""
                        JOIN public.""Posts&Salary"" AS студент ON ""студент"".""ID_Post"" = public.""st_test"".""ID_Post""
                        GROUP BY public.""st_test"".""n"", ""s"", ""p""
                        HAVING COUNT(3) > 0"
                        , connection
                );

                adapter.Fill(dt);

                connection.Close();

                Console.WriteLine("Запрос осуществлён");
            }
            return dt;
        }
    } 
}
