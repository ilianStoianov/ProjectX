//-----------------------------------------------------------------------
// <copyright file="Login.cs" company="Freelancer">
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
    using System.Xml.Linq;
    using System.IO;
    using System.Security.Cryptography;

    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            this.InitializeComponent();
        }

        private void btnLoginClose_Click(object sender, EventArgs e)
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

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (this.chkRememberMe.Checked)
            {
            }

            string xmlPath = Directory.GetCurrentDirectory().Replace("bin\\Debug", "").Replace("bin\\Release", "");
            xmlPath = xmlPath + "Users\\Users.xml";

            XDocument xmlFile = XDocument.Load("C:\\Users\\User\\Desktop\\ProjectX\\ProjectX\\Users\\Users.xml");

            XElement user = (XElement)xmlFile.Root.Elements().FirstOrDefault(usr => usr.Attribute("username").Value != txtName.Text.ToLower() || usr.Attribute("email").Value != txtName.Text.ToLower());

            if (user != null)
            {
                if ((user.Attribute("username").Value == txtName.Text || user.Attribute("email").Value == txtName.Text) && user.Attribute("password").Value == txtPassword.Text)
                {
                    this.Hide();

                    FormGeneral fmGeneral = new FormGeneral();
                    fmGeneral.Show();
                }
            }
        }

        private void lblHelp_Click(object sender, EventArgs e)
        {
            this.Hide();

            FormHelp fmHelp = new FormHelp();
            fmHelp.Show();
        }
    }
}
