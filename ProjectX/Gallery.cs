//-----------------------------------------------------------------------
// <copyright file="Gallery.cs" company="Freelancer">
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
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Windows.Forms;
    
    public partial class FormGallery : Form
    {
        #region Variables
        private string path;
        private string album;
        private int skipPictures;
        #endregion

        #region Load
        public FormGallery()
        {
            this.InitializeComponent();
        }

        private void FormGallery_Load(object sender, EventArgs e)
        {
            this.LoadAllAlbums();
        }
        #endregion

        #region General
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

            FormGeneral fmLogin = new FormGeneral();
            fmLogin.Show();
        }
        #endregion
        
        #region Picrutes
        private void Thumbnail(string criteria)
        {
            pnlPictures.Visible = true;
            pnlAlbums.Visible = pnlPictureInfo.Visible = false;

            int location = 0;
            string[] allPictures = Directory.GetFiles(path + album, "*.*");
            string[] pictures;

            if (!string.IsNullOrEmpty(criteria))
            {
                pictures = allPictures.Where(c => c.ToLower().Contains(criteria.ToLower())).Skip(skipPictures).Take(5).ToArray();
            }
            else
            {
                pictures = allPictures.Skip(skipPictures).Take(5).ToArray();
            }
            
            lblAlbumTitle.Text = album;

            Encrypter encrypt = new Encrypter();

            if (pictures.Length == 0)
            {
                return;
            }

            if ((pictures.Length > 5) && ((skipPictures + 5) >= pictures.Length))
            {
                skipPictures = pictures.Length - 5;
            }
            else if ((skipPictures < 0))
            {
                skipPictures = 0;
            }

            for (int i = 0; i < 51; i++)
            {
                pnlPictures.Controls.RemoveByKey("th" + i);
            }

            int counter = 1;

            foreach (string picture in pictures)
            {
                string extension = System.IO.Path.GetExtension(picture);
                string pictureName = picture.Split('\\').Last();

                PictureBox pctBox = new PictureBox();
                pctBox.BorderStyle = BorderStyle.FixedSingle;
                pctBox.Cursor = Cursors.Hand;
                pctBox.Image = Image.FromFile(encrypt.DecryptFile(picture));
                pctBox.Location = new Point(35 + location, 19);
                pctBox.Size = new Size(99, 56);
                pctBox.SizeMode = PictureBoxSizeMode.StretchImage;
                pctBox.Name = "th" + counter;

                this.toolTip1.SetToolTip(pctBox, pictureName.Substring(0, pictureName.Length - extension.Length));
                this.pnlPictures.Controls.Add(pctBox);

                pctBox.Click += new EventHandler(this.showPic);

                counter++;
                location += 119;
            }
        }

        private void btnShowAddFiles_click(object sender, EventArgs e)
        {
            ddlAlbums.DataSource = Albums();
            ddlAlbums.SelectedIndexChanged += new EventHandler(ddlAddFilesAlbums_SelectedIndexChanged);


            lblAlbumStatus.Text = null;
            pictureView.Visible = btnAddAlbum.Visible = btnCancelAddAlbum.Visible = btnSaveAlbum.Visible = false;
            ddlAlbums.Visible = pnlAlbums.Visible = true;
            lblAlbumError.Text = "Изберете албум";

        }

        private void ddlAddFilesAlbums_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddlAlbums.SelectedIndex > 0)
            {
                album = ddlAlbums.SelectedValue.ToString();

                OpenFileDialog fileDialog = new OpenFileDialog();
                fileDialog.CheckFileExists = true;
                fileDialog.AddExtension = true;
                fileDialog.Multiselect = true;
                fileDialog.Filter = "Image files (*.png)|*.png";

                Encrypter encrypt = new ProjectX.Encrypter();

                if (fileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    foreach (string fileName in fileDialog.FileNames)
                    {
                        string newImage = this.path + "\\" + album + "\\" + Path.GetFileName(fileName);

                        if (File.Exists(newImage))
                        {
                            MessageBox.Show("Съществува един или повече файла с еднакви имена.");
                            return;
                        }
                    }

                    foreach (string fileName in fileDialog.FileNames)
                    {
                        string newImage = this.path + "\\" + album + "\\" + Path.GetFileName(fileName);

                        File.Copy(fileName, newImage);

                        encrypt.EncryptFile(newImage);
                    }

                    this.Thumbnail(string.Empty);

                    MessageBox.Show("Файловете са добавени успешно.");
                }
            }
        }

        private void showPic(object sender, EventArgs e)
        {
            // Sender is thumbnail image that is double clicked
            pnlAlbums.Visible = pnlSearch.Visible = false;
            pictureView.Visible = true;
            pictureView.Image = ((PictureBox)sender).Image;
            pictureView.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void btnShowSearchForm_Click(object sender, EventArgs e)
        {
            txtSearchCriteria.Text = null;
            pnlSearch.Visible = true;
            btnSearchImage.Visible = btnSearch.Visible = txtSearchCriteria.Visible = lblSearchTitle.Visible = true;
            pnlAlbums.Visible = pictureView.Visible = btnAddAlbum.Visible = false;

            ddlAlbums.Visible = pnlAlbums.Visible = true;
        }

        private void btnSearchImage_Click(object sender, EventArgs e)
        {
            this.Thumbnail(txtSearchCriteria.Text);
        }

        private void btnRemovePicture_Click(object sender, EventArgs e)
        {
            PictureBox pctBox = (PictureBox)sender;

            string thids = this.ProductName;

            DialogResult confirmMessage = MessageBox.Show("Сигурни ли сте, че искате да изтриете ?", "Изтриване", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (confirmMessage.Equals(DialogResult.Yes))
            {


            }
        }
        
        private void btnNext_Click(object sender, EventArgs e)
        {
            this.skipPictures += 1;
            this.Thumbnail(string.Empty);
            
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            this.skipPictures -= 1;
            this.Thumbnail(string.Empty);
        }
        #endregion

        #region Albums

        private void LoadAllAlbums()
        {
            path = Directory.GetCurrentDirectory().Replace("bin\\Debug", "").Replace("bin\\Release", "");
            path = path + @"Files\1\Gallery\";

            string[] albums = Albums();

            if (albums.Length < 2)
            {
                ddlAlbums.DataSource = albums;

                pnlPictures.Visible = lblPrevious.Visible = lblNext.Visible = pictureView.Visible = false;
                lblAlbumError.Visible = pnlPictureInfo.Visible = true;
                lblAlbumError.Text = "Няма създадени албуми";
            }
            else if (albums.Length == 2)
            {
                album = albums[1];
                Thumbnail(string.Empty);
            }
            else if (albums.Length > 1)
            {
                ddlAlbums.DataSource = albums;

                pnlPictures.Visible = lblPrevious.Visible = lblNext.Visible = pictureView.Visible = btnAddAlbum.Visible = false;
                lblAlbumError.Visible = pnlPictureInfo.Visible = true;
                lblAlbumError.Text = "Изберете албум";
                return;
            }
        }

        #region Buttons
        
        private void btnAddAlbum_click(object sender, EventArgs e)
        {
            this.lblAlbumStatus.Text = null;
            this.ddlAlbums.Visible = this.lblAlbumsTitle.Visible = this.btnAddAlbum.Visible = false;
            this.btnSaveAlbum.Visible = this.btnCancelAddAlbum.Visible = true;
        }

        private void btnShowAddAlbumForm_click(object sender, EventArgs e)
        {
            lblAlbumStatus.Text = null;
            ddlAlbums.Visible = lblAlbumsTitle.Visible = btnAddAlbum.Visible = false;
            btnSaveAlbum.Visible = btnCancelAddAlbum.Visible = lblAlbumError.Visible = pnlAlbums.Visible = true;
        }

        private void btnShowAllAlbums(object sender, EventArgs e)
        {
            lblAlbumStatus.Text = null;
            pictureView.Visible = btnAddAlbum.Visible = btnCancelAddAlbum.Visible = btnSaveAlbum.Visible = false;
            ddlAlbums.Visible = pnlAlbums.Visible = true;
            lblAlbumError.Text = "Изберете албум";

            ddlAlbums.DataSource = Albums();

            ddlAlbums.SelectedIndexChanged -= new EventHandler(ddlAddFilesAlbums_SelectedIndexChanged);
            ddlAlbums.SelectedIndexChanged += new EventHandler(ddlAlbums_SelectedIndexChanged);
        }

        private void btnCancelAddAlbum_click(object sender, EventArgs e)
        {
            txtAlbumTitle.Text = null;
            ddlAlbums.Visible = lblAlbumsTitle.Visible = btnAddAlbum.Visible = true;
            btnSaveAlbum.Visible = btnCancelAddAlbum.Visible = false;
        }

        private void btnSaveAlbum_click(object sender, EventArgs e)
        {
            if (!Directory.Exists(path + txtAlbumTitle.Text))
            {
                Directory.CreateDirectory(path + txtAlbumTitle.Text);

                txtAlbumTitle.Text = null;
                ddlAlbums.Visible = lblAlbumsTitle.Visible = btnAddAlbum.Visible = true;
                btnSaveAlbum.Visible = btnCancelAddAlbum.Visible = false;

                this.LoadAllAlbums();

                lblAlbumStatus.Location = new Point(90, 175);
                lblAlbumStatus.Text = "Албума е добавен успешно";
                lblAlbumStatus.ForeColor = Color.Green;
            }
            else
            {
                lblAlbumStatus.Location = new Point(90, 40);
                lblAlbumStatus.Text = "Съществува албум с това име.";
                lblAlbumStatus.ForeColor = Color.Red;
            }
        }

        private void btnExtractAlbum_Click(object sender, EventArgs e)
        {
            var existingFilePaths = Directory.GetFiles(path + "\\" + album + "\\", "*.*", SearchOption.AllDirectories);

            FolderBrowserDialog folderDialog = new FolderBrowserDialog();
            
            Encrypter encrypt = new ProjectX.Encrypter();

            if (folderDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string newPath = folderDialog.SelectedPath;

                foreach (string fileName in existingFilePaths)
                {
                    string newImage = newPath + "\\" + fileName.Split('\\').Last();

                    if (File.Exists(newImage))
                    {
                        MessageBox.Show("Съществуват един или повече файла с еднакви имена.");
                        return;
                    }
                }

                foreach (string fileName in existingFilePaths)
                {
                    string newImage = newPath + "\\" + Path.GetFileName(fileName);

                    File.Copy(fileName, newImage);

                    encrypt.EncryptFile(newImage);
                }

                MessageBox.Show("Файловете са записани успешно успешно.");
            }
        }
        #endregion

        private void ddlAlbums_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddlAlbums.SelectedIndex > 0)
            {
                album = ddlAlbums.SelectedValue.ToString();
                Thumbnail(string.Empty);
                pnlSearch.Visible = pnlAlbums.Visible = false;
                lblPrevious.Visible = lblNext.Visible = true;
            }
        }

        #endregion

        #region Misc
        private string[] Albums()
        {
            string[] onlyAlbums = Directory.GetDirectories(path);
            string[] albums = new string [onlyAlbums.Length + 1];

            for (int i = 0; i < albums.Length; i++)
            {
                if (i == 0)
                {
                    albums[i] = "                              Изберете албум";
                }
                else
                {
                    albums[i] = onlyAlbums[i - 1].Split('\\').Last();
                }
            }

            return albums;
        }
        #endregion
    }
}