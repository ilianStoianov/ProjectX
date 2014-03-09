//-----------------------------------------------------------------------
// <copyright file="Gallery.Designer.cs" company="Freelancer">
// Copyright (c) Ilian Stoyanov. All rights reserved.
// </copyright>
// <author>Ilian Stoyanov</author>
//-----------------------------------------------------------------------

namespace ProjectX
{
    partial class FormGallery
    {
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox pictureView;
        private System.Windows.Forms.Panel pnlPictures;
        private System.Windows.Forms.Label lblAlbumTitle;
        private System.Windows.Forms.ContextMenuStrip cntMenuViewImage;
        private System.Windows.Forms.ToolStripMenuItem завъртанеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem лявоToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem гореToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem дясноToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem долуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem уразмеряваToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip cntMenuThumbnail;
        private System.Windows.Forms.ContextMenuStrip cntMenuGeneral;
        private System.Windows.Forms.ToolStripMenuItem помощToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem изходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem премахниToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip cntMenuPicture;
        private System.Windows.Forms.ToolStripMenuItem вижToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem премахниToolStripMenuItem1;
        private System.Windows.Forms.Label lblNext;
        private System.Windows.Forms.Label lblPrevious;
        private System.Windows.Forms.Label btnEditAlbum;
        private System.Windows.Forms.Label lblExit;
        private System.Windows.Forms.Label lblToy;
        private System.Windows.Forms.Label lblBack;
        private System.Windows.Forms.Label lblAlbumError;
        private System.Windows.Forms.Panel pnlAlbums;
        private System.Windows.Forms.Label lblAlbumsTitle;
        private System.Windows.Forms.ComboBox ddlAlbums;
        private System.Windows.Forms.TextBox txtAlbumTitle;
        private System.Windows.Forms.Label lblAddAlbum;
        private System.Windows.Forms.Label btnAddAlbum;
        private System.Windows.Forms.Label btnCancelAddAlbum;
        private System.Windows.Forms.Label btnSaveAlbum;
        private System.Windows.Forms.Label lblAlbumStatus;
        private System.Windows.Forms.Panel pnlPictureInfo;
        private System.Windows.Forms.Label btnAddImages;
        private System.Windows.Forms.Label btnSearchImage;
        private System.Windows.Forms.Label btnSettingsImage;
        private System.Windows.Forms.Label btnExtractAlbum;
        private System.Windows.Forms.Label btnSearch;
        private System.Windows.Forms.TextBox txtSearchCriteria;
        private System.Windows.Forms.Label lblSearchTitle;
        private System.Windows.Forms.Panel pnlSearch;

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
            this.lblPrevious = new System.Windows.Forms.Label();
            this.lblNext = new System.Windows.Forms.Label();
            this.btnEditAlbum = new System.Windows.Forms.Label();
            this.lblExit = new System.Windows.Forms.Label();
            this.lblBack = new System.Windows.Forms.Label();
            this.lblToy = new System.Windows.Forms.Label();
            this.btnAddAlbum = new System.Windows.Forms.Label();
            this.btnCancelAddAlbum = new System.Windows.Forms.Label();
            this.btnSaveAlbum = new System.Windows.Forms.Label();
            this.btnAddImages = new System.Windows.Forms.Label();
            this.btnSearchImage = new System.Windows.Forms.Label();
            this.btnSettingsImage = new System.Windows.Forms.Label();
            this.btnExtractAlbum = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Label();
            this.btnChangeAlbum = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.cntMenuViewImage = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.завъртанеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.лявоToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.гореToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.дясноToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.долуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.уразмеряваToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlPictures = new System.Windows.Forms.Panel();
            this.cntMenuThumbnail = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.добавиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.премахниToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblAlbumError = new System.Windows.Forms.Label();
            this.cntMenuPicture = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.вижToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.премахниToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.lblAlbumTitle = new System.Windows.Forms.Label();
            this.cntMenuGeneral = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.помощToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.изходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureView = new System.Windows.Forms.PictureBox();
            this.pnlAlbums = new System.Windows.Forms.Panel();
            this.lblAlbumStatus = new System.Windows.Forms.Label();
            this.pnlSearch = new System.Windows.Forms.Panel();
            this.txtSearchCriteria = new System.Windows.Forms.TextBox();
            this.lblSearchTitle = new System.Windows.Forms.Label();
            this.lblAlbumsTitle = new System.Windows.Forms.Label();
            this.ddlAlbums = new System.Windows.Forms.ComboBox();
            this.txtAlbumTitle = new System.Windows.Forms.TextBox();
            this.lblAddAlbum = new System.Windows.Forms.Label();
            this.pnlPictureInfo = new System.Windows.Forms.Panel();
            this.cntMenuViewImage.SuspendLayout();
            this.cntMenuThumbnail.SuspendLayout();
            this.cntMenuPicture.SuspendLayout();
            this.cntMenuGeneral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureView)).BeginInit();
            this.pnlAlbums.SuspendLayout();
            this.pnlSearch.SuspendLayout();
            this.pnlPictureInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblPrevious
            // 
            this.lblPrevious.AutoSize = true;
            this.lblPrevious.BackColor = System.Drawing.Color.Transparent;
            this.lblPrevious.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblPrevious.Font = new System.Drawing.Font("Comic Sans MS", 40.25F);
            this.lblPrevious.Image = global::ProjectX.Properties.Resources.arrow_previous;
            this.lblPrevious.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblPrevious.Location = new System.Drawing.Point(20, 365);
            this.lblPrevious.Name = "lblPrevious";
            this.lblPrevious.Size = new System.Drawing.Size(49, 76);
            this.lblPrevious.TabIndex = 11;
            this.lblPrevious.Text = " ";
            this.toolTip1.SetToolTip(this.lblPrevious, "Предходна");
            this.lblPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // lblNext
            // 
            this.lblNext.AutoSize = true;
            this.lblNext.BackColor = System.Drawing.Color.Transparent;
            this.lblNext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblNext.Font = new System.Drawing.Font("Comic Sans MS", 40.25F);
            this.lblNext.Image = global::ProjectX.Properties.Resources.arrow_next;
            this.lblNext.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblNext.Location = new System.Drawing.Point(735, 365);
            this.lblNext.Name = "lblNext";
            this.lblNext.Size = new System.Drawing.Size(49, 76);
            this.lblNext.TabIndex = 10;
            this.lblNext.Text = " ";
            this.toolTip1.SetToolTip(this.lblNext, "Следваща");
            this.lblNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnEditAlbum
            // 
            this.btnEditAlbum.AutoSize = true;
            this.btnEditAlbum.BackColor = System.Drawing.Color.Transparent;
            this.btnEditAlbum.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditAlbum.Font = new System.Drawing.Font("Comic Sans MS", 25.25F);
            this.btnEditAlbum.Image = global::ProjectX.Properties.Resources.folder_documents_icon;
            this.btnEditAlbum.Location = new System.Drawing.Point(51, 196);
            this.btnEditAlbum.Name = "btnEditAlbum";
            this.btnEditAlbum.Size = new System.Drawing.Size(50, 47);
            this.btnEditAlbum.TabIndex = 12;
            this.btnEditAlbum.Text = "   ";
            this.toolTip1.SetToolTip(this.btnEditAlbum, "Добавяне на албум");
            this.btnEditAlbum.Click += new System.EventHandler(this.btnShowAddAlbumForm_click);
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
            this.lblExit.TabIndex = 15;
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
            this.lblBack.TabIndex = 31;
            this.lblBack.Text = "   ";
            this.toolTip1.SetToolTip(this.lblBack, "Назад");
            this.lblBack.Click += new System.EventHandler(this.btnBack_click);
            // 
            // lblToy
            // 
            this.lblToy.AutoSize = true;
            this.lblToy.BackColor = System.Drawing.Color.Transparent;
            this.lblToy.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblToy.Font = new System.Drawing.Font("Comic Sans MS", 28.25F);
            this.lblToy.Image = global::ProjectX.Properties.Resources.FrogPorcelaine_icon;
            this.lblToy.Location = new System.Drawing.Point(193, 43);
            this.lblToy.Name = "lblToy";
            this.lblToy.Size = new System.Drawing.Size(67, 53);
            this.lblToy.TabIndex = 16;
            this.lblToy.Text = "    ";
            this.toolTip1.SetToolTip(this.lblToy, "Жаба");
            // 
            // btnAddAlbum
            // 
            this.btnAddAlbum.AutoSize = true;
            this.btnAddAlbum.BackColor = System.Drawing.Color.Transparent;
            this.btnAddAlbum.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddAlbum.Font = new System.Drawing.Font("Comic Sans MS", 13.25F);
            this.btnAddAlbum.Image = global::ProjectX.Properties.Resources.Add_icon__1_;
            this.btnAddAlbum.Location = new System.Drawing.Point(401, 105);
            this.btnAddAlbum.Name = "btnAddAlbum";
            this.btnAddAlbum.Size = new System.Drawing.Size(25, 24);
            this.btnAddAlbum.TabIndex = 33;
            this.btnAddAlbum.Text = "   ";
            this.toolTip1.SetToolTip(this.btnAddAlbum, "Добавяне на албум");
            this.btnAddAlbum.Click += new System.EventHandler(this.btnAddAlbum_click);
            // 
            // btnCancelAddAlbum
            // 
            this.btnCancelAddAlbum.AutoSize = true;
            this.btnCancelAddAlbum.BackColor = System.Drawing.Color.Transparent;
            this.btnCancelAddAlbum.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnCancelAddAlbum.Font = new System.Drawing.Font("Comic Sans MS", 30.25F);
            this.btnCancelAddAlbum.Image = global::ProjectX.Properties.Resources.Close_2_icon;
            this.btnCancelAddAlbum.Location = new System.Drawing.Point(144, 166);
            this.btnCancelAddAlbum.Name = "btnCancelAddAlbum";
            this.btnCancelAddAlbum.Size = new System.Drawing.Size(73, 57);
            this.btnCancelAddAlbum.TabIndex = 33;
            this.btnCancelAddAlbum.Text = "    ";
            this.toolTip1.SetToolTip(this.btnCancelAddAlbum, "Отказ");
            this.btnCancelAddAlbum.Visible = false;
            this.btnCancelAddAlbum.Click += new System.EventHandler(this.btnCancelAddAlbum_click);
            // 
            // btnSaveAlbum
            // 
            this.btnSaveAlbum.AutoSize = true;
            this.btnSaveAlbum.BackColor = System.Drawing.Color.Transparent;
            this.btnSaveAlbum.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnSaveAlbum.Font = new System.Drawing.Font("Comic Sans MS", 36.25F);
            this.btnSaveAlbum.Image = global::ProjectX.Properties.Resources.Ok_icon;
            this.btnSaveAlbum.Location = new System.Drawing.Point(246, 157);
            this.btnSaveAlbum.Name = "btnSaveAlbum";
            this.btnSaveAlbum.Size = new System.Drawing.Size(90, 69);
            this.btnSaveAlbum.TabIndex = 34;
            this.btnSaveAlbum.Text = "    ";
            this.toolTip1.SetToolTip(this.btnSaveAlbum, "Добави албума");
            this.btnSaveAlbum.Visible = false;
            this.btnSaveAlbum.Click += new System.EventHandler(this.btnSaveAlbum_click);
            // 
            // btnAddImages
            // 
            this.btnAddImages.AutoSize = true;
            this.btnAddImages.BackColor = System.Drawing.Color.Transparent;
            this.btnAddImages.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddImages.Font = new System.Drawing.Font("Comic Sans MS", 25.25F);
            this.btnAddImages.Image = global::ProjectX.Properties.Resources.folder_multimedia_icon;
            this.btnAddImages.Location = new System.Drawing.Point(51, 126);
            this.btnAddImages.Name = "btnAddImages";
            this.btnAddImages.Size = new System.Drawing.Size(50, 47);
            this.btnAddImages.TabIndex = 36;
            this.btnAddImages.Text = "   ";
            this.toolTip1.SetToolTip(this.btnAddImages, "Добавяне на снимки");
            this.btnAddImages.Click += new System.EventHandler(this.btnShowAddFiles_click);
            // 
            // btnSearchImage
            // 
            this.btnSearchImage.AutoSize = true;
            this.btnSearchImage.BackColor = System.Drawing.Color.Transparent;
            this.btnSearchImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearchImage.Font = new System.Drawing.Font("Comic Sans MS", 25.25F);
            this.btnSearchImage.Image = global::ProjectX.Properties.Resources.search_icon;
            this.btnSearchImage.Location = new System.Drawing.Point(690, 187);
            this.btnSearchImage.Name = "btnSearchImage";
            this.btnSearchImage.Size = new System.Drawing.Size(50, 47);
            this.btnSearchImage.TabIndex = 37;
            this.btnSearchImage.Text = "   ";
            this.toolTip1.SetToolTip(this.btnSearchImage, "Търсене");
            this.btnSearchImage.Click += new System.EventHandler(this.btnShowSearchForm_Click);
            // 
            // btnSettingsImage
            // 
            this.btnSettingsImage.AutoSize = true;
            this.btnSettingsImage.BackColor = System.Drawing.Color.Transparent;
            this.btnSettingsImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSettingsImage.Font = new System.Drawing.Font("Comic Sans MS", 25.25F);
            this.btnSettingsImage.Image = global::ProjectX.Properties.Resources.settings_icon;
            this.btnSettingsImage.Location = new System.Drawing.Point(690, 257);
            this.btnSettingsImage.Name = "btnSettingsImage";
            this.btnSettingsImage.Size = new System.Drawing.Size(50, 47);
            this.btnSettingsImage.TabIndex = 38;
            this.btnSettingsImage.Text = "   ";
            this.toolTip1.SetToolTip(this.btnSettingsImage, "Коригиране");
            // 
            // btnExtractAlbum
            // 
            this.btnExtractAlbum.AutoSize = true;
            this.btnExtractAlbum.BackColor = System.Drawing.Color.Transparent;
            this.btnExtractAlbum.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExtractAlbum.Font = new System.Drawing.Font("Comic Sans MS", 25.25F);
            this.btnExtractAlbum.Image = global::ProjectX.Properties.Resources.dropbox_icon;
            this.btnExtractAlbum.Location = new System.Drawing.Point(51, 260);
            this.btnExtractAlbum.Name = "btnExtractAlbum";
            this.btnExtractAlbum.Size = new System.Drawing.Size(50, 47);
            this.btnExtractAlbum.TabIndex = 39;
            this.btnExtractAlbum.Text = "   ";
            this.toolTip1.SetToolTip(this.btnExtractAlbum, "Декодиране на албума");
            this.btnExtractAlbum.Click += new System.EventHandler(this.btnExtractAlbum_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.AutoSize = true;
            this.btnSearch.BackColor = System.Drawing.Color.Transparent;
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.Font = new System.Drawing.Font("Comic Sans MS", 25.25F);
            this.btnSearch.Image = global::ProjectX.Properties.Resources._0030_Search_icon;
            this.btnSearch.Location = new System.Drawing.Point(356, 102);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(50, 47);
            this.btnSearch.TabIndex = 40;
            this.btnSearch.Text = "   ";
            this.toolTip1.SetToolTip(this.btnSearch, "Търси");
            this.btnSearch.Visible = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearchImage_Click);
            // 
            // btnChangeAlbum
            // 
            this.btnChangeAlbum.AutoSize = true;
            this.btnChangeAlbum.BackColor = System.Drawing.Color.Transparent;
            this.btnChangeAlbum.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChangeAlbum.Font = new System.Drawing.Font("Comic Sans MS", 25.25F);
            this.btnChangeAlbum.Image = global::ProjectX.Properties.Resources.desk_icon;
            this.btnChangeAlbum.Location = new System.Drawing.Point(690, 114);
            this.btnChangeAlbum.Name = "btnChangeAlbum";
            this.btnChangeAlbum.Size = new System.Drawing.Size(50, 47);
            this.btnChangeAlbum.TabIndex = 40;
            this.btnChangeAlbum.Text = "   ";
            this.toolTip1.SetToolTip(this.btnChangeAlbum, "Всички албуми");
            this.btnChangeAlbum.Click += new System.EventHandler(this.btnShowAllAlbums);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Comic Sans MS", 14.25F);
            this.lblTitle.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblTitle.Location = new System.Drawing.Point(100, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(88, 26);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Галерия";
            // 
            // cntMenuViewImage
            // 
            this.cntMenuViewImage.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.завъртанеToolStripMenuItem,
            this.уразмеряваToolStripMenuItem});
            this.cntMenuViewImage.Name = "cntMenuViewImage";
            this.cntMenuViewImage.Size = new System.Drawing.Size(140, 48);
            // 
            // завъртанеToolStripMenuItem
            // 
            this.завъртанеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.лявоToolStripMenuItem,
            this.гореToolStripMenuItem,
            this.дясноToolStripMenuItem,
            this.долуToolStripMenuItem});
            this.завъртанеToolStripMenuItem.Name = "завъртанеToolStripMenuItem";
            this.завъртанеToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.завъртанеToolStripMenuItem.Text = "Завъртане";
            // 
            // лявоToolStripMenuItem
            // 
            this.лявоToolStripMenuItem.Name = "лявоToolStripMenuItem";
            this.лявоToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.лявоToolStripMenuItem.Text = "Ляво";
            // 
            // гореToolStripMenuItem
            // 
            this.гореToolStripMenuItem.Name = "гореToolStripMenuItem";
            this.гореToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.гореToolStripMenuItem.Text = "Горе";
            // 
            // дясноToolStripMenuItem
            // 
            this.дясноToolStripMenuItem.Name = "дясноToolStripMenuItem";
            this.дясноToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.дясноToolStripMenuItem.Text = "Дясно";
            // 
            // долуToolStripMenuItem
            // 
            this.долуToolStripMenuItem.Name = "долуToolStripMenuItem";
            this.долуToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.долуToolStripMenuItem.Text = "Долу";
            // 
            // уразмеряваToolStripMenuItem
            // 
            this.уразмеряваToolStripMenuItem.Name = "уразмеряваToolStripMenuItem";
            this.уразмеряваToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.уразмеряваToolStripMenuItem.Text = "Уразмерява";
            // 
            // pnlPictures
            // 
            this.pnlPictures.BackColor = System.Drawing.Color.Transparent;
            this.pnlPictures.ContextMenuStrip = this.cntMenuThumbnail;
            this.pnlPictures.Location = new System.Drawing.Point(78, 352);
            this.pnlPictures.Name = "pnlPictures";
            this.pnlPictures.Size = new System.Drawing.Size(650, 99);
            this.pnlPictures.TabIndex = 7;
            // 
            // cntMenuThumbnail
            // 
            this.cntMenuThumbnail.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавиToolStripMenuItem,
            this.премахниToolStripMenuItem});
            this.cntMenuThumbnail.Name = "cntMenuThumbnail";
            this.cntMenuThumbnail.Size = new System.Drawing.Size(131, 48);
            // 
            // добавиToolStripMenuItem
            // 
            this.добавиToolStripMenuItem.Name = "добавиToolStripMenuItem";
            this.добавиToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.добавиToolStripMenuItem.Text = "Добави";
            this.добавиToolStripMenuItem.Click += new System.EventHandler(this.ddlAddFilesAlbums_SelectedIndexChanged);
            // 
            // премахниToolStripMenuItem
            // 
            this.премахниToolStripMenuItem.Name = "премахниToolStripMenuItem";
            this.премахниToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.премахниToolStripMenuItem.Text = "Премахни";
            // 
            // lblAlbumError
            // 
            this.lblAlbumError.AutoSize = true;
            this.lblAlbumError.Font = new System.Drawing.Font("Comic Sans MS", 18.25F);
            this.lblAlbumError.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblAlbumError.Location = new System.Drawing.Point(203, 35);
            this.lblAlbumError.Name = "lblAlbumError";
            this.lblAlbumError.Size = new System.Drawing.Size(228, 34);
            this.lblAlbumError.TabIndex = 0;
            this.lblAlbumError.Text = "Some testing text";
            // 
            // cntMenuPicture
            // 
            this.cntMenuPicture.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.вижToolStripMenuItem,
            this.премахниToolStripMenuItem1});
            this.cntMenuPicture.Name = "cntMenuPicture";
            this.cntMenuPicture.Size = new System.Drawing.Size(131, 48);
            // 
            // вижToolStripMenuItem
            // 
            this.вижToolStripMenuItem.Name = "вижToolStripMenuItem";
            this.вижToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.вижToolStripMenuItem.Text = "Виж";
            this.вижToolStripMenuItem.Click += new System.EventHandler(this.showPic);
            // 
            // премахниToolStripMenuItem1
            // 
            this.премахниToolStripMenuItem1.Name = "премахниToolStripMenuItem1";
            this.премахниToolStripMenuItem1.Size = new System.Drawing.Size(130, 22);
            this.премахниToolStripMenuItem1.Text = "Премахни";
            this.премахниToolStripMenuItem1.Click += new System.EventHandler(this.btnRemovePicture_Click);
            // 
            // lblAlbumTitle
            // 
            this.lblAlbumTitle.AutoSize = true;
            this.lblAlbumTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblAlbumTitle.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.lblAlbumTitle.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblAlbumTitle.Location = new System.Drawing.Point(268, 47);
            this.lblAlbumTitle.Name = "lblAlbumTitle";
            this.lblAlbumTitle.Size = new System.Drawing.Size(238, 23);
            this.lblAlbumTitle.TabIndex = 8;
            this.lblAlbumTitle.Text = "Безраборен подбор на снимки";
            // 
            // cntMenuGeneral
            // 
            this.cntMenuGeneral.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.помощToolStripMenuItem,
            this.изходToolStripMenuItem});
            this.cntMenuGeneral.Name = "cntMenuGeneral";
            this.cntMenuGeneral.Size = new System.Drawing.Size(144, 48);
            // 
            // помощToolStripMenuItem
            // 
            this.помощToolStripMenuItem.Name = "помощToolStripMenuItem";
            this.помощToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.помощToolStripMenuItem.Text = "Помощ";
            // 
            // изходToolStripMenuItem
            // 
            this.изходToolStripMenuItem.Name = "изходToolStripMenuItem";
            this.изходToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.X)));
            this.изходToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.изходToolStripMenuItem.Text = "Изход";
            // 
            // pictureView
            // 
            this.pictureView.BackColor = System.Drawing.Color.Transparent;
            this.pictureView.ContextMenuStrip = this.cntMenuViewImage;
            this.pictureView.Location = new System.Drawing.Point(170, 100);
            this.pictureView.Name = "pictureView";
            this.pictureView.Size = new System.Drawing.Size(444, 250);
            this.pictureView.TabIndex = 3;
            this.pictureView.TabStop = false;
            // 
            // pnlAlbums
            // 
            this.pnlAlbums.BackColor = System.Drawing.Color.Transparent;
            this.pnlAlbums.Controls.Add(this.lblAlbumStatus);
            this.pnlAlbums.Controls.Add(this.btnSaveAlbum);
            this.pnlAlbums.Controls.Add(this.btnCancelAddAlbum);
            this.pnlAlbums.Controls.Add(this.btnAddAlbum);
            this.pnlAlbums.Controls.Add(this.pnlSearch);
            this.pnlAlbums.Controls.Add(this.lblAlbumsTitle);
            this.pnlAlbums.Controls.Add(this.ddlAlbums);
            this.pnlAlbums.Controls.Add(this.txtAlbumTitle);
            this.pnlAlbums.Controls.Add(this.lblAddAlbum);
            this.pnlAlbums.Location = new System.Drawing.Point(170, 100);
            this.pnlAlbums.Name = "pnlAlbums";
            this.pnlAlbums.Size = new System.Drawing.Size(444, 250);
            this.pnlAlbums.TabIndex = 32;
            // 
            // lblAlbumStatus
            // 
            this.lblAlbumStatus.AutoSize = true;
            this.lblAlbumStatus.BackColor = System.Drawing.Color.Transparent;
            this.lblAlbumStatus.Font = new System.Drawing.Font("Comic Sans MS", 15.25F);
            this.lblAlbumStatus.ForeColor = System.Drawing.Color.Silver;
            this.lblAlbumStatus.Location = new System.Drawing.Point(90, 175);
            this.lblAlbumStatus.Name = "lblAlbumStatus";
            this.lblAlbumStatus.Size = new System.Drawing.Size(0, 29);
            this.lblAlbumStatus.TabIndex = 35;
            // 
            // pnlSearch
            // 
            this.pnlSearch.BackColor = System.Drawing.Color.Transparent;
            this.pnlSearch.Controls.Add(this.btnSearch);
            this.pnlSearch.Controls.Add(this.txtSearchCriteria);
            this.pnlSearch.Controls.Add(this.lblSearchTitle);
            this.pnlSearch.Location = new System.Drawing.Point(0, 0);
            this.pnlSearch.Name = "pnlSearch";
            this.pnlSearch.Size = new System.Drawing.Size(444, 250);
            this.pnlSearch.TabIndex = 36;
            this.pnlSearch.Visible = false;
            // 
            // txtSearchCriteria
            // 
            this.txtSearchCriteria.BackColor = System.Drawing.Color.DarkGray;
            this.txtSearchCriteria.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearchCriteria.Location = new System.Drawing.Point(72, 127);
            this.txtSearchCriteria.Name = "txtSearchCriteria";
            this.txtSearchCriteria.Size = new System.Drawing.Size(264, 16);
            this.txtSearchCriteria.TabIndex = 41;
            this.txtSearchCriteria.Visible = false;
            // 
            // lblSearchTitle
            // 
            this.lblSearchTitle.AutoSize = true;
            this.lblSearchTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblSearchTitle.Font = new System.Drawing.Font("Comic Sans MS", 14.25F);
            this.lblSearchTitle.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblSearchTitle.Location = new System.Drawing.Point(59, 61);
            this.lblSearchTitle.Name = "lblSearchTitle";
            this.lblSearchTitle.Size = new System.Drawing.Size(69, 26);
            this.lblSearchTitle.TabIndex = 40;
            this.lblSearchTitle.Text = "Търси";
            this.lblSearchTitle.Visible = false;
            // 
            // lblAlbumsTitle
            // 
            this.lblAlbumsTitle.AutoSize = true;
            this.lblAlbumsTitle.ForeColor = System.Drawing.Color.Silver;
            this.lblAlbumsTitle.Location = new System.Drawing.Point(28, 107);
            this.lblAlbumsTitle.Name = "lblAlbumsTitle";
            this.lblAlbumsTitle.Size = new System.Drawing.Size(57, 15);
            this.lblAlbumsTitle.TabIndex = 3;
            this.lblAlbumsTitle.Text = "Албум     ";
            // 
            // ddlAlbums
            // 
            this.ddlAlbums.BackColor = System.Drawing.Color.Gray;
            this.ddlAlbums.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ddlAlbums.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlAlbums.FormattingEnabled = true;
            this.ddlAlbums.Location = new System.Drawing.Point(103, 104);
            this.ddlAlbums.Name = "ddlAlbums";
            this.ddlAlbums.Size = new System.Drawing.Size(285, 23);
            this.ddlAlbums.TabIndex = 2;
            this.ddlAlbums.SelectedIndexChanged += new System.EventHandler(this.ddlAlbums_SelectedIndexChanged);
            // 
            // txtAlbumTitle
            // 
            this.txtAlbumTitle.BackColor = System.Drawing.Color.Gray;
            this.txtAlbumTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAlbumTitle.Location = new System.Drawing.Point(111, 105);
            this.txtAlbumTitle.Name = "txtAlbumTitle";
            this.txtAlbumTitle.Size = new System.Drawing.Size(276, 16);
            this.txtAlbumTitle.TabIndex = 1;
            // 
            // lblAddAlbum
            // 
            this.lblAddAlbum.AutoSize = true;
            this.lblAddAlbum.ForeColor = System.Drawing.Color.Silver;
            this.lblAddAlbum.Location = new System.Drawing.Point(25, 104);
            this.lblAddAlbum.Name = "lblAddAlbum";
            this.lblAddAlbum.Size = new System.Drawing.Size(57, 15);
            this.lblAddAlbum.TabIndex = 0;
            this.lblAddAlbum.Text = "Заглавие";
            // 
            // pnlPictureInfo
            // 
            this.pnlPictureInfo.BackColor = System.Drawing.Color.Transparent;
            this.pnlPictureInfo.Controls.Add(this.lblAlbumError);
            this.pnlPictureInfo.Location = new System.Drawing.Point(75, 348);
            this.pnlPictureInfo.Name = "pnlPictureInfo";
            this.pnlPictureInfo.Size = new System.Drawing.Size(653, 103);
            this.pnlPictureInfo.TabIndex = 0;
            // 
            // FormGallery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = global::ProjectX.Properties.Resources.black_minimalistic_background_1920x1080_wallpaper_www_wallpaperto_com_83;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ContextMenuStrip = this.cntMenuGeneral;
            this.Controls.Add(this.btnChangeAlbum);
            this.Controls.Add(this.btnExtractAlbum);
            this.Controls.Add(this.btnSettingsImage);
            this.Controls.Add(this.btnSearchImage);
            this.Controls.Add(this.btnAddImages);
            this.Controls.Add(this.pnlPictureInfo);
            this.Controls.Add(this.pnlAlbums);
            this.Controls.Add(this.lblBack);
            this.Controls.Add(this.lblToy);
            this.Controls.Add(this.lblExit);
            this.Controls.Add(this.btnEditAlbum);
            this.Controls.Add(this.lblAlbumTitle);
            this.Controls.Add(this.lblPrevious);
            this.Controls.Add(this.lblNext);
            this.Controls.Add(this.pnlPictures);
            this.Controls.Add(this.pictureView);
            this.Controls.Add(this.lblTitle);
            this.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormGallery";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gallery";
            this.Load += new System.EventHandler(this.FormGallery_Load);
            this.cntMenuViewImage.ResumeLayout(false);
            this.cntMenuThumbnail.ResumeLayout(false);
            this.cntMenuPicture.ResumeLayout(false);
            this.cntMenuGeneral.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureView)).EndInit();
            this.pnlAlbums.ResumeLayout(false);
            this.pnlAlbums.PerformLayout();
            this.pnlSearch.ResumeLayout(false);
            this.pnlSearch.PerformLayout();
            this.pnlPictureInfo.ResumeLayout(false);
            this.pnlPictureInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label btnChangeAlbum;
    }
}