namespace BD_Lab9_Test1
{
    partial class RegAccount
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
            this.labelRegLogin = new System.Windows.Forms.Label();
            this.labelRegPassword = new System.Windows.Forms.Label();
            this.labelRegConrifmPassword = new System.Windows.Forms.Label();
            this.textBoxRegLogin = new System.Windows.Forms.TextBox();
            this.textBoxRegPassword = new System.Windows.Forms.TextBox();
            this.textBoxRegConfirmPassword = new System.Windows.Forms.TextBox();
            this.LabelReg = new System.Windows.Forms.Label();
            this.buttonRegAcc = new System.Windows.Forms.Button();
            this.checkBoxViewPasses = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // labelRegLogin
            // 
            this.labelRegLogin.AutoSize = true;
            this.labelRegLogin.Location = new System.Drawing.Point(252, 119);
            this.labelRegLogin.Name = "labelRegLogin";
            this.labelRegLogin.Size = new System.Drawing.Size(33, 13);
            this.labelRegLogin.TabIndex = 12;
            this.labelRegLogin.Text = "Login";
            // 
            // labelRegPassword
            // 
            this.labelRegPassword.AutoSize = true;
            this.labelRegPassword.Location = new System.Drawing.Point(232, 147);
            this.labelRegPassword.Name = "labelRegPassword";
            this.labelRegPassword.Size = new System.Drawing.Size(53, 13);
            this.labelRegPassword.TabIndex = 13;
            this.labelRegPassword.Text = "Password";
            // 
            // labelRegConrifmPassword
            // 
            this.labelRegConrifmPassword.AutoSize = true;
            this.labelRegConrifmPassword.Location = new System.Drawing.Point(195, 173);
            this.labelRegConrifmPassword.Name = "labelRegConrifmPassword";
            this.labelRegConrifmPassword.Size = new System.Drawing.Size(90, 13);
            this.labelRegConrifmPassword.TabIndex = 14;
            this.labelRegConrifmPassword.Text = "Confrim password";
            // 
            // textBoxRegLogin
            // 
            this.textBoxRegLogin.Location = new System.Drawing.Point(291, 116);
            this.textBoxRegLogin.Name = "textBoxRegLogin";
            this.textBoxRegLogin.Size = new System.Drawing.Size(100, 20);
            this.textBoxRegLogin.TabIndex = 15;
            // 
            // textBoxRegPassword
            // 
            this.textBoxRegPassword.Location = new System.Drawing.Point(291, 144);
            this.textBoxRegPassword.Name = "textBoxRegPassword";
            this.textBoxRegPassword.Size = new System.Drawing.Size(100, 20);
            this.textBoxRegPassword.TabIndex = 16;
            this.textBoxRegPassword.UseSystemPasswordChar = true;
            // 
            // textBoxRegConfirmPassword
            // 
            this.textBoxRegConfirmPassword.Location = new System.Drawing.Point(291, 170);
            this.textBoxRegConfirmPassword.Name = "textBoxRegConfirmPassword";
            this.textBoxRegConfirmPassword.Size = new System.Drawing.Size(100, 20);
            this.textBoxRegConfirmPassword.TabIndex = 17;
            this.textBoxRegConfirmPassword.UseSystemPasswordChar = true;
            // 
            // LabelReg
            // 
            this.LabelReg.AutoSize = true;
            this.LabelReg.Location = new System.Drawing.Point(308, 9);
            this.LabelReg.Name = "LabelReg";
            this.LabelReg.Size = new System.Drawing.Size(63, 13);
            this.LabelReg.TabIndex = 18;
            this.LabelReg.Text = "Registration";
            // 
            // buttonRegAcc
            // 
            this.buttonRegAcc.Location = new System.Drawing.Point(279, 212);
            this.buttonRegAcc.Name = "buttonRegAcc";
            this.buttonRegAcc.Size = new System.Drawing.Size(125, 23);
            this.buttonRegAcc.TabIndex = 19;
            this.buttonRegAcc.Text = "Register Account";
            this.buttonRegAcc.UseVisualStyleBackColor = true;
            this.buttonRegAcc.Click += new System.EventHandler(this.buttonRegAcc_Click);
            // 
            // checkBoxViewPasses
            // 
            this.checkBoxViewPasses.AutoSize = true;
            this.checkBoxViewPasses.Location = new System.Drawing.Point(288, 196);
            this.checkBoxViewPasses.Name = "checkBoxViewPasses";
            this.checkBoxViewPasses.Size = new System.Drawing.Size(103, 17);
            this.checkBoxViewPasses.TabIndex = 20;
            this.checkBoxViewPasses.Text = "View Passwords";
            this.checkBoxViewPasses.UseVisualStyleBackColor = true;
            this.checkBoxViewPasses.CheckedChanged += new System.EventHandler(this.checkBoxViewPasses_CheckedChanged);
            // 
            // RegAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 302);
            this.Controls.Add(this.checkBoxViewPasses);
            this.Controls.Add(this.buttonRegAcc);
            this.Controls.Add(this.LabelReg);
            this.Controls.Add(this.textBoxRegConfirmPassword);
            this.Controls.Add(this.textBoxRegPassword);
            this.Controls.Add(this.textBoxRegLogin);
            this.Controls.Add(this.labelRegConrifmPassword);
            this.Controls.Add(this.labelRegPassword);
            this.Controls.Add(this.labelRegLogin);
            this.Name = "RegAccount";
            this.Text = "RegAccount";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Reg_Account_Form_Closed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelRegLogin;
        private System.Windows.Forms.Label labelRegPassword;
        private System.Windows.Forms.Label labelRegConrifmPassword;
        private System.Windows.Forms.TextBox textBoxRegLogin;
        private System.Windows.Forms.TextBox textBoxRegPassword;
        private System.Windows.Forms.TextBox textBoxRegConfirmPassword;
        private System.Windows.Forms.Label LabelReg;
        private System.Windows.Forms.Button buttonRegAcc;
        private System.Windows.Forms.CheckBox checkBoxViewPasses;
    }
}