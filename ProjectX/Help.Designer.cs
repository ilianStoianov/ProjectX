//-----------------------------------------------------------------------
// <copyright file="Help.Designer.cs" company="Freelancer">
// Copyright (c) Ilian Stoyanov. All rights reserved.
// </copyright>
// <author>Ilian Stoyanov</author>
//-----------------------------------------------------------------------

namespace ProjectX
{
    using System.Configuration;
    using System.Windows.Forms;


    partial class FormHelp
    {
        private System.Windows.Forms.Label lblNamesSent;
        private System.Windows.Forms.TextBox txtNamesSent;
        private System.Windows.Forms.Label lblEmailSent;
        private System.Windows.Forms.TextBox txtEmailSent;
        private System.Windows.Forms.Label lblPhoneSent;
        private System.Windows.Forms.TextBox txtPhoneSent;
        private System.Windows.Forms.TextBox txtMessageSent;
        private Label lblInquiry;
        private Label lblMessageSent;
        private Label lblEmailTitle;
        private Label lblEmail;
        private Label lblPhoneTitle;
        private Label lblAddressTitle;
        private Label lblAddress;
        private Label lblPhone;
        private Label lblSaitTitle;
        private Label lblSite;
        private ToolTip toolTip1;
        private TextBox txtSubjectSent;
        private Label lblSubjectSent;
        private Label lblStatus;
        private Label lblTitle;
        private Label lblExit;
        private Label lblToy;
        private Label lblClear;
        protected internal Label lblSend;
        private Label label3;

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
            this.lblNamesSent = new System.Windows.Forms.Label();
            this.txtNamesSent = new System.Windows.Forms.TextBox();
            this.lblEmailSent = new System.Windows.Forms.Label();
            this.txtEmailSent = new System.Windows.Forms.TextBox();
            this.lblPhoneSent = new System.Windows.Forms.Label();
            this.txtPhoneSent = new System.Windows.Forms.TextBox();
            this.txtMessageSent = new System.Windows.Forms.TextBox();
            this.lblInquiry = new System.Windows.Forms.Label();
            this.lblMessageSent = new System.Windows.Forms.Label();
            this.lblEmailTitle = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblPhoneTitle = new System.Windows.Forms.Label();
            this.lblAddressTitle = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblSaitTitle = new System.Windows.Forms.Label();
            this.lblSite = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.lblExit = new System.Windows.Forms.Label();
            this.lblClear = new System.Windows.Forms.Label();
            this.lblSend = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblToy = new System.Windows.Forms.Label();
            this.txtSubjectSent = new System.Windows.Forms.TextBox();
            this.lblSubjectSent = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNamesSent
            // 
            this.lblNamesSent.AutoSize = true;
            this.lblNamesSent.BackColor = System.Drawing.Color.Transparent;
            this.lblNamesSent.Font = new System.Drawing.Font("Comic Sans MS", 9.75F);
            this.lblNamesSent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblNamesSent.Location = new System.Drawing.Point(65, 104);
            this.lblNamesSent.Name = "lblNamesSent";
            this.lblNamesSent.Size = new System.Drawing.Size(49, 18);
            this.lblNamesSent.TabIndex = 5;
            this.lblNamesSent.Text = "Имена";
            // 
            // txtNamesSent
            // 
            this.txtNamesSent.BackColor = System.Drawing.Color.DimGray;
            this.txtNamesSent.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNamesSent.Location = new System.Drawing.Point(68, 125);
            this.txtNamesSent.Name = "txtNamesSent";
            this.txtNamesSent.Size = new System.Drawing.Size(210, 16);
            this.txtNamesSent.TabIndex = 1;
            this.txtNamesSent.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblEmailSent
            // 
            this.lblEmailSent.AutoSize = true;
            this.lblEmailSent.BackColor = System.Drawing.Color.Transparent;
            this.lblEmailSent.Font = new System.Drawing.Font("Comic Sans MS", 9.75F);
            this.lblEmailSent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblEmailSent.Location = new System.Drawing.Point(69, 156);
            this.lblEmailSent.Name = "lblEmailSent";
            this.lblEmailSent.Size = new System.Drawing.Size(45, 18);
            this.lblEmailSent.TabIndex = 7;
            this.lblEmailSent.Text = "E-mail";
            // 
            // txtEmailSent
            // 
            this.txtEmailSent.BackColor = System.Drawing.Color.DimGray;
            this.txtEmailSent.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmailSent.Location = new System.Drawing.Point(68, 177);
            this.txtEmailSent.Name = "txtEmailSent";
            this.txtEmailSent.Size = new System.Drawing.Size(210, 16);
            this.txtEmailSent.TabIndex = 2;
            this.txtEmailSent.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblPhoneSent
            // 
            this.lblPhoneSent.AutoSize = true;
            this.lblPhoneSent.BackColor = System.Drawing.Color.Transparent;
            this.lblPhoneSent.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPhoneSent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblPhoneSent.Location = new System.Drawing.Point(65, 211);
            this.lblPhoneSent.Name = "lblPhoneSent";
            this.lblPhoneSent.Size = new System.Drawing.Size(65, 18);
            this.lblPhoneSent.TabIndex = 9;
            this.lblPhoneSent.Text = "Телефон";
            // 
            // txtPhoneSent
            // 
            this.txtPhoneSent.BackColor = System.Drawing.Color.DimGray;
            this.txtPhoneSent.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPhoneSent.Location = new System.Drawing.Point(68, 232);
            this.txtPhoneSent.Name = "txtPhoneSent";
            this.txtPhoneSent.Size = new System.Drawing.Size(210, 16);
            this.txtPhoneSent.TabIndex = 3;
            this.txtPhoneSent.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtMessageSent
            // 
            this.txtMessageSent.BackColor = System.Drawing.Color.DimGray;
            this.txtMessageSent.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMessageSent.Location = new System.Drawing.Point(382, 125);
            this.txtMessageSent.Multiline = true;
            this.txtMessageSent.Name = "txtMessageSent";
            this.txtMessageSent.Size = new System.Drawing.Size(372, 156);
            this.txtMessageSent.TabIndex = 5;
            // 
            // lblInquiry
            // 
            this.lblInquiry.AutoSize = true;
            this.lblInquiry.BackColor = System.Drawing.Color.Transparent;
            this.lblInquiry.Font = new System.Drawing.Font("Comic Sans MS", 18.75F);
            this.lblInquiry.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblInquiry.Location = new System.Drawing.Point(314, 39);
            this.lblInquiry.Name = "lblInquiry";
            this.lblInquiry.Size = new System.Drawing.Size(141, 34);
            this.lblInquiry.TabIndex = 12;
            this.lblInquiry.Text = "Запитване";
            // 
            // lblMessageSent
            // 
            this.lblMessageSent.AutoSize = true;
            this.lblMessageSent.BackColor = System.Drawing.Color.Transparent;
            this.lblMessageSent.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblMessageSent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblMessageSent.Location = new System.Drawing.Point(379, 104);
            this.lblMessageSent.Name = "lblMessageSent";
            this.lblMessageSent.Size = new System.Drawing.Size(78, 18);
            this.lblMessageSent.TabIndex = 13;
            this.lblMessageSent.Text = "Съобщение";
            // 
            // lblEmailTitle
            // 
            this.lblEmailTitle.AutoSize = true;
            this.lblEmailTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblEmailTitle.Font = new System.Drawing.Font("Comic Sans MS", 12.75F);
            this.lblEmailTitle.ForeColor = System.Drawing.Color.Gray;
            this.lblEmailTitle.Location = new System.Drawing.Point(59, 397);
            this.lblEmailTitle.Name = "lblEmailTitle";
            this.lblEmailTitle.Size = new System.Drawing.Size(64, 24);
            this.lblEmailTitle.TabIndex = 16;
            this.lblEmailTitle.Text = "E-mail:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.BackColor = System.Drawing.Color.Transparent;
            this.lblEmail.Font = new System.Drawing.Font("Comic Sans MS", 12.75F);
            this.lblEmail.ForeColor = System.Drawing.Color.Gray;
            this.lblEmail.Location = new System.Drawing.Point(129, 397);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(0, 24);
            this.lblEmail.TabIndex = 17;
            // 
            // lblPhoneTitle
            // 
            this.lblPhoneTitle.AutoSize = true;
            this.lblPhoneTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblPhoneTitle.Font = new System.Drawing.Font("Comic Sans MS", 12.75F);
            this.lblPhoneTitle.ForeColor = System.Drawing.Color.Gray;
            this.lblPhoneTitle.Location = new System.Drawing.Point(31, 373);
            this.lblPhoneTitle.Name = "lblPhoneTitle";
            this.lblPhoneTitle.Size = new System.Drawing.Size(92, 24);
            this.lblPhoneTitle.TabIndex = 18;
            this.lblPhoneTitle.Text = "Телефон:";
            // 
            // lblAddressTitle
            // 
            this.lblAddressTitle.AutoSize = true;
            this.lblAddressTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblAddressTitle.Font = new System.Drawing.Font("Comic Sans MS", 12.75F);
            this.lblAddressTitle.ForeColor = System.Drawing.Color.Gray;
            this.lblAddressTitle.Location = new System.Drawing.Point(378, 373);
            this.lblAddressTitle.Name = "lblAddressTitle";
            this.lblAddressTitle.Size = new System.Drawing.Size(65, 24);
            this.lblAddressTitle.TabIndex = 19;
            this.lblAddressTitle.Text = "Адрес:";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.BackColor = System.Drawing.Color.Transparent;
            this.lblAddress.Font = new System.Drawing.Font("Comic Sans MS", 12.75F);
            this.lblAddress.ForeColor = System.Drawing.Color.Gray;
            this.lblAddress.Location = new System.Drawing.Point(449, 373);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(0, 24);
            this.lblAddress.TabIndex = 20;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.BackColor = System.Drawing.Color.Transparent;
            this.lblPhone.Font = new System.Drawing.Font("Comic Sans MS", 12.75F);
            this.lblPhone.ForeColor = System.Drawing.Color.Gray;
            this.lblPhone.Location = new System.Drawing.Point(129, 373);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(0, 24);
            this.lblPhone.TabIndex = 21;
            // 
            // lblSaitTitle
            // 
            this.lblSaitTitle.AutoSize = true;
            this.lblSaitTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblSaitTitle.Font = new System.Drawing.Font("Comic Sans MS", 12.75F);
            this.lblSaitTitle.ForeColor = System.Drawing.Color.Gray;
            this.lblSaitTitle.Location = new System.Drawing.Point(390, 397);
            this.lblSaitTitle.Name = "lblSaitTitle";
            this.lblSaitTitle.Size = new System.Drawing.Size(53, 24);
            this.lblSaitTitle.TabIndex = 22;
            this.lblSaitTitle.Text = "Сайт:";
            // 
            // lblSite
            // 
            this.lblSite.AutoSize = true;
            this.lblSite.BackColor = System.Drawing.Color.Transparent;
            this.lblSite.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblSite.Font = new System.Drawing.Font("Comic Sans MS", 12.75F);
            this.lblSite.ForeColor = System.Drawing.Color.Gray;
            this.lblSite.Location = new System.Drawing.Point(449, 397);
            this.lblSite.Name = "lblSite";
            this.lblSite.Size = new System.Drawing.Size(0, 24);
            this.lblSite.TabIndex = 23;
            this.toolTip1.SetToolTip(this.lblSite, "Посетете нашият сайт");
            this.lblSite.Click += new System.EventHandler(this.lblSite_Click);
            // 
            // lblExit
            // 
            this.lblExit.AutoSize = true;
            this.lblExit.BackColor = System.Drawing.Color.Transparent;
            this.lblExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblExit.Font = new System.Drawing.Font("Comic Sans MS", 28.25F);
            this.lblExit.Image = global::ProjectX.Properties.Resources.Microsoft_Excel_n_icon;
            this.lblExit.Location = new System.Drawing.Point(720, 20);
            this.lblExit.Name = "lblExit";
            this.lblExit.Size = new System.Drawing.Size(56, 53);
            this.lblExit.TabIndex = 28;
            this.lblExit.Text = "   ";
            this.toolTip1.SetToolTip(this.lblExit, "Изход");
            this.lblExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblClear
            // 
            this.lblClear.AutoSize = true;
            this.lblClear.BackColor = System.Drawing.Color.Transparent;
            this.lblClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblClear.Font = new System.Drawing.Font("Comic Sans MS", 38.25F);
            this.lblClear.Image = global::ProjectX.Properties.Resources.mail_delete_icon;
            this.lblClear.Location = new System.Drawing.Point(479, 284);
            this.lblClear.Name = "lblClear";
            this.lblClear.Size = new System.Drawing.Size(75, 72);
            this.lblClear.TabIndex = 30;
            this.lblClear.Text = "   ";
            this.toolTip1.SetToolTip(this.lblClear, "Изчисти");
            this.lblClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblSend
            // 
            this.lblSend.AutoSize = true;
            this.lblSend.BackColor = System.Drawing.Color.Transparent;
            this.lblSend.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblSend.Font = new System.Drawing.Font("Comic Sans MS", 38.25F);
            this.lblSend.Image = global::ProjectX.Properties.Resources.mail_arrow_right_icon;
            this.lblSend.Location = new System.Drawing.Point(579, 284);
            this.lblSend.Name = "lblSend";
            this.lblSend.Size = new System.Drawing.Size(75, 72);
            this.lblSend.TabIndex = 31;
            this.lblSend.Text = "   ";
            this.toolTip1.SetToolTip(this.lblSend, "Изпрати");
            this.lblSend.Click += new System.EventHandler(this.btnSent_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 28.25F);
            this.label3.Image = global::ProjectX.Properties.Resources.Back_icon;
            this.label3.Location = new System.Drawing.Point(20, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 53);
            this.label3.TabIndex = 32;
            this.label3.Text = "   ";
            this.toolTip1.SetToolTip(this.label3, "Назад");
            this.label3.Click += new System.EventHandler(this.btnBack_click);
            // 
            // lblToy
            // 
            this.lblToy.AutoSize = true;
            this.lblToy.BackColor = System.Drawing.Color.Transparent;
            this.lblToy.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblToy.Font = new System.Drawing.Font("Comic Sans MS", 38.25F);
            this.lblToy.Image = global::ProjectX.Properties.Resources.RabbidPorcelaine_icon__1_;
            this.lblToy.Location = new System.Drawing.Point(549, 23);
            this.lblToy.Name = "lblToy";
            this.lblToy.Size = new System.Drawing.Size(75, 72);
            this.lblToy.TabIndex = 29;
            this.lblToy.Text = "   ";
            this.toolTip1.SetToolTip(this.lblToy, "Заек");
            // 
            // txtSubjectSent
            // 
            this.txtSubjectSent.BackColor = System.Drawing.Color.DimGray;
            this.txtSubjectSent.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSubjectSent.Location = new System.Drawing.Point(68, 284);
            this.txtSubjectSent.Name = "txtSubjectSent";
            this.txtSubjectSent.Size = new System.Drawing.Size(210, 16);
            this.txtSubjectSent.TabIndex = 4;
            this.txtSubjectSent.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblSubjectSent
            // 
            this.lblSubjectSent.AutoSize = true;
            this.lblSubjectSent.BackColor = System.Drawing.Color.Transparent;
            this.lblSubjectSent.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSubjectSent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblSubjectSent.Location = new System.Drawing.Point(68, 263);
            this.lblSubjectSent.Name = "lblSubjectSent";
            this.lblSubjectSent.Size = new System.Drawing.Size(67, 18);
            this.lblSubjectSent.TabIndex = 25;
            this.lblSubjectSent.Text = "Отностно";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.BackColor = System.Drawing.Color.Transparent;
            this.lblStatus.Font = new System.Drawing.Font("Comic Sans MS", 12.25F);
            this.lblStatus.ForeColor = System.Drawing.Color.Green;
            this.lblStatus.Location = new System.Drawing.Point(91, 323);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(0, 24);
            this.lblStatus.TabIndex = 26;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Comic Sans MS", 14.25F);
            this.lblTitle.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblTitle.Location = new System.Drawing.Point(100, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(80, 26);
            this.lblTitle.TabIndex = 27;
            this.lblTitle.Text = "Помощ";
            // 
            // FormHelp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProjectX.Properties.Resources.black_minimalistic_background_1920x1080_wallpaper_www_wallpaperto_com_83;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblSend);
            this.Controls.Add(this.lblClear);
            this.Controls.Add(this.lblToy);
            this.Controls.Add(this.lblExit);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblSubjectSent);
            this.Controls.Add(this.txtSubjectSent);
            this.Controls.Add(this.lblSite);
            this.Controls.Add(this.lblSaitTitle);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblAddressTitle);
            this.Controls.Add(this.lblPhoneTitle);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblEmailTitle);
            this.Controls.Add(this.lblMessageSent);
            this.Controls.Add(this.lblInquiry);
            this.Controls.Add(this.txtMessageSent);
            this.Controls.Add(this.txtPhoneSent);
            this.Controls.Add(this.lblPhoneSent);
            this.Controls.Add(this.txtEmailSent);
            this.Controls.Add(this.lblEmailSent);
            this.Controls.Add(this.txtNamesSent);
            this.Controls.Add(this.lblNamesSent);
            this.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormHelp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Help";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}