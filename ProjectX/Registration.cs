//-----------------------------------------------------------------------
// <copyright file="Registration.cs" company="Freelancer">
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

    public partial class FormRegistration : Form
    {
        public FormRegistration()
        {
            this.InitializeComponent();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();

            FormLogin fmLogin = new FormLogin();
            fmLogin.Show();
        }

        private void lblCancel_Click(object sender, EventArgs e)
        {
            this.Close();

            FormGeneral fmGeneral = new FormGeneral();
            fmGeneral.Show();
        }
    }
}
