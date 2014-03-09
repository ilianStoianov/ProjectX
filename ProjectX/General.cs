//-----------------------------------------------------------------------
// <copyright file="General.cs" company="Freelancer">
// Copyright (c) Ilian Stoyanov. All rights reserved.
// </copyright>
// <author>Ilian Stoyanov</author>
//-----------------------------------------------------------------------

namespace ProjectX
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Linq;
    using System.Text;
    using System.Windows.Forms;

    public partial class FormGeneral : Form
    {
        public FormGeneral()
        {
            this.InitializeComponent();            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult confirmMessage = MessageBox.Show("Сигурни ли сте?", "Изход", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (confirmMessage.Equals(DialogResult.Yes))
            {
                // Closing all opened forms
                foreach (Form fm in Application.OpenForms)
                {
                    fm.Close();
                }
            }
        }

        private void btnGallery_Click(object sender, EventArgs e)
        {
            //this.Close();

            FormGallery fmGallery = new FormGallery();
            fmGallery.Show();
        }

        private void btnVideo_Click(object sender, EventArgs e)
        {
            this.Close();

            FormVideo fmVideo = new FormVideo();
            fmVideo.Show();
        }

        private void btnStatistic_Click(object sender, EventArgs e)
        {
            this.Close();

            FormStatistics fmStatistic = new FormStatistics();
            fmStatistic.Show();
        }
        
        private void btnProfile_Click(object sender, EventArgs e)
        {
            this.Close();

            FormProfile fmProfile = new FormProfile();
            fmProfile.Show();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            this.Close();

            FormSettings fmSettings = new FormSettings();
            fmSettings.Show();
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            this.Close();

            FormHelp fmHelp = new FormHelp();
            fmHelp.Show();
        }
    }
}