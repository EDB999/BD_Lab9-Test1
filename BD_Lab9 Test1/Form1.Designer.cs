namespace BD_Lab9_Test1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button_AddRow = new System.Windows.Forms.Button();
            this.button_DeleteRow = new System.Windows.Forms.Button();
            this.button_CreateDatabase = new System.Windows.Forms.Button();
            this.NameBD = new System.Windows.Forms.TextBox();
            this.NTable = new System.Windows.Forms.TextBox();
            this.NColumn = new System.Windows.Forms.TextBox();
            this.DataType = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button_CreateTable = new System.Windows.Forms.Button();
            this.changePathButton = new System.Windows.Forms.Button();
            this.tabcontrol = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.ViewDataButton = new System.Windows.Forms.Button();
            this.numericID1 = new System.Windows.Forms.NumericUpDown();
            this.TruncateButton = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.textBoxPassword1 = new System.Windows.Forms.TextBox();
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.Label();
            this.Login1 = new System.Windows.Forms.Label();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.AddClientButton = new System.Windows.Forms.Button();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.WordExportButton = new System.Windows.Forms.Button();
            this.HavingButton = new System.Windows.Forms.Button();
            this.ExcelExportButton = new System.Windows.Forms.Button();
            this.GroupByButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabcontrol.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericID1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(545, 260);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // button_AddRow
            // 
            this.button_AddRow.Location = new System.Drawing.Point(11, 189);
            this.button_AddRow.Name = "button_AddRow";
            this.button_AddRow.Size = new System.Drawing.Size(172, 23);
            this.button_AddRow.TabIndex = 1;
            this.button_AddRow.Text = "Add Row";
            this.button_AddRow.UseVisualStyleBackColor = true;
            this.button_AddRow.Click += new System.EventHandler(this.button_AddRow_Click);
            // 
            // button_DeleteRow
            // 
            this.button_DeleteRow.Location = new System.Drawing.Point(14, 218);
            this.button_DeleteRow.Name = "button_DeleteRow";
            this.button_DeleteRow.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.button_DeleteRow.Size = new System.Drawing.Size(169, 23);
            this.button_DeleteRow.TabIndex = 2;
            this.button_DeleteRow.Text = "Drop Row";
            this.button_DeleteRow.UseVisualStyleBackColor = true;
            this.button_DeleteRow.Click += new System.EventHandler(this.button_DeleteRow_Click);
            // 
            // button_CreateDatabase
            // 
            this.button_CreateDatabase.Location = new System.Drawing.Point(14, 48);
            this.button_CreateDatabase.Name = "button_CreateDatabase";
            this.button_CreateDatabase.Size = new System.Drawing.Size(172, 23);
            this.button_CreateDatabase.TabIndex = 3;
            this.button_CreateDatabase.Text = "Create Database";
            this.button_CreateDatabase.UseVisualStyleBackColor = true;
            this.button_CreateDatabase.Click += new System.EventHandler(this.button_CreateDatabase_Click);
            // 
            // NameBD
            // 
            this.NameBD.Location = new System.Drawing.Point(14, 22);
            this.NameBD.Name = "NameBD";
            this.NameBD.Size = new System.Drawing.Size(172, 20);
            this.NameBD.TabIndex = 4;
            this.NameBD.Text = "NameDB";
            // 
            // NTable
            // 
            this.NTable.Location = new System.Drawing.Point(14, 95);
            this.NTable.Name = "NTable";
            this.NTable.Size = new System.Drawing.Size(172, 20);
            this.NTable.TabIndex = 5;
            this.NTable.Text = "NTable";
            // 
            // NColumn
            // 
            this.NColumn.Location = new System.Drawing.Point(11, 163);
            this.NColumn.Name = "NColumn";
            this.NColumn.Size = new System.Drawing.Size(172, 20);
            this.NColumn.TabIndex = 6;
            // 
            // DataType
            // 
            this.DataType.Location = new System.Drawing.Point(265, 92);
            this.DataType.Name = "DataType";
            this.DataType.Size = new System.Drawing.Size(172, 20);
            this.DataType.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "База данных";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Название таблицы";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Название столбца";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(262, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Тип данных";
            // 
            // button_CreateTable
            // 
            this.button_CreateTable.Location = new System.Drawing.Point(11, 121);
            this.button_CreateTable.Name = "button_CreateTable";
            this.button_CreateTable.Size = new System.Drawing.Size(172, 23);
            this.button_CreateTable.TabIndex = 14;
            this.button_CreateTable.Text = "Create Table";
            this.button_CreateTable.UseVisualStyleBackColor = true;
            this.button_CreateTable.Click += new System.EventHandler(this.button_CreateTable_Click);
            // 
            // changePathButton
            // 
            this.changePathButton.Location = new System.Drawing.Point(265, 22);
            this.changePathButton.Name = "changePathButton";
            this.changePathButton.Size = new System.Drawing.Size(150, 23);
            this.changePathButton.TabIndex = 15;
            this.changePathButton.Text = "Change path";
            this.changePathButton.UseVisualStyleBackColor = true;
            this.changePathButton.Click += new System.EventHandler(this.changePathButton_Click);
            // 
            // tabcontrol
            // 
            this.tabcontrol.Controls.Add(this.tabPage2);
            this.tabcontrol.Controls.Add(this.tabPage1);
            this.tabcontrol.Controls.Add(this.tabPage3);
            this.tabcontrol.Location = new System.Drawing.Point(0, -1);
            this.tabcontrol.Name = "tabcontrol";
            this.tabcontrol.SelectedIndex = 0;
            this.tabcontrol.Size = new System.Drawing.Size(796, 439);
            this.tabcontrol.TabIndex = 16;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.ViewDataButton);
            this.tabPage2.Controls.Add(this.numericID1);
            this.tabPage2.Controls.Add(this.TruncateButton);
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Controls.Add(this.textBoxPassword1);
            this.tabPage2.Controls.Add(this.textBoxLogin);
            this.tabPage2.Controls.Add(this.Password);
            this.tabPage2.Controls.Add(this.Login1);
            this.tabPage2.Controls.Add(this.UpdateButton);
            this.tabPage2.Controls.Add(this.DeleteButton);
            this.tabPage2.Controls.Add(this.AddClientButton);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(788, 413);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Редактирование Accounts";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Welcome, Admin!";
            // 
            // ViewDataButton
            // 
            this.ViewDataButton.Location = new System.Drawing.Point(6, 195);
            this.ViewDataButton.Name = "ViewDataButton";
            this.ViewDataButton.Size = new System.Drawing.Size(75, 23);
            this.ViewDataButton.TabIndex = 16;
            this.ViewDataButton.Text = "View";
            this.ViewDataButton.UseVisualStyleBackColor = true;
            this.ViewDataButton.Click += new System.EventHandler(this.ViewDataButton_Click);
            // 
            // numericID1
            // 
            this.numericID1.Location = new System.Drawing.Point(89, 111);
            this.numericID1.Name = "numericID1";
            this.numericID1.Size = new System.Drawing.Size(55, 20);
            this.numericID1.TabIndex = 15;
            // 
            // TruncateButton
            // 
            this.TruncateButton.Location = new System.Drawing.Point(6, 166);
            this.TruncateButton.Name = "TruncateButton";
            this.TruncateButton.Size = new System.Drawing.Size(75, 23);
            this.TruncateButton.TabIndex = 14;
            this.TruncateButton.Text = "Truncate";
            this.TruncateButton.UseVisualStyleBackColor = true;
            this.TruncateButton.Click += new System.EventHandler(this.TruncateButton_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(169, 6);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(613, 401);
            this.dataGridView2.TabIndex = 13;
            // 
            // textBoxPassword1
            // 
            this.textBoxPassword1.Location = new System.Drawing.Point(6, 53);
            this.textBoxPassword1.Name = "textBoxPassword1";
            this.textBoxPassword1.Size = new System.Drawing.Size(100, 20);
            this.textBoxPassword1.TabIndex = 9;
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.Location = new System.Drawing.Point(6, 27);
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(100, 20);
            this.textBoxLogin.TabIndex = 8;
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.Location = new System.Drawing.Point(112, 56);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(53, 13);
            this.Password.TabIndex = 4;
            this.Password.Text = "Password";
            // 
            // Login1
            // 
            this.Login1.AutoSize = true;
            this.Login1.Location = new System.Drawing.Point(112, 34);
            this.Login1.Name = "Login1";
            this.Login1.Size = new System.Drawing.Size(33, 13);
            this.Login1.TabIndex = 3;
            this.Login1.Text = "Login";
            // 
            // UpdateButton
            // 
            this.UpdateButton.Location = new System.Drawing.Point(6, 137);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(75, 23);
            this.UpdateButton.TabIndex = 2;
            this.UpdateButton.Text = "Update";
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(5, 108);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(75, 23);
            this.DeleteButton.TabIndex = 1;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // AddClientButton
            // 
            this.AddClientButton.Location = new System.Drawing.Point(5, 79);
            this.AddClientButton.Name = "AddClientButton";
            this.AddClientButton.Size = new System.Drawing.Size(75, 23);
            this.AddClientButton.TabIndex = 0;
            this.AddClientButton.Text = "Add";
            this.AddClientButton.UseVisualStyleBackColor = true;
            this.AddClientButton.Click += new System.EventHandler(this.AddClientButton_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.button_DeleteRow);
            this.tabPage1.Controls.Add(this.NColumn);
            this.tabPage1.Controls.Add(this.button_AddRow);
            this.tabPage1.Controls.Add(this.button_CreateTable);
            this.tabPage1.Controls.Add(this.changePathButton);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.DataType);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.NameBD);
            this.tabPage1.Controls.Add(this.NTable);
            this.tabPage1.Controls.Add(this.button_CreateDatabase);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(788, 413);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Функционал";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dataGridView3);
            this.tabPage3.Controls.Add(this.WordExportButton);
            this.tabPage3.Controls.Add(this.HavingButton);
            this.tabPage3.Controls.Add(this.ExcelExportButton);
            this.tabPage3.Controls.Add(this.GroupByButton);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(788, 413);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Запросы/Экспорт";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(141, 3);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(643, 407);
            this.dataGridView3.TabIndex = 4;
            // 
            // WordExportButton
            // 
            this.WordExportButton.Location = new System.Drawing.Point(3, 105);
            this.WordExportButton.Name = "WordExportButton";
            this.WordExportButton.Size = new System.Drawing.Size(112, 22);
            this.WordExportButton.TabIndex = 3;
            this.WordExportButton.Text = "Экспорт в Word";
            this.WordExportButton.UseVisualStyleBackColor = true;
            this.WordExportButton.Click += new System.EventHandler(this.WordExportButton_Click);
            // 
            // HavingButton
            // 
            this.HavingButton.Location = new System.Drawing.Point(3, 76);
            this.HavingButton.Name = "HavingButton";
            this.HavingButton.Size = new System.Drawing.Size(112, 23);
            this.HavingButton.TabIndex = 2;
            this.HavingButton.Text = "Запрос HAVING";
            this.HavingButton.UseVisualStyleBackColor = true;
            this.HavingButton.Click += new System.EventHandler(this.HavingButton_Click);
            // 
            // ExcelExportButton
            // 
            this.ExcelExportButton.Location = new System.Drawing.Point(3, 43);
            this.ExcelExportButton.Name = "ExcelExportButton";
            this.ExcelExportButton.Size = new System.Drawing.Size(112, 23);
            this.ExcelExportButton.TabIndex = 1;
            this.ExcelExportButton.Text = "Экспорт в Excel";
            this.ExcelExportButton.UseVisualStyleBackColor = true;
            this.ExcelExportButton.Click += new System.EventHandler(this.ExcelExportButton_Click);
            // 
            // GroupByButton
            // 
            this.GroupByButton.Location = new System.Drawing.Point(3, 14);
            this.GroupByButton.Name = "GroupByButton";
            this.GroupByButton.Size = new System.Drawing.Size(138, 23);
            this.GroupByButton.TabIndex = 0;
            this.GroupByButton.Text = "Запрос GROUPBY/JOIN";
            this.GroupByButton.UseVisualStyleBackColor = true;
            this.GroupByButton.Click += new System.EventHandler(this.GroupByButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabcontrol);
            this.Controls.Add(this.label2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabcontrol.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericID1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button_AddRow;
        private System.Windows.Forms.Button button_DeleteRow;
        private System.Windows.Forms.Button button_CreateDatabase;
        private System.Windows.Forms.TextBox NameBD;
        private System.Windows.Forms.TextBox NTable;
        private System.Windows.Forms.TextBox NColumn;
        private System.Windows.Forms.TextBox DataType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button_CreateTable;
        private System.Windows.Forms.Button changePathButton;
        private System.Windows.Forms.TabControl tabcontrol;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button AddClientButton;
        private System.Windows.Forms.Label Login1;
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.TextBox textBoxPassword1;
        private System.Windows.Forms.TextBox textBoxLogin;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button TruncateButton;
        private System.Windows.Forms.NumericUpDown numericID1;
        private System.Windows.Forms.Button ViewDataButton;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Button WordExportButton;
        private System.Windows.Forms.Button HavingButton;
        private System.Windows.Forms.Button ExcelExportButton;
        private System.Windows.Forms.Button GroupByButton;
        private System.Windows.Forms.Label label3;
    }
}

