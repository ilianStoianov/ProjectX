//-----------------------------------------------------------------------
// <copyright file="General.Designer.cs" company="Freelancer">
// Copyright (c) Ilian Stoyanov. All rights reserved.
// </copyright>
// <author>Ilian Stoyanov</author>
//-----------------------------------------------------------------------

namespace ProjectX
{
    partial class FormGeneral
    {
        private System.Windows.Forms.ContextMenuStrip cntMenuGeneral;
        private System.Windows.Forms.ToolStripMenuItem галерияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem профилToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem настройкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem изходToolStripMenuItem;
        private System.Windows.Forms.Label lblGallery;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblStatistic;
        private System.Windows.Forms.Label lblSettings;
        private System.Windows.Forms.Label lblVideo;
        private System.Windows.Forms.Label lblToy;
        private System.Windows.Forms.Label lblProfile;
        private System.Windows.Forms.Label lblClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;

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
            this.cntMenuGeneral = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.галерияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.профилToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.настройкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.изходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblGallery = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblStatistic = new System.Windows.Forms.Label();
            this.lblSettings = new System.Windows.Forms.Label();
            this.lblVideo = new System.Windows.Forms.Label();
            this.lblProfile = new System.Windows.Forms.Label();
            this.lblClose = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblToy = new System.Windows.Forms.Label();
            this.cntMenuGeneral.SuspendLayout();
            this.SuspendLayout();
            // 
            // cntMenuGeneral
            // 
            this.cntMenuGeneral.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.галерияToolStripMenuItem,
            this.профилToolStripMenuItem,
            this.настройкиToolStripMenuItem,
            this.изходToolStripMenuItem});
            this.cntMenuGeneral.Name = "cntMenuGeneral";
            this.cntMenuGeneral.Size = new System.Drawing.Size(144, 92);
            // 
            // галерияToolStripMenuItem
            // 
            this.галерияToolStripMenuItem.Name = "галерияToolStripMenuItem";
            this.галерияToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.галерияToolStripMenuItem.Text = "Галерия";
            this.галерияToolStripMenuItem.Click += new System.EventHandler(this.btnGallery_Click);
            // 
            // профилToolStripMenuItem
            // 
            this.профилToolStripMenuItem.Name = "профилToolStripMenuItem";
            this.профилToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.профилToolStripMenuItem.Text = "Профил";
            this.профилToolStripMenuItem.Click += new System.EventHandler(this.btnProfile_Click);
            // 
            // настройкиToolStripMenuItem
            // 
            this.настройкиToolStripMenuItem.Name = "настройкиToolStripMenuItem";
            this.настройкиToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.настройкиToolStripMenuItem.Text = "Настройки";
            this.настройкиToolStripMenuItem.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // изходToolStripMenuItem
            // 
            this.изходToolStripMenuItem.Name = "изходToolStripMenuItem";
            this.изходToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.X)));
            this.изходToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.изходToolStripMenuItem.Text = "Изход";
            this.изходToolStripMenuItem.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblGallery
            // 
            this.lblGallery.AutoSize = true;
            this.lblGallery.BackColor = System.Drawing.Color.Transparent;
            this.lblGallery.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblGallery.Font = new System.Drawing.Font("Comic Sans MS", 68.25F);
            this.lblGallery.Image = global::ProjectX.Properties.Resources.photo_icon;
            this.lblGallery.Location = new System.Drawing.Point(69, 161);
            this.lblGallery.Name = "lblGallery";
            this.lblGallery.Size = new System.Drawing.Size(136, 128);
            this.lblGallery.TabIndex = 5;
            this.lblGallery.Text = "   ";
            this.toolTip1.SetToolTip(this.lblGallery, "Галерия");
            this.lblGallery.Click += new System.EventHandler(this.btnGallery_Click);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.BackColor = System.Drawing.Color.Transparent;
            this.lblEmail.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblEmail.Font = new System.Drawing.Font("Comic Sans MS", 48.25F);
            this.lblEmail.Image = global::ProjectX.Properties.Resources.inbox_icon;
            this.lblEmail.Location = new System.Drawing.Point(692, 360);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(96, 91);
            this.lblEmail.TabIndex = 6;
            this.lblEmail.Text = "   ";
            this.toolTip1.SetToolTip(this.lblEmail, "Помощ");
            this.lblEmail.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // lblStatistic
            // 
            this.lblStatistic.AutoSize = true;
            this.lblStatistic.BackColor = System.Drawing.Color.Transparent;
            this.lblStatistic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblStatistic.Font = new System.Drawing.Font("Comic Sans MS", 68.25F);
            this.lblStatistic.Image = global::ProjectX.Properties.Resources.keynote_on_icon;
            this.lblStatistic.Location = new System.Drawing.Point(331, 161);
            this.lblStatistic.Name = "lblStatistic";
            this.lblStatistic.Size = new System.Drawing.Size(136, 128);
            this.lblStatistic.TabIndex = 7;
            this.lblStatistic.Text = "   ";
            this.toolTip1.SetToolTip(this.lblStatistic, "Статистика");
            this.lblStatistic.Click += new System.EventHandler(this.btnStatistic_Click);
            // 
            // lblSettings
            // 
            this.lblSettings.AutoSize = true;
            this.lblSettings.BackColor = System.Drawing.Color.Transparent;
            this.lblSettings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblSettings.Font = new System.Drawing.Font("Comic Sans MS", 68.25F);
            this.lblSettings.Image = global::ProjectX.Properties.Resources.info_icon;
            this.lblSettings.Location = new System.Drawing.Point(587, 161);
            this.lblSettings.Name = "lblSettings";
            this.lblSettings.Size = new System.Drawing.Size(136, 128);
            this.lblSettings.TabIndex = 8;
            this.lblSettings.Text = "   ";
            this.toolTip1.SetToolTip(this.lblSettings, "Настройки");
            this.lblSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // lblVideo
            // 
            this.lblVideo.AutoSize = true;
            this.lblVideo.BackColor = System.Drawing.Color.Transparent;
            this.lblVideo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblVideo.Font = new System.Drawing.Font("Comic Sans MS", 68.25F);
            this.lblVideo.Image = global::ProjectX.Properties.Resources.Videos_icon;
            this.lblVideo.Location = new System.Drawing.Point(193, 161);
            this.lblVideo.Name = "lblVideo";
            this.lblVideo.Size = new System.Drawing.Size(136, 128);
            this.lblVideo.TabIndex = 9;
            this.lblVideo.Text = "   ";
            this.toolTip1.SetToolTip(this.lblVideo, "Видео");
            this.lblVideo.Click += new System.EventHandler(this.btnVideo_Click);
            // 
            // lblProfile
            // 
            this.lblProfile.AutoSize = true;
            this.lblProfile.BackColor = System.Drawing.Color.Transparent;
            this.lblProfile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblProfile.Font = new System.Drawing.Font("Comic Sans MS", 68.25F);
            this.lblProfile.Image = global::ProjectX.Properties.Resources.invisible_icon;
            this.lblProfile.Location = new System.Drawing.Point(458, 161);
            this.lblProfile.Name = "lblProfile";
            this.lblProfile.Size = new System.Drawing.Size(136, 128);
            this.lblProfile.TabIndex = 11;
            this.lblProfile.Text = "   ";
            this.toolTip1.SetToolTip(this.lblProfile, "Профил");
            this.lblProfile.Click += new System.EventHandler(this.btnProfile_Click);
            // 
            // lblClose
            // 
            this.lblClose.AutoSize = true;
            this.lblClose.BackColor = System.Drawing.Color.Transparent;
            this.lblClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblClose.Font = new System.Drawing.Font("Comic Sans MS", 28.25F);
            this.lblClose.Image = global::ProjectX.Properties.Resources.Microsoft_Excel_n_icon;
            this.lblClose.Location = new System.Drawing.Point(720, 20);
            this.lblClose.Name = "lblClose";
            this.lblClose.Size = new System.Drawing.Size(56, 53);
            this.lblClose.TabIndex = 12;
            this.lblClose.Text = "   ";
            this.toolTip1.SetToolTip(this.lblClose, "Изход");
            this.lblClose.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 35.25F);
            this.label1.Image = global::ProjectX.Properties.Resources.arrow_next1;
            this.label1.Location = new System.Drawing.Point(726, 192);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 67);
            this.label1.TabIndex = 13;
            this.label1.Text = "   ";
            this.toolTip1.SetToolTip(this.label1, "Следващ");
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 35.25F);
            this.label3.Image = global::ProjectX.Properties.Resources.arrow_previous1;
            this.label3.Location = new System.Drawing.Point(-2, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 67);
            this.label3.TabIndex = 14;
            this.label3.Text = "   ";
            this.toolTip1.SetToolTip(this.label3, "Предходен");
            // 
            // lblToy
            // 
            this.lblToy.AutoSize = true;
            this.lblToy.BackColor = System.Drawing.Color.Transparent;
            this.lblToy.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblToy.Font = new System.Drawing.Font("Comic Sans MS", 38.25F);
            this.lblToy.Image = global::ProjectX.Properties.Resources.SheepPorcelaine_icon;
            this.lblToy.Location = new System.Drawing.Point(212, 30);
            this.lblToy.Name = "lblToy";
            this.lblToy.Size = new System.Drawing.Size(75, 72);
            this.lblToy.TabIndex = 10;
            this.lblToy.Text = "   ";
            this.toolTip1.SetToolTip(this.lblToy, "Овца");
            // 
            // FormGeneral
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProjectX.Properties.Resources.black_minimalistic_background_1920x1080_wallpaper_www_wallpaperto_com_83;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ContextMenuStrip = this.cntMenuGeneral;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblClose);
            this.Controls.Add(this.lblProfile);
            this.Controls.Add(this.lblToy);
            this.Controls.Add(this.lblVideo);
            this.Controls.Add(this.lblSettings);
            this.Controls.Add(this.lblStatistic);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblGallery);
            this.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormGeneral";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "General";
            this.cntMenuGeneral.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}