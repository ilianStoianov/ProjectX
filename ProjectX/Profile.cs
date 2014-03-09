//-----------------------------------------------------------------------
// <copyright file="Profile.cs" company="Freelancer">
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

    public partial class FormProfile : Form
    {
        public FormProfile()
        {
            this.InitializeComponent();
        }

        private void btnExit_click(object sender, EventArgs e)
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

        private void btnBack_click(object sender, EventArgs e)
        {
            this.Close();

            FormGeneral fmLogin = new FormGeneral();
            fmLogin.Show();
        }

        private void btnEditNames_click(object sender, EventArgs e)
        {
            this.txtNames.Visible = this.btnSaveName.Visible = this.btnCancelName.Visible = true;
            this.txtNames.Text = this.lblNames.Text;
            this.lblNames.Visible = false;
        }

        private void btnSaveNameChanges_click(object sender, EventArgs e)
        {
            this.txtNames.Text = null;
            this.txtNames.Visible = this.btnSaveName.Visible = this.btnCancelName.Visible = false;
            this.lblNames.Visible = true;
        }

        private void btnCancelNameChanges_Click(object sender, EventArgs e)
        {
            this.txtNames.Text = null;
            this.txtNames.Visible = this.btnSaveName.Visible = this.btnCancelName.Visible = false;
            this.lblNames.Visible = true;
        }

        private void btnShowUpdatePicture(object sender, EventArgs e)
        {
            //lblChangePicture.Visible = true;
            lblChangePicture.Show();
        }

        private void btnHideUpdatePicture(object sender, EventArgs e)
        {
            this.lblChangePicture.Visible = false;
        }

        private void btnChangePicture_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
        }

        private void btnEditPhone_Click(object sender, EventArgs e)
        {
            txtPhone.Visible = btnSavePhone.Visible = btnCancelPhone.Visible = true;
            txtPhone.Text = lblPhone.Text;
            lblPhone.Visible = false;
        }

        private void btnSavePhoneChanges_Click(object sender, EventArgs e)
        {
            this.txtPhone.Text = null;
            this.txtPhone.Visible = this.btnSavePhone.Visible = this.btnCancelPhone.Visible = false;
            this.lblPhone.Visible = true;
        }

        private void btnCancelPhoneChanges_Click(object sender, EventArgs e)
        {
            this.txtPhone.Text = null;
            this.txtPhone.Visible = this.btnSavePhone.Visible = this.btnCancelPhone.Visible = false;
            this.lblPhone.Visible = true;
        }
    }
}
