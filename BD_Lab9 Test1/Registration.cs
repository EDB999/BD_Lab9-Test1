using System;
using Npgsql;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Data.SqlClient;
using System.Net.Http.Headers;

namespace BD_Lab9_Test1
{
    public partial class Registration : Form
    {
        bool tr = true;
        DataBase database = new DataBase();
        public Registration()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void checkPassView_CheckedChanged(object sender, EventArgs e)
        {
            if (tr)
            {
                textBoxPassword.UseSystemPasswordChar = false;
                tr = false;
            }
            else
            {
                textBoxPassword.UseSystemPasswordChar = true;
                tr = true;
            }

        }

        private void buttonSignIn_Click(object sender, EventArgs e)
        {
            var LoginUser = textBoxLogin.Text; 
            var PasswordUser = textBoxPassword.Text;
            var role = ComboBoxRole.Text;

            NpgsqlDataAdapter adapter = new NpgsqlDataAdapter();
            DataTable dt = new DataTable();

            string querystring = $"SELECT \"ID_Account\", \"Login_User\", \"Password_User\" FROM \"Accounts\" WHERE \"Login_User\" = '{LoginUser}' and \"Password_User\" = '{PasswordUser}'";

            NpgsqlCommand cmd = new NpgsqlCommand(querystring, database.getConnection());

            adapter.SelectCommand = cmd;
            adapter.Fill(dt);
            
            if (role == "Студент" & dt.Rows.Count == 1)
            {
                MessageBox.Show("Login successfully completed by Student!", "Entering!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                User_Student_ form_stud = new User_Student_();
                this.Hide();
                form_stud.Show();
            }
            else if (role == "Преподаватель" & dt.Rows.Count == 1)
            {
                MessageBox.Show("Login successfully completed by Lector!", "Entering!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LectorForm form_lector = new LectorForm();
                this.Hide();
                form_lector.Show();
            }
            else if (role == "Администратор" & dt.Rows.Count == 1)
            {
                MessageBox.Show("Login successfully completed by Administrator", "Entering!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Form1 form_admin = new Form1();
                this.Hide();
                form_admin.Show();
            }
        }

        private void linkLabelSignUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegAccount reg_acc = new RegAccount();
            reg_acc.Show();
            this.Hide();
        }
    }
}
