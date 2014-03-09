//-----------------------------------------------------------------------
// <copyright file="Help.cs" company="Freelancer">
// Copyright (c) Ilian Stoyanov. All rights reserved.
// </copyright>
// <author>Ilian Stoyanov</author>
//-----------------------------------------------------------------------

namespace ProjectX
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Configuration;
    using System.Data;
    using System.Diagnostics;
    using System.Drawing;
    using System.Linq;
    using System.Net;
    using System.Net.Mail;
    using System.Text;
    using System.Windows.Forms;

    public partial class FormHelp : Form
    {
        public FormHelp()
        {
            this.InitializeComponent();

            this.lblPhone.Text = ConfigurationManager.AppSettings["supportPhone"];
            this.lblEmail.Text = ConfigurationManager.AppSettings["supportEmail"];
            this.lblAddress.Text = ConfigurationManager.AppSettings["supportAddress"];
            this.lblSite.Text = ConfigurationManager.AppSettings["supportSite"];
        }

        public bool CheckInternetConnection()
        {
            HttpWebRequest req;
            HttpWebResponse resp;
            try
            {
                req = (HttpWebRequest)WebRequest.Create("http://www.google.com");
                resp = (HttpWebResponse)req.GetResponse();

                if (resp.StatusCode.ToString().Equals("OK"))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception exc)
            {
                return false;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtNamesSent.Text = txtEmailSent.Text = txtPhoneSent.Text = txtSubjectSent.Text = txtMessageSent.Text = null;
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

        private void lblSite_Click(object sender, EventArgs e)
        {
            ProcessStartInfo sInfo = new ProcessStartInfo(ConfigurationManager.AppSettings["supportSite"]);
            Process.Start(sInfo);
        }

        private void btnSent_Click(object sender, EventArgs e)
        {
            try
            {
                string from = txtEmailSent.Text.Trim().ToLower();

                MailMessage mail = new MailMessage();

                mail.To.Add(ConfigurationManager.AppSettings["supportEmail"].Trim().ToLower());
                mail.From = new MailAddress(from, txtNamesSent.Text, System.Text.Encoding.UTF8);
                mail.Subject = txtSubjectSent.Text;
                mail.SubjectEncoding = System.Text.Encoding.UTF8;
                mail.Body = txtMessageSent.Text;
                mail.BodyEncoding = System.Text.Encoding.UTF8;
                mail.IsBodyHtml = true;
                mail.Priority = MailPriority.High;
                SmtpClient client = new SmtpClient();

                client.Credentials = new System.Net.NetworkCredential(ConfigurationManager.AppSettings["creditinalEmail"].Trim().ToLower(), ConfigurationManager.AppSettings["creditinalPassword"].Trim().ToLower());
                client.Port = 587;
                client.Host = "smtp.gmail.com";
                client.EnableSsl = true;
            
                client.Send(mail);
                lblStatus.Text = "Съобщението е успешно изпратено.";
                lblStatus.ForeColor = Color.Green;

                txtNamesSent.Enabled = txtEmailSent.Enabled = txtPhoneSent.Enabled = txtSubjectSent.Enabled =
                    txtMessageSent.Enabled = lblSend.Enabled = lblClear.Enabled = false;
            }
            catch
            {
                lblStatus.Text = "Възникна проблем. Моля опитайте отново.";
                lblStatus.ForeColor = Color.Red;
            }
        }
    }
}
