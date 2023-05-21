namespace BD_Lab9_Test1
{
    partial class Registration
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LabelLogin = new System.Windows.Forms.Label();
            this.LabelPassword = new System.Windows.Forms.Label();
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.LabelSignIn = new System.Windows.Forms.Label();
            this.buttonSignIn = new System.Windows.Forms.Button();
            this.checkPassView = new System.Windows.Forms.CheckBox();
            this.linkLabelSignUp = new System.Windows.Forms.LinkLabel();
            this.ComboBoxRole = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // LabelLogin
            // 
            this.LabelLogin.AutoSize = true;
            this.LabelLogin.Location = new System.Drawing.Point(174, 124);
            this.LabelLogin.Name = "LabelLogin";
            this.LabelLogin.Size = new System.Drawing.Size(33, 13);
            this.LabelLogin.TabIndex = 0;
            this.LabelLogin.Text = "Login";
            // 
            // LabelPassword
            // 
            this.LabelPassword.AutoSize = true;
            this.LabelPassword.Location = new System.Drawing.Point(154, 150);
            this.LabelPassword.Name = "LabelPassword";
            this.LabelPassword.Size = new System.Drawing.Size(53, 13);
            this.LabelPassword.TabIndex = 1;
            this.LabelPassword.Text = "Password";
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.Location = new System.Drawing.Point(213, 121);
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(100, 20);
            this.textBoxLogin.TabIndex = 2;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(213, 149);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(100, 20);
            this.textBoxPassword.TabIndex = 3;
            this.textBoxPassword.UseSystemPasswordChar = true;
            // 
            // LabelSignIn
            // 
            this.LabelSignIn.AutoSize = true;
            this.LabelSignIn.Location = new System.Drawing.Point(227, 75);
            this.LabelSignIn.Name = "LabelSignIn";
            this.LabelSignIn.Size = new System.Drawing.Size(68, 26);
            this.LabelSignIn.TabIndex = 4;
            this.LabelSignIn.Text = "\r\nAuthorization";
            // 
            // buttonSignIn
            // 
            this.buttonSignIn.Location = new System.Drawing.Point(224, 198);
            this.buttonSignIn.Name = "buttonSignIn";
            this.buttonSignIn.Size = new System.Drawing.Size(75, 23);
            this.buttonSignIn.TabIndex = 5;
            this.buttonSignIn.Text = "Sign in ";
            this.buttonSignIn.UseVisualStyleBackColor = true;
            this.buttonSignIn.Click += new System.EventHandler(this.buttonSignIn_Click);
            // 
            // checkPassView
            // 
            this.checkPassView.AutoSize = true;
            this.checkPassView.Location = new System.Drawing.Point(215, 175);
            this.checkPassView.Name = "checkPassView";
            this.checkPassView.Size = new System.Drawing.Size(98, 17);
            this.checkPassView.TabIndex = 6;
            this.checkPassView.Text = "View Password";
            this.checkPassView.UseVisualStyleBackColor = true;
            this.checkPassView.CheckedChanged += new System.EventHandler(this.checkPassView_CheckedChanged);
            // 
            // linkLabelSignUp
            // 
            this.linkLabelSignUp.AutoSize = true;
            this.linkLabelSignUp.Location = new System.Drawing.Point(12, 278);
            this.linkLabelSignUp.Name = "linkLabelSignUp";
            this.linkLabelSignUp.Size = new System.Drawing.Size(45, 13);
            this.linkLabelSignUp.TabIndex = 7;
            this.linkLabelSignUp.TabStop = true;
            this.linkLabelSignUp.Text = "Sign Up";
            this.linkLabelSignUp.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelSignUp_LinkClicked);
            // 
            // ComboBoxRole
            // 
            this.ComboBoxRole.FormattingEnabled = true;
            this.ComboBoxRole.Items.AddRange(new object[] {
            "Студент",
            "Преподаватель",
            "Администратор"});
            this.ComboBoxRole.Location = new System.Drawing.Point(319, 171);
            this.ComboBoxRole.Name = "ComboBoxRole";
            this.ComboBoxRole.Size = new System.Drawing.Size(121, 21);
            this.ComboBoxRole.TabIndex = 8;
            // 
            // Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(585, 300);
            this.Controls.Add(this.ComboBoxRole);
            this.Controls.Add(this.linkLabelSignUp);
            this.Controls.Add(this.LabelSignIn);
            this.Controls.Add(this.LabelLogin);
            this.Controls.Add(this.checkPassView);
            this.Controls.Add(this.LabelPassword);
            this.Controls.Add(this.buttonSignIn);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxLogin);
            this.Name = "Registration";
            this.Text = "Registration";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelLogin;
        private System.Windows.Forms.Label LabelPassword;
        private System.Windows.Forms.TextBox textBoxLogin;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label LabelSignIn;
        private System.Windows.Forms.Button buttonSignIn;
        private System.Windows.Forms.CheckBox checkPassView;
        private System.Windows.Forms.LinkLabel linkLabelSignUp;
        private System.Windows.Forms.ComboBox ComboBoxRole;
    }
}