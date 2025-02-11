namespace Desktop
{
    partial class MainForm
    {
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
            if (disposing && (components != null))
            {
                components.Dispose();
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
            this.tableLayoutPanel_Main = new System.Windows.Forms.TableLayoutPanel();
            this.panel_Menu = new System.Windows.Forms.Panel();
            this.panel_Links = new System.Windows.Forms.Panel();
            this.button_Publishers = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button_Users = new System.Windows.Forms.Button();
            this.panel_BooksSubMenu = new System.Windows.Forms.Panel();
            this.button_BookLending = new System.Windows.Forms.Button();
            this.button_AddBook = new System.Windows.Forms.Button();
            this.button_AllBooks = new System.Windows.Forms.Button();
            this.button_BookTakeback = new System.Windows.Forms.Button();
            this.button_Books = new System.Windows.Forms.Button();
            this.button_HomePage = new System.Windows.Forms.Button();
            this.panel_Theme = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.toggleButton_ThemeChanger = new Desktop.ToggleButton();
            this.panel_User = new System.Windows.Forms.Panel();
            this.lblEmplUname = new System.Windows.Forms.Label();
            this.pictureBox_UserPic = new System.Windows.Forms.PictureBox();
            this.panel_Container = new System.Windows.Forms.Panel();
            this.roundedCornerPanel_PageContainer = new Desktop.RoundedCornerPanel();
            this.tableLayoutPanel_Main.SuspendLayout();
            this.panel_Menu.SuspendLayout();
            this.panel_Links.SuspendLayout();
            this.panel_BooksSubMenu.SuspendLayout();
            this.panel_Theme.SuspendLayout();
            this.panel_User.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_UserPic)).BeginInit();
            this.panel_Container.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel_Main
            // 
            this.tableLayoutPanel_Main.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(39)))));
            this.tableLayoutPanel_Main.ColumnCount = 2;
            this.tableLayoutPanel_Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 240F));
            this.tableLayoutPanel_Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel_Main.Controls.Add(this.panel_Menu, 0, 0);
            this.tableLayoutPanel_Main.Controls.Add(this.panel_Container, 1, 0);
            this.tableLayoutPanel_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_Main.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel_Main.Name = "tableLayoutPanel_Main";
            this.tableLayoutPanel_Main.RowCount = 1;
            this.tableLayoutPanel_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_Main.Size = new System.Drawing.Size(986, 744);
            this.tableLayoutPanel_Main.TabIndex = 2;
            // 
            // panel_Menu
            // 
            this.panel_Menu.AutoScroll = true;
            this.panel_Menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(39)))));
            this.panel_Menu.Controls.Add(this.panel_Links);
            this.panel_Menu.Controls.Add(this.panel_Theme);
            this.panel_Menu.Controls.Add(this.panel_User);
            this.panel_Menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_Menu.Location = new System.Drawing.Point(3, 3);
            this.panel_Menu.Name = "panel_Menu";
            this.panel_Menu.Size = new System.Drawing.Size(234, 738);
            this.panel_Menu.TabIndex = 1;
            // 
            // panel_Links
            // 
            this.panel_Links.Controls.Add(this.button_Publishers);
            this.panel_Links.Controls.Add(this.button4);
            this.panel_Links.Controls.Add(this.button3);
            this.panel_Links.Controls.Add(this.button_Users);
            this.panel_Links.Controls.Add(this.panel_BooksSubMenu);
            this.panel_Links.Controls.Add(this.button_Books);
            this.panel_Links.Controls.Add(this.button_HomePage);
            this.panel_Links.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Links.Location = new System.Drawing.Point(0, 111);
            this.panel_Links.Name = "panel_Links";
            this.panel_Links.Size = new System.Drawing.Size(234, 480);
            this.panel_Links.TabIndex = 0;
            // 
            // button_Publishers
            // 
            this.button_Publishers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(39)))));
            this.button_Publishers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Publishers.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_Publishers.FlatAppearance.BorderSize = 0;
            this.button_Publishers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Publishers.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_Publishers.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button_Publishers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Publishers.Location = new System.Drawing.Point(0, 428);
            this.button_Publishers.Name = "button_Publishers";
            this.button_Publishers.Padding = new System.Windows.Forms.Padding(21, 0, 0, 0);
            this.button_Publishers.Size = new System.Drawing.Size(234, 48);
            this.button_Publishers.TabIndex = 7;
            this.button_Publishers.Text = "  Kiadók";
            this.button_Publishers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Publishers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_Publishers.UseVisualStyleBackColor = false;
            this.button_Publishers.Click += new System.EventHandler(this.button_Publishers_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(39)))));
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.Dock = System.Windows.Forms.DockStyle.Top;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(0, 380);
            this.button4.Name = "button4";
            this.button4.Padding = new System.Windows.Forms.Padding(21, 0, 0, 0);
            this.button4.Size = new System.Drawing.Size(234, 48);
            this.button4.TabIndex = 5;
            this.button4.Text = "  Előjegyzés";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(39)))));
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.Dock = System.Windows.Forms.DockStyle.Top;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(0, 332);
            this.button3.Name = "button3";
            this.button3.Padding = new System.Windows.Forms.Padding(21, 0, 0, 0);
            this.button3.Size = new System.Drawing.Size(234, 48);
            this.button3.TabIndex = 6;
            this.button3.Text = "  Igénylések";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button_Users
            // 
            this.button_Users.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(39)))));
            this.button_Users.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Users.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_Users.FlatAppearance.BorderSize = 0;
            this.button_Users.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Users.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_Users.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button_Users.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Users.Location = new System.Drawing.Point(0, 284);
            this.button_Users.Name = "button_Users";
            this.button_Users.Padding = new System.Windows.Forms.Padding(21, 0, 0, 0);
            this.button_Users.Size = new System.Drawing.Size(234, 48);
            this.button_Users.TabIndex = 4;
            this.button_Users.Text = "  Felhasználók";
            this.button_Users.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Users.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_Users.UseVisualStyleBackColor = false;
            this.button_Users.Click += new System.EventHandler(this.button_Users_Click);
            // 
            // panel_BooksSubMenu
            // 
            this.panel_BooksSubMenu.Controls.Add(this.button_BookLending);
            this.panel_BooksSubMenu.Controls.Add(this.button_AddBook);
            this.panel_BooksSubMenu.Controls.Add(this.button_AllBooks);
            this.panel_BooksSubMenu.Controls.Add(this.button_BookTakeback);
            this.panel_BooksSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_BooksSubMenu.Location = new System.Drawing.Point(0, 96);
            this.panel_BooksSubMenu.Margin = new System.Windows.Forms.Padding(0);
            this.panel_BooksSubMenu.Name = "panel_BooksSubMenu";
            this.panel_BooksSubMenu.Size = new System.Drawing.Size(234, 188);
            this.panel_BooksSubMenu.TabIndex = 0;
            // 
            // button_BookLending
            // 
            this.button_BookLending.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(48)))));
            this.button_BookLending.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_BookLending.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_BookLending.FlatAppearance.BorderSize = 0;
            this.button_BookLending.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_BookLending.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_BookLending.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button_BookLending.Location = new System.Drawing.Point(0, 144);
            this.button_BookLending.Name = "button_BookLending";
            this.button_BookLending.Padding = new System.Windows.Forms.Padding(55, 0, 0, 0);
            this.button_BookLending.Size = new System.Drawing.Size(234, 48);
            this.button_BookLending.TabIndex = 0;
            this.button_BookLending.Tag = "DropdownMenu";
            this.button_BookLending.Text = "Könyv kiadása";
            this.button_BookLending.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_BookLending.UseVisualStyleBackColor = false;
            this.button_BookLending.Click += new System.EventHandler(this.button_BookLending_Click);
            // 
            // button_AddBook
            // 
            this.button_AddBook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(48)))));
            this.button_AddBook.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_AddBook.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_AddBook.FlatAppearance.BorderSize = 0;
            this.button_AddBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_AddBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_AddBook.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button_AddBook.Location = new System.Drawing.Point(0, 96);
            this.button_AddBook.Name = "button_AddBook";
            this.button_AddBook.Padding = new System.Windows.Forms.Padding(55, 0, 0, 0);
            this.button_AddBook.Size = new System.Drawing.Size(234, 48);
            this.button_AddBook.TabIndex = 3;
            this.button_AddBook.Tag = "DropdownMenu";
            this.button_AddBook.Text = "Új könyv felvétele";
            this.button_AddBook.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_AddBook.UseVisualStyleBackColor = false;
            this.button_AddBook.Click += new System.EventHandler(this.button_AddBook_Click);
            // 
            // button_AllBooks
            // 
            this.button_AllBooks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(48)))));
            this.button_AllBooks.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_AllBooks.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_AllBooks.FlatAppearance.BorderSize = 0;
            this.button_AllBooks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_AllBooks.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_AllBooks.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button_AllBooks.Location = new System.Drawing.Point(0, 48);
            this.button_AllBooks.Name = "button_AllBooks";
            this.button_AllBooks.Padding = new System.Windows.Forms.Padding(55, 0, 0, 0);
            this.button_AllBooks.Size = new System.Drawing.Size(234, 48);
            this.button_AllBooks.TabIndex = 2;
            this.button_AllBooks.Tag = "DropdownMenu";
            this.button_AllBooks.Text = "Összes könyv";
            this.button_AllBooks.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_AllBooks.UseVisualStyleBackColor = false;
            this.button_AllBooks.Click += new System.EventHandler(this.button_AllBooks_Click);
            // 
            // button_BookTakeback
            // 
            this.button_BookTakeback.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(48)))));
            this.button_BookTakeback.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_BookTakeback.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_BookTakeback.FlatAppearance.BorderSize = 0;
            this.button_BookTakeback.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_BookTakeback.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_BookTakeback.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button_BookTakeback.Location = new System.Drawing.Point(0, 0);
            this.button_BookTakeback.Name = "button_BookTakeback";
            this.button_BookTakeback.Padding = new System.Windows.Forms.Padding(55, 0, 0, 0);
            this.button_BookTakeback.Size = new System.Drawing.Size(234, 48);
            this.button_BookTakeback.TabIndex = 1;
            this.button_BookTakeback.Tag = "DropdownMenu";
            this.button_BookTakeback.Text = "Könyv visszavétele";
            this.button_BookTakeback.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_BookTakeback.UseVisualStyleBackColor = false;
            this.button_BookTakeback.Click += new System.EventHandler(this.button_BookTakeback_Click);
            // 
            // button_Books
            // 
            this.button_Books.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(39)))));
            this.button_Books.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button_Books.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Books.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_Books.FlatAppearance.BorderSize = 0;
            this.button_Books.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Books.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_Books.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button_Books.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Books.Location = new System.Drawing.Point(0, 48);
            this.button_Books.Name = "button_Books";
            this.button_Books.Padding = new System.Windows.Forms.Padding(21, 0, 0, 0);
            this.button_Books.Size = new System.Drawing.Size(234, 48);
            this.button_Books.TabIndex = 3;
            this.button_Books.Text = "  Könyvek";
            this.button_Books.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Books.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_Books.UseVisualStyleBackColor = false;
            this.button_Books.Click += new System.EventHandler(this.button_Books_Click);
            // 
            // button_HomePage
            // 
            this.button_HomePage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(39)))));
            this.button_HomePage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button_HomePage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_HomePage.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_HomePage.FlatAppearance.BorderSize = 0;
            this.button_HomePage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_HomePage.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_HomePage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button_HomePage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_HomePage.Location = new System.Drawing.Point(0, 0);
            this.button_HomePage.Name = "button_HomePage";
            this.button_HomePage.Padding = new System.Windows.Forms.Padding(21, 0, 0, 0);
            this.button_HomePage.Size = new System.Drawing.Size(234, 48);
            this.button_HomePage.TabIndex = 1;
            this.button_HomePage.Text = "  Főoldal";
            this.button_HomePage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_HomePage.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_HomePage.UseVisualStyleBackColor = false;
            this.button_HomePage.Click += new System.EventHandler(this.button_HomePage_Click);
            // 
            // panel_Theme
            // 
            this.panel_Theme.Controls.Add(this.label1);
            this.panel_Theme.Controls.Add(this.toggleButton_ThemeChanger);
            this.panel_Theme.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_Theme.Location = new System.Drawing.Point(0, 652);
            this.panel_Theme.Name = "panel_Theme";
            this.panel_Theme.Size = new System.Drawing.Size(234, 86);
            this.panel_Theme.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(89, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "TÉMA";
            // 
            // toggleButton_ThemeChanger
            // 
            this.toggleButton_ThemeChanger.Cursor = System.Windows.Forms.Cursors.Hand;
            this.toggleButton_ThemeChanger.Location = new System.Drawing.Point(90, 44);
            this.toggleButton_ThemeChanger.Name = "toggleButton_ThemeChanger";
            this.toggleButton_ThemeChanger.OffBackColor = System.Drawing.Color.Gray;
            this.toggleButton_ThemeChanger.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.toggleButton_ThemeChanger.OnBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(205)))), ((int)(((byte)(198)))));
            this.toggleButton_ThemeChanger.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.toggleButton_ThemeChanger.Size = new System.Drawing.Size(45, 22);
            this.toggleButton_ThemeChanger.TabIndex = 0;
            this.toggleButton_ThemeChanger.Text = "toggleButton1";
            this.toggleButton_ThemeChanger.UseVisualStyleBackColor = true;
            this.toggleButton_ThemeChanger.CheckedChanged += new System.EventHandler(this.toggleButton_ThemeChanger_CheckedChanged);
            // 
            // panel_User
            // 
            this.panel_User.Controls.Add(this.lblEmplUname);
            this.panel_User.Controls.Add(this.pictureBox_UserPic);
            this.panel_User.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_User.Location = new System.Drawing.Point(0, 0);
            this.panel_User.Name = "panel_User";
            this.panel_User.Size = new System.Drawing.Size(234, 111);
            this.panel_User.TabIndex = 0;
            // 
            // lblEmplUname
            // 
            this.lblEmplUname.AutoSize = true;
            this.lblEmplUname.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblEmplUname.Location = new System.Drawing.Point(78, 64);
            this.lblEmplUname.Name = "lblEmplUname";
            this.lblEmplUname.Size = new System.Drawing.Size(73, 17);
            this.lblEmplUname.TabIndex = 1;
            this.lblEmplUname.Text = "Username";
            // 
            // pictureBox_UserPic
            // 
            this.pictureBox_UserPic.Location = new System.Drawing.Point(90, 9);
            this.pictureBox_UserPic.Name = "pictureBox_UserPic";
            this.pictureBox_UserPic.Size = new System.Drawing.Size(45, 47);
            this.pictureBox_UserPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_UserPic.TabIndex = 0;
            this.pictureBox_UserPic.TabStop = false;
            this.pictureBox_UserPic.Click += new System.EventHandler(this.pictureBox_UserPic_Click);
            // 
            // panel_Container
            // 
            this.panel_Container.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(39)))));
            this.panel_Container.Controls.Add(this.roundedCornerPanel_PageContainer);
            this.panel_Container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Container.Location = new System.Drawing.Point(240, 0);
            this.panel_Container.Margin = new System.Windows.Forms.Padding(0);
            this.panel_Container.Name = "panel_Container";
            this.panel_Container.Size = new System.Drawing.Size(746, 744);
            this.panel_Container.TabIndex = 2;
            // 
            // roundedCornerPanel_PageContainer
            // 
            this.roundedCornerPanel_PageContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.roundedCornerPanel_PageContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(68)))));
            this.roundedCornerPanel_PageContainer.CornerRadius = 30;
            this.roundedCornerPanel_PageContainer.Location = new System.Drawing.Point(0, 0);
            this.roundedCornerPanel_PageContainer.Margin = new System.Windows.Forms.Padding(0);
            this.roundedCornerPanel_PageContainer.Name = "roundedCornerPanel_PageContainer";
            this.roundedCornerPanel_PageContainer.Size = new System.Drawing.Size(746, 744);
            this.roundedCornerPanel_PageContainer.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(39)))));
            this.ClientSize = new System.Drawing.Size(986, 744);
            this.Controls.Add(this.tableLayoutPanel_Main);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MinimumSize = new System.Drawing.Size(1002, 708);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Könyvtár rendszer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel_Main.ResumeLayout(false);
            this.panel_Menu.ResumeLayout(false);
            this.panel_Links.ResumeLayout(false);
            this.panel_BooksSubMenu.ResumeLayout(false);
            this.panel_Theme.ResumeLayout(false);
            this.panel_Theme.PerformLayout();
            this.panel_User.ResumeLayout(false);
            this.panel_User.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_UserPic)).EndInit();
            this.panel_Container.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_Main;
		private System.Windows.Forms.Panel panel_Menu;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button_Users;
		private System.Windows.Forms.Panel panel_BooksSubMenu;
		private System.Windows.Forms.Button button_AddBook;
		private System.Windows.Forms.Button button_AllBooks;
		private System.Windows.Forms.Button button_BookTakeback;
		private System.Windows.Forms.Button button_BookLending;
		private System.Windows.Forms.Button button_Books;
		private System.Windows.Forms.Button button_HomePage;
		private System.Windows.Forms.Panel panel_User;
		private System.Windows.Forms.Panel panel_Container;
		private RoundedCornerPanel roundedCornerPanel_PageContainer;
        private System.Windows.Forms.Panel panel_Theme;
        private ToggleButton toggleButton_ThemeChanger;
        private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label lblEmplUname;
		private System.Windows.Forms.PictureBox pictureBox_UserPic;
		private System.Windows.Forms.Panel panel_Links;
		private System.Windows.Forms.Button button_Publishers;
	}
}

