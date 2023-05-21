using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace BD_Lab9_Test1
{
    internal class RegAuthLogic
    {
        public string connection = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
        //public bool CreateAccount(string Email, string Password, string Login, string Number, string confirm_code)
        //{
        //    using (SqlConnection conn = new SqlConnection(connection))
        //    {
        //        conn.Open();

        //        SqlCommand exist_check1 = new SqlCommand("SELECT ID_stud FROM \"Students\" WHERE Number='" + Number + "'", conn);
        //        using (SqlDataReader er = exist_check1.ExecuteReader())
        //        {
        //            if (er.HasRows)
        //            {
        //                System.Windows.Forms.MessageBox.Show("Пользователь с данным номером телефона уже зарегестрирован!",
        //                    "Ошибка!", System.Windows.Forms.MessageBoxButtons.OK,
        //                    System.Windows.Forms.MessageBoxIcon.Error);
        //                return false;
        //            }
        //        }
        //        SqlCommand exist_check2 = new SqlCommand("SELECT ID_Account FROM \"Accounts\" WHERE Login='" + Login + "'", conn);
        //        using (SqlDataReader dr = exist_check2.ExecuteReader())
        //        {
        //            if (dr.HasRows)
        //            {
        //                System.Windows.Forms.MessageBox.Show("Пользователь с данным логином уже зарегестрирован!",
        //                    "Ошибка!", System.Windows.Forms.MessageBoxButtons.OK,
        //                    System.Windows.Forms.MessageBoxIcon.Error);
        //                return false;
        //            }
        //        }
        //        SqlCommand exist_check3 = new SqlCommand("SELECT ID_Account FROM \"Accounts\" WHERE Email='" + Email + "'", conn);
        //        using (SqlDataReader er = exist_check3.ExecuteReader())
        //        {
        //            if (er.HasRows)
        //            {
        //                System.Windows.Forms.MessageBox.Show("Пользователь с данным Email'ом уже зарегестрирован!",
        //                    "Ошибка!", System.Windows.Forms.MessageBoxButtons.OK,
        //                    System.Windows.Forms.MessageBoxIcon.Error);
        //                return false;
        //            }
        //        }

        //        conn.Close();
        //    }
        //    using (SqlConnection conn = new SqlConnection(connection))
        //    {
        //        conn.Open();

        //        SqlCommand query = new SqlCommand("SELECT ID_Stud FROM \"Students\" WHERE Number='" + Number + "'", conn);
        //        int userId = 0;

        //        using (SqlDataReader er = query.ExecuteReader())
        //        {
        //            bool success = er.Read();
        //            if (success)
        //            {
        //                userId = er.GetInt32(0);
        //            }
        //        }

        //        SqlCommand cmd1 = new SqlCommand("INSERT INTO \"Accounts\" (Email, Login, Number, Password, ID_Stud "
        //            + "VALUES (\'" + Email + "\', \'" + Login + "\', " + Number + ", " + Password + ", " + userId + ")", conn);

        //        cmd1.ExecuteNonQuery();
        //        conn.Close();
        //    }
        //    return true;
        //}
        //public int[] SignIn(string Login, string Password)
        //{
        //    int ID_Stud = -1, ID_Account = -1;

        //    using (SqlConnection conn = new SqlConnection(connection))
        //    {
        //        conn.Open();

        //        SqlCommand query1 = new SqlCommand("SELECT ID_Stud FROM \"Students\", \"Accounts\" WHERE (Accounts.Login='" + Login + "' AND " +
        //          "Accounts.Password='" + Password + "') OR (Students.Number='" + Login + "' AND Accounts.Password='" + Password + "')", conn);
        //        SqlCommand query2 = new SqlCommand("SELECT ID_Account FROM \"Accounts\" WHERE (Accounts.Login='" + Login + "' AND " +
        //          "Account.Password='" + Password + "') OR (Students.Number='" + Login + "' AND Accounts.Password='" + Password + "')", conn);

        //        using (SqlDataReader er = query1.ExecuteReader())
        //        {
        //            bool success = er.Read();
        //            if (success)
        //            {
        //                ID_Stud = er.GetInt32(0);
        //            }
        //        }
        //        using (SqlDataReader er = query2.ExecuteReader())
        //        {
        //            bool success = er.Read();
        //            if (success)
        //            {
        //                ID_Account = er.GetInt32(0);
        //            }
        //        }
        //        conn.Close();
        //    }
        //    return new int[] { ID_Account, ID_Stud };
        //}
    }
}
