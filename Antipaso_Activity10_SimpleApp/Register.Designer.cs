namespace Antipaso_Activity10_SimpleApp
{
    partial class frmRegister
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegister));
            this.pnlRegisterHeader = new System.Windows.Forms.Panel();
            this.pnlExit = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.lbltelecome = new System.Windows.Forms.Label();
            this.lblDira = new System.Windows.Forms.Label();
            this.lblRegisterAccount = new System.Windows.Forms.Label();
            this.btnRegister = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblpassword = new System.Windows.Forms.Label();
            this.lblusername = new System.Windows.Forms.Label();
            this.ptbRegback = new System.Windows.Forms.PictureBox();
            this.chkshowpassword = new System.Windows.Forms.CheckBox();
            this.pnlRegisterHeader.SuspendLayout();
            this.pnlExit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbRegback)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlRegisterHeader
            // 
            this.pnlRegisterHeader.BackColor = System.Drawing.Color.Gray;
            this.pnlRegisterHeader.Controls.Add(this.pnlExit);
            this.pnlRegisterHeader.Controls.Add(this.lbltelecome);
            this.pnlRegisterHeader.Controls.Add(this.lblDira);
            this.pnlRegisterHeader.Location = new System.Drawing.Point(-3, 0);
            this.pnlRegisterHeader.Name = "pnlRegisterHeader";
            this.pnlRegisterHeader.Size = new System.Drawing.Size(258, 72);
            this.pnlRegisterHeader.TabIndex = 0;
            // 
            // pnlExit
            // 
            this.pnlExit.Controls.Add(this.btnExit);
            this.pnlExit.Location = new System.Drawing.Point(208, 0);
            this.pnlExit.Name = "pnlExit";
            this.pnlExit.Size = new System.Drawing.Size(50, 36);
            this.pnlExit.TabIndex = 14;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Gray;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.Chartreuse;
            this.btnExit.Location = new System.Drawing.Point(-19, -11);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(83, 62);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lbltelecome
            // 
            this.lbltelecome.AutoSize = true;
            this.lbltelecome.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltelecome.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lbltelecome.Location = new System.Drawing.Point(71, 39);
            this.lbltelecome.Name = "lbltelecome";
            this.lbltelecome.Size = new System.Drawing.Size(114, 25);
            this.lbltelecome.TabIndex = 13;
            this.lbltelecome.Text = "Telecome";
            // 
            // lblDira
            // 
            this.lblDira.AutoSize = true;
            this.lblDira.Font = new System.Drawing.Font("Microsoft YaHei UI", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDira.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lblDira.Location = new System.Drawing.Point(83, 0);
            this.lblDira.Name = "lblDira";
            this.lblDira.Size = new System.Drawing.Size(92, 39);
            this.lblDira.TabIndex = 0;
            this.lblDira.Text = "DIRA";
            // 
            // lblRegisterAccount
            // 
            this.lblRegisterAccount.AutoSize = true;
            this.lblRegisterAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegisterAccount.Location = new System.Drawing.Point(39, 94);
            this.lblRegisterAccount.Name = "lblRegisterAccount";
            this.lblRegisterAccount.Size = new System.Drawing.Size(170, 24);
            this.lblRegisterAccount.TabIndex = 1;
            this.lblRegisterAccount.Text = "Register Account";
            // 
            // btnRegister
            // 
            this.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnRegister.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnRegister.Location = new System.Drawing.Point(87, 230);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(75, 30);
            this.btnRegister.TabIndex = 11;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(102, 176);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(129, 20);
            this.txtPassword.TabIndex = 10;
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(102, 134);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(129, 20);
            this.txtUsername.TabIndex = 9;
            // 
            // lblpassword
            // 
            this.lblpassword.AutoSize = true;
            this.lblpassword.BackColor = System.Drawing.Color.Transparent;
            this.lblpassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblpassword.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpassword.ForeColor = System.Drawing.Color.Black;
            this.lblpassword.Location = new System.Drawing.Point(6, 176);
            this.lblpassword.Name = "lblpassword";
            this.lblpassword.Size = new System.Drawing.Size(89, 22);
            this.lblpassword.TabIndex = 8;
            this.lblpassword.Text = "Password";
            // 
            // lblusername
            // 
            this.lblusername.AutoSize = true;
            this.lblusername.BackColor = System.Drawing.Color.Transparent;
            this.lblusername.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblusername.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblusername.ForeColor = System.Drawing.Color.Black;
            this.lblusername.Location = new System.Drawing.Point(6, 135);
            this.lblusername.Name = "lblusername";
            this.lblusername.Size = new System.Drawing.Size(90, 22);
            this.lblusername.TabIndex = 7;
            this.lblusername.Text = "Username";
            // 
            // ptbRegback
            // 
            this.ptbRegback.BackColor = System.Drawing.Color.Transparent;
            this.ptbRegback.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ptbRegback.Image = ((System.Drawing.Image)(resources.GetObject("ptbRegback.Image")));
            this.ptbRegback.Location = new System.Drawing.Point(-3, 66);
            this.ptbRegback.Name = "ptbRegback";
            this.ptbRegback.Size = new System.Drawing.Size(276, 212);
            this.ptbRegback.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbRegback.TabIndex = 12;
            this.ptbRegback.TabStop = false;
            // 
            // chkshowpassword
            // 
            this.chkshowpassword.AutoSize = true;
            this.chkshowpassword.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkshowpassword.ForeColor = System.Drawing.Color.Black;
            this.chkshowpassword.Location = new System.Drawing.Point(102, 202);
            this.chkshowpassword.Name = "chkshowpassword";
            this.chkshowpassword.Size = new System.Drawing.Size(122, 21);
            this.chkshowpassword.TabIndex = 13;
            this.chkshowpassword.Text = "Show Password";
            this.chkshowpassword.UseVisualStyleBackColor = true;
            this.chkshowpassword.CheckedChanged += new System.EventHandler(this.chkshowpassword_CheckedChanged);
            // 
            // frmRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(253, 277);
            this.Controls.Add(this.chkshowpassword);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.lblRegisterAccount);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.lblpassword);
            this.Controls.Add(this.lblusername);
            this.Controls.Add(this.pnlRegisterHeader);
            this.Controls.Add(this.ptbRegback);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmRegister";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register";
            this.pnlRegisterHeader.ResumeLayout(false);
            this.pnlRegisterHeader.PerformLayout();
            this.pnlExit.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptbRegback)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlRegisterHeader;
        private System.Windows.Forms.Label lblDira;
        private System.Windows.Forms.Label lblRegisterAccount;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblpassword;
        private System.Windows.Forms.Label lblusername;
        private System.Windows.Forms.PictureBox ptbRegback;
        private System.Windows.Forms.Label lbltelecome;
        private System.Windows.Forms.Panel pnlExit;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.CheckBox chkshowpassword;
    }
}