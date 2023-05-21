using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BD_Lab9_Test1
{
    public partial class User_Student_ : Form
    {
        private string connection;
        private string defStr;
        private NpgsqlDataAdapter adapter = default;
        private NpgsqlCommand command = default;
        private readonly Service.ReportService ReportService = new Service.ReportService();
        DataBase database = new DataBase();
        public User_Student_()
        {
            InitializeComponent();
            connection = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
        }

        private void ButtonViewMarks_Click(object sender, EventArgs e)
        {
            dataGridViewUser.DataSource = UserSqlLogic.ViewUserData(this.connection, this.adapter);
        }



        private void UpdateSetting()
        {
            defStr = "Server=localhost;Port=5432;Database=" + NameDB1.Text + ";  User Id=postgres;Password=401330;";
        }

        private void buttonChangePath1_Click(object sender, EventArgs e)
        {
            UpdateSetting();
        }

        private void buttonSortGrade_Click(object sender, EventArgs e)
        {
            var SortGrade = textBoxSortGrade.Text;

            NpgsqlDataAdapter adapter = new NpgsqlDataAdapter();
            DataTable dt = new DataTable();

            string querystring = $"SELECT * FROM \"Marks\" WHERE \"Rate\" = '{SortGrade}'";

            
            NpgsqlCommand cmd = new NpgsqlCommand(querystring, database.getConnection());

            adapter.SelectCommand = cmd;
            dataGridViewUser.DataSource = dt;
            adapter.Fill(dt);
        }

        private void buttonSortSubjects_Click(object sender, EventArgs e)
        {
            var SortGrade = textBoxSortGrade.Text;
            var SortSubjects = textBoxSortSubjects.Text;
            string querystring;

            NpgsqlDataAdapter adapter = new NpgsqlDataAdapter();
            DataTable dt = new DataTable();

            if (SortGrade == "")
            {
                querystring = $"SELECT * FROM \"Marks\" WHERE \"Subject\" = '{SortSubjects}'";
            }
            else  querystring = $"SELECT * FROM \"Marks\" WHERE \"Rate\" = '{SortGrade}' AND \"Subject\" = '{SortSubjects}'";


            NpgsqlCommand cmd = new NpgsqlCommand(querystring, database.getConnection());

            adapter.SelectCommand = cmd;
            dataGridViewUser.DataSource = dt;
            adapter.Fill(dt);


        }

        private void buttonSortDate_Click(object sender, EventArgs e)
        {
            var SortGrade = textBoxSortGrade.Text;
            var SortSubjects = textBoxSortSubjects.Text;
            var SortDate = textBoxSortDate.Text;
            string querystring;

            NpgsqlDataAdapter adapter = new NpgsqlDataAdapter();
            DataTable dt = new DataTable();

            if (SortGrade == "" && SortSubjects == "")
            {
                querystring = $"SELECT * FROM \"Marks\" WHERE \"Date\" = '{SortDate}'";
            }
            else querystring = $"SELECT * FROM \"Marks\" WHERE \"Rate\" = '{SortGrade}' AND \"Subject\" = '{SortSubjects}' AND \"Date\" = '{SortDate}'";

            NpgsqlCommand cmd = new NpgsqlCommand(querystring, database.getConnection());

            adapter.SelectCommand = cmd;
            dataGridViewUser.DataSource = dt;
            adapter.Fill(dt);


        }

        private void buttonSunameS_Click(object sender, EventArgs e)
        {
            var SortGrade = textBoxSortGrade.Text;
            var SortSubjects = textBoxSortSubjects.Text;
            var SortDate = textBoxSortDate.Text;
            var SortSurname = textBoxSortSurname.Text;
            string querystring;

            NpgsqlDataAdapter adapter = new NpgsqlDataAdapter();
            DataTable dt = new DataTable();

            if (SortGrade == "" && SortSubjects == "" && SortDate == "")
            {
                querystring = $"SELECT * FROM \"Marks\" WHERE \"Surname_Stud\" = '{SortSurname}'";
            }
            else querystring = $"SELECT * FROM \"Marks\" WHERE \"Rate\" = '{SortGrade}' AND \"Subject\" = '{SortSubjects}' AND \"Date\" = '{SortDate}' AND \"Surname_Stud\" = '{SortSurname}'";

            NpgsqlCommand cmd = new NpgsqlCommand(querystring, database.getConnection());

            adapter.SelectCommand = cmd;
            dataGridViewUser.DataSource = dt;
            adapter.Fill(dt);

        }
    }
}
