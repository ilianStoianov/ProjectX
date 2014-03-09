//-----------------------------------------------------------------------
// <copyright file="Registration.Designer.cs" company="Freelancer">
// Copyright (c) Ilian Stoyanov. All rights reserved.
// </copyright>
// <author>Ilian Stoyanov</author>
//-----------------------------------------------------------------------

namespace ProjectX
{
    partial class FormRegistration
    {
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblCancel;
        private System.Windows.Forms.TextBox txtPhoneSent;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lblConfirmPassword;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblBack;
        private System.Windows.Forms.Label lblToy;
        private System.Windows.Forms.Label lblExit;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.ToolTip toolTip1;

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
            this.btnClose = new System.Windows.Forms.Button();
            this.lblCancel = new System.Windows.Forms.Label();
            this.txtPhoneSent = new System.Windows.Forms.TextBox();
            this.lblUserName = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lblConfirmPassword = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblBack = new System.Windows.Forms.Label();
            this.lblToy = new System.Windows.Forms.Label();
            this.lblExit = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(794, 444);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(87, 27);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // lblCancel
            // 
            this.lblCancel.AutoSize = true;
            this.lblCancel.BackColor = System.Drawing.Color.Transparent;
            this.lblCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblCancel.Location = new System.Drawing.Point(114, 347);
            this.lblCancel.Name = "lblCancel";
            this.lblCancel.Size = new System.Drawing.Size(37, 15);
            this.lblCancel.TabIndex = 2;
            this.lblCancel.Text = "Отказ";
            this.lblCancel.Click += new System.EventHandler(this.lblCancel_Click);
            // 
            // txtPhoneSent
            // 
            this.txtPhoneSent.Location = new System.Drawing.Point(76, 120);
            this.txtPhoneSent.Name = "txtPhoneSent";
            this.txtPhoneSent.Size = new System.Drawing.Size(210, 23);
            this.txtPhoneSent.TabIndex = 10;
            this.txtPhoneSent.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.BackColor = System.Drawing.Color.Transparent;
            this.lblUserName.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblUserName.ForeColor = System.Drawing.Color.Silver;
            this.lblUserName.Location = new System.Drawing.Point(73, 99);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(138, 18);
            this.lblUserName.TabIndex = 11;
            this.lblUserName.Text = "Потребителско име:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(76, 166);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(210, 23);
            this.textBox1.TabIndex = 12;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.BackColor = System.Drawing.Color.Transparent;
            this.lblPassword.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPassword.ForeColor = System.Drawing.Color.Silver;
            this.lblPassword.Location = new System.Drawing.Point(73, 146);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(61, 18);
            this.lblPassword.TabIndex = 13;
            this.lblPassword.Text = "Парола:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(76, 215);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(210, 23);
            this.textBox2.TabIndex = 14;
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblConfirmPassword
            // 
            this.lblConfirmPassword.AutoSize = true;
            this.lblConfirmPassword.BackColor = System.Drawing.Color.Transparent;
            this.lblConfirmPassword.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblConfirmPassword.ForeColor = System.Drawing.Color.Silver;
            this.lblConfirmPassword.Location = new System.Drawing.Point(73, 194);
            this.lblConfirmPassword.Name = "lblConfirmPassword";
            this.lblConfirmPassword.Size = new System.Drawing.Size(124, 18);
            this.lblConfirmPassword.TabIndex = 15;
            this.lblConfirmPassword.Text = "Повторно парола:";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(76, 263);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(210, 23);
            this.textBox3.TabIndex = 16;
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.Silver;
            this.label3.Location = new System.Drawing.Point(73, 242);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 18);
            this.label3.TabIndex = 17;
            this.label3.Text = "Телефон";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(76, 311);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(210, 23);
            this.textBox4.TabIndex = 18;
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.Silver;
            this.label4.Location = new System.Drawing.Point(73, 290);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 18);
            this.label4.TabIndex = 19;
            this.label4.Text = "Телефон";
            // 
            // lblBack
            // 
            this.lblBack.AutoSize = true;
            this.lblBack.BackColor = System.Drawing.Color.Transparent;
            this.lblBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblBack.Font = new System.Drawing.Font("Comic Sans MS", 28.25F);
            this.lblBack.Image = global::ProjectX.Properties.Resources.Back_icon;
            this.lblBack.Location = new System.Drawing.Point(20, 17);
            this.lblBack.Name = "lblBack";
            this.lblBack.Size = new System.Drawing.Size(56, 53);
            this.lblBack.TabIndex = 67;
            this.lblBack.Text = "   ";
            this.toolTip1.SetToolTip(this.lblBack, "Назад");
            // 
            // lblToy
            // 
            this.lblToy.AutoSize = true;
            this.lblToy.BackColor = System.Drawing.Color.Transparent;
            this.lblToy.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblToy.Font = new System.Drawing.Font("Comic Sans MS", 38.25F);
            this.lblToy.Image = global::ProjectX.Properties.Resources.PlatipusPorcelain_icon;
            this.lblToy.Location = new System.Drawing.Point(408, 29);
            this.lblToy.Name = "lblToy";
            this.lblToy.Size = new System.Drawing.Size(75, 72);
            this.lblToy.TabIndex = 66;
            this.lblToy.Text = "   ";
            this.toolTip1.SetToolTip(this.lblToy, "Патица");
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
            this.lblExit.TabIndex = 65;
            this.lblExit.Text = "   ";
            this.toolTip1.SetToolTip(this.lblExit, "Изход");
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Comic Sans MS", 14.25F);
            this.lblTitle.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblTitle.Location = new System.Drawing.Point(100, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(126, 26);
            this.lblTitle.TabIndex = 64;
            this.lblTitle.Text = "Регистрация";
            // 
            // FormRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProjectX.Properties.Resources.black_minimalistic_background_1920x1080_wallpaper_www_wallpaperto_com_83;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblBack);
            this.Controls.Add(this.lblToy);
            this.Controls.Add(this.lblExit);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.lblConfirmPassword);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txtPhoneSent);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.lblCancel);
            this.Controls.Add(this.btnClose);
            this.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormRegistration";
            this.Text = "Registration";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}