//-----------------------------------------------------------------------
// <copyright file="Login.Designer.cs" company="Freelancer">
// Copyright (c) Ilian Stoyanov. All rights reserved.
// </copyright>
// <author>Ilian Stoyanov</author>
//-----------------------------------------------------------------------

namespace ProjectX
{
    partial class FormLogin
    {
        private System.Windows.Forms.CheckBox chkRememberMe;
        private System.Windows.Forms.Label lblLoginInfo;
        private System.Windows.Forms.Label lblLoginName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblLoginPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Label lblHelp;
        private System.Windows.Forms.Label lblExit;
        private System.Windows.Forms.Label lblLogin;

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
            if (disposing && (this.components != null))
            {
                this.components.Dispose();
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
            this.components = new System.ComponentModel.Container();
            this.chkRememberMe = new System.Windows.Forms.CheckBox();
            this.lblLoginInfo = new System.Windows.Forms.Label();
            this.lblLoginName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblLoginPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.lblHelp = new System.Windows.Forms.Label();
            this.lblExit = new System.Windows.Forms.Label();
            this.lblLogin = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // chkRememberMe
            // 
            this.chkRememberMe.AutoSize = true;
            this.chkRememberMe.BackColor = System.Drawing.Color.Transparent;
            this.chkRememberMe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkRememberMe.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chkRememberMe.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.chkRememberMe.Location = new System.Drawing.Point(95, 160);
            this.chkRememberMe.Name = "chkRememberMe";
            this.chkRememberMe.Size = new System.Drawing.Size(98, 21);
            this.chkRememberMe.TabIndex = 0;
            this.chkRememberMe.Text = "Запомни ме";
            this.toolTip.SetToolTip(this.chkRememberMe, "Включване на автоматично влизане");
            this.chkRememberMe.UseVisualStyleBackColor = false;
            // 
            // lblLoginInfo
            // 
            this.lblLoginInfo.AutoSize = true;
            this.lblLoginInfo.BackColor = System.Drawing.Color.Transparent;
            this.lblLoginInfo.Font = new System.Drawing.Font("Comic Sans MS", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblLoginInfo.Location = new System.Drawing.Point(12, 9);
            this.lblLoginInfo.Name = "lblLoginInfo";
            this.lblLoginInfo.Size = new System.Drawing.Size(112, 52);
            this.lblLoginInfo.TabIndex = 1;
            this.lblLoginInfo.Text = "Вход";
            this.lblLoginInfo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblLoginName
            // 
            this.lblLoginName.AutoSize = true;
            this.lblLoginName.BackColor = System.Drawing.Color.Transparent;
            this.lblLoginName.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblLoginName.Location = new System.Drawing.Point(74, 80);
            this.lblLoginName.Name = "lblLoginName";
            this.lblLoginName.Size = new System.Drawing.Size(39, 20);
            this.lblLoginName.TabIndex = 2;
            this.lblLoginName.Text = "Име";
            this.lblLoginName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(153, 77);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(200, 23);
            this.txtName.TabIndex = 3;
            this.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblLoginPassword
            // 
            this.lblLoginPassword.AutoSize = true;
            this.lblLoginPassword.BackColor = System.Drawing.Color.Transparent;
            this.lblLoginPassword.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblLoginPassword.Location = new System.Drawing.Point(47, 118);
            this.lblLoginPassword.Name = "lblLoginPassword";
            this.lblLoginPassword.Size = new System.Drawing.Size(66, 20);
            this.lblLoginPassword.TabIndex = 4;
            this.lblLoginPassword.Text = "Парола";
            this.lblLoginPassword.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(153, 119);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(200, 23);
            this.txtPassword.TabIndex = 5;
            this.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblHelp
            // 
            this.lblHelp.AutoSize = true;
            this.lblHelp.BackColor = System.Drawing.Color.Transparent;
            this.lblHelp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblHelp.Font = new System.Drawing.Font("Comic Sans MS", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblHelp.Location = new System.Drawing.Point(117, 7);
            this.lblHelp.Name = "lblHelp";
            this.lblHelp.Size = new System.Drawing.Size(78, 52);
            this.lblHelp.TabIndex = 9;
            this.lblHelp.Text = "     ";
            this.toolTip.SetToolTip(this.lblHelp, "Помощ");
            this.lblHelp.Click += new System.EventHandler(this.lblHelp_Click);
            // 
            // lblExit
            // 
            this.lblExit.AutoSize = true;
            this.lblExit.BackColor = System.Drawing.Color.Transparent;
            this.lblExit.Font = new System.Drawing.Font("Comic Sans MS", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblExit.Image = global::ProjectX.Properties.Resources.Delete_icon;
            this.lblExit.Location = new System.Drawing.Point(344, 9);
            this.lblExit.Name = "lblExit";
            this.lblExit.Size = new System.Drawing.Size(34, 52);
            this.lblExit.TabIndex = 10;
            this.lblExit.Text = " ";
            this.lblExit.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.toolTip.SetToolTip(this.lblExit, "Изход");
            this.lblExit.Click += new System.EventHandler(this.btnLoginClose_Click);
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.BackColor = System.Drawing.Color.Transparent;
            this.lblLogin.Font = new System.Drawing.Font("Comic Sans MS", 15.75F);
            this.lblLogin.ForeColor = System.Drawing.Color.Silver;
            this.lblLogin.Location = new System.Drawing.Point(285, 152);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(68, 29);
            this.lblLogin.TabIndex = 11;
            this.lblLogin.Text = " Вход";
            this.lblLogin.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.toolTip.SetToolTip(this.lblLogin, "Вход");
            this.lblLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProjectX.Properties.Resources.Jump_Flight_Extreme_Height_Wallpapers_1080x1920;
            this.ClientSize = new System.Drawing.Size(400, 225);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.lblExit);
            this.Controls.Add(this.lblHelp);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblLoginPassword);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblLoginName);
            this.Controls.Add(this.lblLoginInfo);
            this.Controls.Add(this.chkRememberMe);
            this.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Project X";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion   
    }
}
