//-----------------------------------------------------------------------
// <copyright file="Settings.Designer.cs" company="Freelancer">
// Copyright (c) Ilian Stoyanov. All rights reserved.
// </copyright>
// <author>Ilian Stoyanov</author>
//-----------------------------------------------------------------------

namespace ProjectX
{
    partial class FormSettings
    {
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label lblExit;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblToy;
        private System.Windows.Forms.Label lblBack;

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
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.lblExit = new System.Windows.Forms.Label();
            this.lblBack = new System.Windows.Forms.Label();
            this.lblToy = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
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
            this.lblExit.TabIndex = 16;
            this.lblExit.Text = "   ";
            this.toolTip1.SetToolTip(this.lblExit, "Изход");
            this.lblExit.Click += new System.EventHandler(this.btnExit_Click);
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
            this.lblBack.TabIndex = 30;
            this.lblBack.Text = "   ";
            this.toolTip1.SetToolTip(this.lblBack, "Назад");
            this.lblBack.Click += new System.EventHandler(this.btnBack_click);
            // 
            // lblToy
            // 
            this.lblToy.AutoSize = true;
            this.lblToy.BackColor = System.Drawing.Color.Transparent;
            this.lblToy.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblToy.Font = new System.Drawing.Font("Comic Sans MS", 38.25F);
            this.lblToy.Image = global::ProjectX.Properties.Resources.BearPorcelaine_icon;
            this.lblToy.Location = new System.Drawing.Point(356, 25);
            this.lblToy.Name = "lblToy";
            this.lblToy.Size = new System.Drawing.Size(75, 72);
            this.lblToy.TabIndex = 29;
            this.lblToy.Text = "   ";
            this.toolTip1.SetToolTip(this.lblToy, "Мечка");
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Comic Sans MS", 14.25F);
            this.lblTitle.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblTitle.Location = new System.Drawing.Point(100, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(100, 26);
            this.lblTitle.TabIndex = 28;
            this.lblTitle.Text = "Настойки";
            // 
            // FormSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProjectX.Properties.Resources.black_minimalistic_background_1920x1080_wallpaper_www_wallpaperto_com_83;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblBack);
            this.Controls.Add(this.lblToy);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblExit);
            this.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}