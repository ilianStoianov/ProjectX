//-----------------------------------------------------------------------
// <copyright file="Video.cs" company="Freelancer">
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

    public partial class FormVideo : Form
    {
        public FormVideo()
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

        private void btnBack_click(object sender, EventArgs e)
        {
            this.Close();

            FormGeneral fmGeneral = new FormGeneral();
            fmGeneral.Show();
        }
    }
}
