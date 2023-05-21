using Npgsql;
using System;
using System.Configuration;
using System.Windows.Forms;

namespace BD_Lab9_Test1
{
    public partial class Form1 : Form
    {
        private string connection;
        private string defStr;
        private NpgsqlDataAdapter adapter = default;
        private NpgsqlCommand command = default;
        private readonly Service.ReportService ReportService = new Service.ReportService();
        public Form1()
        {
            InitializeComponent();
            connection = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
        }

        private void button_CreateDatabase_Click(object sender, EventArgs e)  
        {
            pgSQL_Logic.CreateBD(NameBD.Text, this.connection);
        }

        private void button_AddRow_Click(object sender, EventArgs e)
        {
            pgSQL_Logic.AddRow(NTable.Text, NColumn.Text, DataType.Text, defStr);
        }

        private void button_DeleteRow_Click(object sender, EventArgs e)
        {
            pgSQL_Logic.DropRow(NTable.Text, NColumn.Text, defStr);
        }

        private void button_CreateTable_Click(object sender, EventArgs e) 
        {
            pgSQL_Logic.CreateTable(NTable.Text, defStr);
        }

        private void changePathButton_Click(object sender, EventArgs e)
        {
            UpdateSetting();
        }

        private void UpdateSetting()
        {
            defStr = "Server=localhost;Port=5432;Database=" + NameBD.Text + ";  User Id=postgres;Password=401330;";
        }
        // Tusk2

        private void CleanData()
        {
            textBoxLogin.Text = null;
            textBoxPassword1.Text = null;
        }

        private void AddClientButton_Click(object sender, EventArgs e) 
        {
            pgSQL_Logic.AddClient(textBoxLogin.Text, textBoxPassword1.Text, command, connection);
            dataGridView2.DataSource = pgSQL_Logic.ViewClientData(this.connection, this.adapter);
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            pgSQL_Logic.DeleteClient(numericID1.Value.ToString(), this.connection, this.command);
            dataGridView1.DataSource = pgSQL_Logic.ViewClientData(this.connection, this.adapter);
        }

        private void ViewDataButton_Click(object sender, EventArgs e)
        {
            dataGridView2.DataSource = pgSQL_Logic.ViewClientData(this.connection, this.adapter);
        }

        private void TruncateButton_Click(object sender, EventArgs e)
        {
            pgSQL_Logic.TruncateTable(this.connection, this.command);
            dataGridView2.DataSource = pgSQL_Logic.ViewClientData(this.connection, this.adapter);
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            pgSQL_Logic.UpdateClient(textBoxLogin.Text, textBoxPassword1.Text, numericID1.Value.ToString(), command, connection);
            dataGridView2.DataSource = pgSQL_Logic.ViewClientData(this.connection, this.adapter);
        }

        private void GroupByButton_Click(object sender, EventArgs e)
        {
            dataGridView3.DataSource = new Service.ClientService().OrderSalaryGroup(this.adapter, this.connection);
        }

        private void ExcelExportButton_Click(object sender, EventArgs e)
        {
            ReportService.ExportExcel(this.dataGridView3);
        }

        private void HavingButton_Click(object sender, EventArgs e)
        {
            dataGridView3.DataSource = new Service.ClientService().OrderSalaryHaving(this.adapter, this.connection);
        }

        private void WordExportButton_Click(object sender, EventArgs e)
        {
            ReportService.ExportWord(this.dataGridView3);
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
//<add name="DefaultConnection" connectionString="Server=localhost;Port=5432;Database=Univercity;  User Id=postgres;Password=401330;"  providerName="System.Data.SqlClient" />