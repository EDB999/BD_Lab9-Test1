
using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BD_Lab9_Test1
{
    public partial class RegAccount : Form
    {

        DataBase db = new DataBase();
        bool tr = true;
        public RegAccount()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void buttonRegAcc_Click(object sender, EventArgs e)
        {
            var Login_Reg = textBoxRegLogin.Text;
            var Password_Reg = textBoxRegPassword.Text;
            var ConfirmPassword_Reg = textBoxRegConfirmPassword.Text;
            string query = $"INSERT INTO \"Accounts\"(\"Login_User\", \"Password_User\") values('{Login_Reg}','{Password_Reg}')";
            NpgsqlCommand cmd = new NpgsqlCommand(query, db.getConnection());
            db.openConnection();
            if ((cmd.ExecuteNonQuery() == 1) && (Password_Reg == ConfirmPassword_Reg))
            {
                MessageBox.Show("Account has been successfully registered!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Registration sign_in = new Registration();
                this.Hide();
                sign_in.ShowDialog();
            }
            else
            {
                MessageBox.Show("Account hasn't been registered!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            db.closeConnection();
        }
        private Boolean checkAccount()
        {
            var Login_Reg_User = textBoxRegLogin.Text;
            var Password_Reg_User = textBoxRegPassword.Text;
            NpgsqlDataAdapter adapter = new NpgsqlDataAdapter();
            DataTable dt = new DataTable();
            string que = $"SELECT \"ID_Account\", \"Login_User\", \"Password_User\" FROM \"Accounts\" WHERE \"Login_User\" = '{Login_Reg_User}' and \"Password_User\" = '{Password_Reg_User}'";
            NpgsqlCommand cmd = new NpgsqlCommand(que, db.getConnection());

            adapter.SelectCommand = cmd;
            adapter.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Account already exists!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            else
            {
                return false;
            }
        }

        private void checkBoxViewPasses_CheckedChanged(object sender, EventArgs e)
        {
            if (tr)
            {
                textBoxRegPassword.UseSystemPasswordChar = false;
                textBoxRegConfirmPassword.UseSystemPasswordChar = false;
                tr = false;
            }
            else
            {
                textBoxRegPassword.UseSystemPasswordChar = true;
                textBoxRegConfirmPassword.UseSystemPasswordChar = true;
                tr = true;
            }
        }

        private void Reg_Account_Form_Closed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
