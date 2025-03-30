namespace Desktop
{
    partial class BookDetailedPage
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
			this.label1 = new System.Windows.Forms.Label();
			this.lblISBN = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.lblPublisher = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.lblLang = new System.Windows.Forms.Label();
			this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
			this.ofdPic = new System.Windows.Forms.OpenFileDialog();
			this.lblPicName = new System.Windows.Forms.Label();
			this.ctbISBN = new Desktop.CustomTextbox();
			this.cbtnAddPicture = new Desktop.CustomButton();
			this.cdtpReleaseDate = new Desktop.CustomDateTimePicker();
			this.ctbTitle = new Desktop.CustomTextbox();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.panel7 = new System.Windows.Forms.Panel();
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel3 = new System.Windows.Forms.Panel();
			this.cbtnAddAuthor = new Desktop.CustomButton();
			this.cbtnAddCategory = new Desktop.CustomButton();
			this.panel2 = new System.Windows.Forms.Panel();
			this.label9 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.pAuthors = new System.Windows.Forms.Panel();
			this.pCategories = new System.Windows.Forms.Panel();
			this.panel9 = new System.Windows.Forms.Panel();
			this.panel4 = new System.Windows.Forms.Panel();
			this.panel5 = new System.Windows.Forms.Panel();
			this.label10 = new System.Windows.Forms.Label();
			this.ctbDescription = new Desktop.CustomTextbox();
			this.panel10 = new System.Windows.Forms.Panel();
			this.pManage = new System.Windows.Forms.Panel();
			this.label8 = new System.Windows.Forms.Label();
			this.cbtnDeactivate = new Desktop.CustomButton();
			this.label6 = new System.Windows.Forms.Label();
			this.cbtnAddBook = new Desktop.CustomButton();
			this.panel6 = new System.Windows.Forms.Panel();
			this.panel8 = new System.Windows.Forms.Panel();
			this.cbtnBack = new Desktop.CustomButton();
			this.tableLayoutPanel1.SuspendLayout();
			this.panel7.SuspendLayout();
			this.panel1.SuspendLayout();
			this.panel3.SuspendLayout();
			this.panel2.SuspendLayout();
			this.panel9.SuspendLayout();
			this.panel4.SuspendLayout();
			this.panel5.SuspendLayout();
			this.panel10.SuspendLayout();
			this.pManage.SuspendLayout();
			this.panel6.SuspendLayout();
			this.panel8.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.ForeColor = System.Drawing.SystemColors.Control;
			this.label1.Location = new System.Drawing.Point(25, 16);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(38, 16);
			this.label1.TabIndex = 0;
			this.label1.Text = "ISBN";
			// 
			// lblISBN
			// 
			this.lblISBN.AutoSize = true;
			this.lblISBN.Location = new System.Drawing.Point(56, 55);
			this.lblISBN.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblISBN.Name = "lblISBN";
			this.lblISBN.Size = new System.Drawing.Size(44, 16);
			this.lblISBN.TabIndex = 1;
			this.lblISBN.Text = "label2";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.ForeColor = System.Drawing.SystemColors.Control;
			this.label3.Location = new System.Drawing.Point(25, 94);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(68, 16);
			this.label3.TabIndex = 2;
			this.label3.Text = "Könyv cím";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.ForeColor = System.Drawing.SystemColors.Control;
			this.label4.Location = new System.Drawing.Point(25, 186);
			this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(99, 16);
			this.label4.TabIndex = 5;
			this.label4.Text = "Megjelenési év";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.ForeColor = System.Drawing.SystemColors.Control;
			this.label5.Location = new System.Drawing.Point(28, 10);
			this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(42, 16);
			this.label5.TabIndex = 6;
			this.label5.Text = "Kiadó";
			// 
			// lblPublisher
			// 
			this.lblPublisher.AutoSize = true;
			this.lblPublisher.ForeColor = System.Drawing.SystemColors.Control;
			this.lblPublisher.Location = new System.Drawing.Point(56, 46);
			this.lblPublisher.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblPublisher.Name = "lblPublisher";
			this.lblPublisher.Size = new System.Drawing.Size(42, 16);
			this.lblPublisher.TabIndex = 7;
			this.lblPublisher.Text = "Kiadó";
			this.lblPublisher.Click += new System.EventHandler(this.lblPublisher_Click);
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.ForeColor = System.Drawing.SystemColors.Control;
			this.label7.Location = new System.Drawing.Point(28, 86);
			this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(42, 16);
			this.label7.TabIndex = 8;
			this.label7.Text = "Nyelv";
			// 
			// lblLang
			// 
			this.lblLang.AutoSize = true;
			this.lblLang.ForeColor = System.Drawing.SystemColors.Control;
			this.lblLang.Location = new System.Drawing.Point(56, 121);
			this.lblLang.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblLang.Name = "lblLang";
			this.lblLang.Size = new System.Drawing.Size(42, 16);
			this.lblLang.TabIndex = 9;
			this.lblLang.Text = "Nyelv";
			this.lblLang.Click += new System.EventHandler(this.lblLang_Click);
			// 
			// ofdPic
			// 
			this.ofdPic.FileName = "openFileDialog1";
			this.ofdPic.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.webp;*.svg;*.bmp";
			// 
			// lblPicName
			// 
			this.lblPicName.AutoSize = true;
			this.lblPicName.Location = new System.Drawing.Point(163, 496);
			this.lblPicName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblPicName.Name = "lblPicName";
			this.lblPicName.Size = new System.Drawing.Size(0, 16);
			this.lblPicName.TabIndex = 28;
			// 
			// ctbISBN
			// 
			this.ctbISBN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(68)))));
			this.ctbISBN.BorderColor = System.Drawing.Color.MediumSlateBlue;
			this.ctbISBN.BorderFocusColor = System.Drawing.Color.HotPink;
			this.ctbISBN.BorderRadius = 10;
			this.ctbISBN.BorderSize = 2;
			this.ctbISBN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.ctbISBN.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.ctbISBN.IsReadOnly = false;
			this.ctbISBN.Location = new System.Drawing.Point(29, 37);
			this.ctbISBN.Margin = new System.Windows.Forms.Padding(5);
			this.ctbISBN.Multiline = false;
			this.ctbISBN.Name = "ctbISBN";
			this.ctbISBN.Padding = new System.Windows.Forms.Padding(13, 9, 13, 9);
			this.ctbISBN.PasswordChar = false;
			this.ctbISBN.PlaceholderColor = System.Drawing.Color.DarkGray;
			this.ctbISBN.PlaceholderText = "";
			this.ctbISBN.Size = new System.Drawing.Size(237, 39);
			this.ctbISBN.TabIndex = 2;
			this.ctbISBN.TextBoxScrollBars = System.Windows.Forms.ScrollBars.None;
			this.ctbISBN.Texts = "";
			this.ctbISBN.UnderlinedStyle = false;
			this.ctbISBN.Visible = false;
			this.ctbISBN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ctbISBN_KeyPress);
			// 
			// cbtnAddPicture
			// 
			this.cbtnAddPicture.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.cbtnAddPicture.BackColor = System.Drawing.Color.Black;
			this.cbtnAddPicture.BorderColor = System.Drawing.Color.White;
			this.cbtnAddPicture.BorderRadius = 40;
			this.cbtnAddPicture.BorderSize = 0;
			this.cbtnAddPicture.Cursor = System.Windows.Forms.Cursors.Hand;
			this.cbtnAddPicture.FlatAppearance.BorderSize = 0;
			this.cbtnAddPicture.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.cbtnAddPicture.ForeColor = System.Drawing.Color.White;
			this.cbtnAddPicture.Location = new System.Drawing.Point(29, 14);
			this.cbtnAddPicture.Margin = new System.Windows.Forms.Padding(4);
			this.cbtnAddPicture.Name = "cbtnAddPicture";
			this.cbtnAddPicture.Size = new System.Drawing.Size(152, 49);
			this.cbtnAddPicture.TabIndex = 27;
			this.cbtnAddPicture.Text = "Kép cseréje";
			this.cbtnAddPicture.UseVisualStyleBackColor = false;
			this.cbtnAddPicture.Click += new System.EventHandler(this.cbtnAddPicture_Click);
			// 
			// cdtpReleaseDate
			// 
			this.cdtpReleaseDate.BorderColor = System.Drawing.Color.PaleVioletRed;
			this.cdtpReleaseDate.BorderRadius = 1;
			this.cdtpReleaseDate.BorderSize = 2;
			this.cdtpReleaseDate.CustomFormat = "yyyy";
			this.cdtpReleaseDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
			this.cdtpReleaseDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.cdtpReleaseDate.Location = new System.Drawing.Point(29, 206);
			this.cdtpReleaseDate.Margin = new System.Windows.Forms.Padding(4);
			this.cdtpReleaseDate.MinimumSize = new System.Drawing.Size(4, 35);
			this.cdtpReleaseDate.Name = "cdtpReleaseDate";
			this.cdtpReleaseDate.Size = new System.Drawing.Size(236, 35);
			this.cdtpReleaseDate.SkinColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(72)))), ((int)(((byte)(85)))));
			this.cdtpReleaseDate.TabIndex = 24;
			this.cdtpReleaseDate.TextColor = System.Drawing.Color.White;
			// 
			// ctbTitle
			// 
			this.ctbTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(68)))));
			this.ctbTitle.BorderColor = System.Drawing.Color.MediumSlateBlue;
			this.ctbTitle.BorderFocusColor = System.Drawing.Color.HotPink;
			this.ctbTitle.BorderRadius = 10;
			this.ctbTitle.BorderSize = 2;
			this.ctbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.ctbTitle.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.ctbTitle.IsReadOnly = false;
			this.ctbTitle.Location = new System.Drawing.Point(29, 114);
			this.ctbTitle.Margin = new System.Windows.Forms.Padding(5);
			this.ctbTitle.Multiline = false;
			this.ctbTitle.Name = "ctbTitle";
			this.ctbTitle.Padding = new System.Windows.Forms.Padding(13, 9, 13, 9);
			this.ctbTitle.PasswordChar = false;
			this.ctbTitle.PlaceholderColor = System.Drawing.Color.DarkGray;
			this.ctbTitle.PlaceholderText = "";
			this.ctbTitle.Size = new System.Drawing.Size(237, 39);
			this.ctbTitle.TabIndex = 3;
			this.ctbTitle.TextBoxScrollBars = System.Windows.Forms.ScrollBars.None;
			this.ctbTitle.Texts = "";
			this.ctbTitle.UnderlinedStyle = false;
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 1;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27F));
			this.tableLayoutPanel1.Controls.Add(this.panel7, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.panel9, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.panel10, 0, 2);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 3;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 58.14536F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 41.85464F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 149F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(969, 641);
			this.tableLayoutPanel1.TabIndex = 31;
			// 
			// panel7
			// 
			this.panel7.Controls.Add(this.panel1);
			this.panel7.Controls.Add(this.panel3);
			this.panel7.Controls.Add(this.panel2);
			this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel7.Location = new System.Drawing.Point(4, 4);
			this.panel7.Margin = new System.Windows.Forms.Padding(4);
			this.panel7.Name = "panel7";
			this.panel7.Size = new System.Drawing.Size(961, 278);
			this.panel7.TabIndex = 0;
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.ctbISBN);
			this.panel1.Controls.Add(this.ctbTitle);
			this.panel1.Controls.Add(this.label4);
			this.panel1.Controls.Add(this.cdtpReleaseDate);
			this.panel1.Location = new System.Drawing.Point(12, 20);
			this.panel1.Margin = new System.Windows.Forms.Padding(4);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(273, 256);
			this.panel1.TabIndex = 0;
			// 
			// panel3
			// 
			this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.panel3.Controls.Add(this.cbtnAddAuthor);
			this.panel3.Controls.Add(this.cbtnAddCategory);
			this.panel3.Location = new System.Drawing.Point(703, 20);
			this.panel3.Margin = new System.Windows.Forms.Padding(4);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(219, 196);
			this.panel3.TabIndex = 2;
			// 
			// cbtnAddAuthor
			// 
			this.cbtnAddAuthor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.cbtnAddAuthor.BackColor = System.Drawing.Color.Black;
			this.cbtnAddAuthor.BorderColor = System.Drawing.Color.White;
			this.cbtnAddAuthor.BorderRadius = 40;
			this.cbtnAddAuthor.BorderSize = 0;
			this.cbtnAddAuthor.Cursor = System.Windows.Forms.Cursors.Hand;
			this.cbtnAddAuthor.FlatAppearance.BorderSize = 0;
			this.cbtnAddAuthor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.cbtnAddAuthor.ForeColor = System.Drawing.Color.White;
			this.cbtnAddAuthor.Location = new System.Drawing.Point(35, 28);
			this.cbtnAddAuthor.Margin = new System.Windows.Forms.Padding(4);
			this.cbtnAddAuthor.Name = "cbtnAddAuthor";
			this.cbtnAddAuthor.Size = new System.Drawing.Size(163, 43);
			this.cbtnAddAuthor.TabIndex = 12;
			this.cbtnAddAuthor.Text = "Hozzáad";
			this.cbtnAddAuthor.UseVisualStyleBackColor = false;
			this.cbtnAddAuthor.Click += new System.EventHandler(this.cbtnAddAuthor_Click);
			// 
			// cbtnAddCategory
			// 
			this.cbtnAddCategory.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.cbtnAddCategory.BackColor = System.Drawing.Color.Black;
			this.cbtnAddCategory.BorderColor = System.Drawing.Color.White;
			this.cbtnAddCategory.BorderRadius = 40;
			this.cbtnAddCategory.BorderSize = 0;
			this.cbtnAddCategory.Cursor = System.Windows.Forms.Cursors.Hand;
			this.cbtnAddCategory.FlatAppearance.BorderSize = 0;
			this.cbtnAddCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.cbtnAddCategory.ForeColor = System.Drawing.Color.White;
			this.cbtnAddCategory.Location = new System.Drawing.Point(35, 110);
			this.cbtnAddCategory.Margin = new System.Windows.Forms.Padding(4);
			this.cbtnAddCategory.Name = "cbtnAddCategory";
			this.cbtnAddCategory.Size = new System.Drawing.Size(163, 43);
			this.cbtnAddCategory.TabIndex = 14;
			this.cbtnAddCategory.Text = "Hozzáad";
			this.cbtnAddCategory.UseVisualStyleBackColor = false;
			this.cbtnAddCategory.Click += new System.EventHandler(this.cbtnAddCategory_Click);
			// 
			// panel2
			// 
			this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panel2.Controls.Add(this.label9);
			this.panel2.Controls.Add(this.label2);
			this.panel2.Controls.Add(this.pAuthors);
			this.panel2.Controls.Add(this.pCategories);
			this.panel2.Location = new System.Drawing.Point(300, 20);
			this.panel2.Margin = new System.Windows.Forms.Padding(4);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(381, 270);
			this.panel2.TabIndex = 1;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.ForeColor = System.Drawing.SystemColors.Control;
			this.label9.Location = new System.Drawing.Point(16, 12);
			this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(55, 16);
			this.label9.TabIndex = 10;
			this.label9.Text = "Szerzők";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.ForeColor = System.Drawing.SystemColors.Control;
			this.label2.Location = new System.Drawing.Point(16, 143);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(72, 16);
			this.label2.TabIndex = 11;
			this.label2.Text = "Kategóriák";
			// 
			// pAuthors
			// 
			this.pAuthors.Location = new System.Drawing.Point(20, 32);
			this.pAuthors.Margin = new System.Windows.Forms.Padding(4);
			this.pAuthors.Name = "pAuthors";
			this.pAuthors.Size = new System.Drawing.Size(324, 94);
			this.pAuthors.TabIndex = 19;
			// 
			// pCategories
			// 
			this.pCategories.Location = new System.Drawing.Point(20, 162);
			this.pCategories.Margin = new System.Windows.Forms.Padding(4);
			this.pCategories.Name = "pCategories";
			this.pCategories.Size = new System.Drawing.Size(324, 94);
			this.pCategories.TabIndex = 20;
			// 
			// panel9
			// 
			this.panel9.Controls.Add(this.panel4);
			this.panel9.Controls.Add(this.panel5);
			this.panel9.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel9.Location = new System.Drawing.Point(4, 290);
			this.panel9.Margin = new System.Windows.Forms.Padding(4);
			this.panel9.Name = "panel9";
			this.panel9.Size = new System.Drawing.Size(961, 197);
			this.panel9.TabIndex = 1;
			// 
			// panel4
			// 
			this.panel4.Controls.Add(this.label5);
			this.panel4.Controls.Add(this.lblPublisher);
			this.panel4.Controls.Add(this.label7);
			this.panel4.Controls.Add(this.lblLang);
			this.panel4.Location = new System.Drawing.Point(5, 21);
			this.panel4.Margin = new System.Windows.Forms.Padding(4);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(273, 153);
			this.panel4.TabIndex = 3;
			// 
			// panel5
			// 
			this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panel5.Controls.Add(this.label10);
			this.panel5.Controls.Add(this.ctbDescription);
			this.panel5.Location = new System.Drawing.Point(315, 18);
			this.panel5.Margin = new System.Windows.Forms.Padding(4);
			this.panel5.Name = "panel5";
			this.panel5.Size = new System.Drawing.Size(635, 170);
			this.panel5.TabIndex = 4;
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.ForeColor = System.Drawing.SystemColors.Control;
			this.label10.Location = new System.Drawing.Point(4, 22);
			this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(44, 16);
			this.label10.TabIndex = 26;
			this.label10.Text = "Leírás";
			// 
			// ctbDescription
			// 
			this.ctbDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.ctbDescription.AutoScroll = true;
			this.ctbDescription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(68)))));
			this.ctbDescription.BorderColor = System.Drawing.Color.MediumSlateBlue;
			this.ctbDescription.BorderFocusColor = System.Drawing.Color.HotPink;
			this.ctbDescription.BorderRadius = 0;
			this.ctbDescription.BorderSize = 2;
			this.ctbDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.ctbDescription.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.ctbDescription.IsReadOnly = false;
			this.ctbDescription.Location = new System.Drawing.Point(8, 46);
			this.ctbDescription.Margin = new System.Windows.Forms.Padding(5);
			this.ctbDescription.Multiline = true;
			this.ctbDescription.Name = "ctbDescription";
			this.ctbDescription.Padding = new System.Windows.Forms.Padding(13, 9, 13, 9);
			this.ctbDescription.PasswordChar = false;
			this.ctbDescription.PlaceholderColor = System.Drawing.Color.DarkGray;
			this.ctbDescription.PlaceholderText = "";
			this.ctbDescription.Size = new System.Drawing.Size(599, 120);
			this.ctbDescription.TabIndex = 25;
			this.ctbDescription.TextBoxScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.ctbDescription.Texts = "";
			this.ctbDescription.UnderlinedStyle = false;
			// 
			// panel10
			// 
			this.panel10.Controls.Add(this.pManage);
			this.panel10.Controls.Add(this.panel6);
			this.panel10.Controls.Add(this.panel8);
			this.panel10.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel10.Location = new System.Drawing.Point(4, 495);
			this.panel10.Margin = new System.Windows.Forms.Padding(4);
			this.panel10.Name = "panel10";
			this.panel10.Size = new System.Drawing.Size(961, 142);
			this.panel10.TabIndex = 2;
			// 
			// pManage
			// 
			this.pManage.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.pManage.Controls.Add(this.label8);
			this.pManage.Controls.Add(this.cbtnDeactivate);
			this.pManage.Controls.Add(this.label6);
			this.pManage.Controls.Add(this.cbtnAddBook);
			this.pManage.Location = new System.Drawing.Point(255, 11);
			this.pManage.Margin = new System.Windows.Forms.Padding(4);
			this.pManage.Name = "pManage";
			this.pManage.Size = new System.Drawing.Size(439, 111);
			this.pManage.TabIndex = 30;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.ForeColor = System.Drawing.SystemColors.Control;
			this.label8.Location = new System.Drawing.Point(231, 17);
			this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(98, 16);
			this.label8.TabIndex = 23;
			this.label8.Text = "Könyv felvétele";
			// 
			// cbtnDeactivate
			// 
			this.cbtnDeactivate.BackColor = System.Drawing.Color.Black;
			this.cbtnDeactivate.BorderColor = System.Drawing.Color.White;
			this.cbtnDeactivate.BorderRadius = 40;
			this.cbtnDeactivate.BorderSize = 0;
			this.cbtnDeactivate.Cursor = System.Windows.Forms.Cursors.Hand;
			this.cbtnDeactivate.FlatAppearance.BorderSize = 0;
			this.cbtnDeactivate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.cbtnDeactivate.ForeColor = System.Drawing.Color.White;
			this.cbtnDeactivate.Location = new System.Drawing.Point(20, 57);
			this.cbtnDeactivate.Margin = new System.Windows.Forms.Padding(4);
			this.cbtnDeactivate.Name = "cbtnDeactivate";
			this.cbtnDeactivate.Size = new System.Drawing.Size(195, 43);
			this.cbtnDeactivate.TabIndex = 17;
			this.cbtnDeactivate.Text = "Leselejtez";
			this.cbtnDeactivate.UseVisualStyleBackColor = false;
			this.cbtnDeactivate.Click += new System.EventHandler(this.cbtnDeactivate_Click);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.ForeColor = System.Drawing.SystemColors.Control;
			this.label6.Location = new System.Drawing.Point(16, 17);
			this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(127, 16);
			this.label6.TabIndex = 18;
			this.label6.Text = "Könyv leselejtezése";
			// 
			// cbtnAddBook
			// 
			this.cbtnAddBook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(123)))), ((int)(((byte)(106)))));
			this.cbtnAddBook.BorderColor = System.Drawing.Color.White;
			this.cbtnAddBook.BorderRadius = 40;
			this.cbtnAddBook.BorderSize = 0;
			this.cbtnAddBook.Cursor = System.Windows.Forms.Cursors.Hand;
			this.cbtnAddBook.FlatAppearance.BorderSize = 0;
			this.cbtnAddBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.cbtnAddBook.ForeColor = System.Drawing.Color.White;
			this.cbtnAddBook.Location = new System.Drawing.Point(235, 57);
			this.cbtnAddBook.Margin = new System.Windows.Forms.Padding(4);
			this.cbtnAddBook.Name = "cbtnAddBook";
			this.cbtnAddBook.Size = new System.Drawing.Size(195, 43);
			this.cbtnAddBook.TabIndex = 22;
			this.cbtnAddBook.Text = "Felvesz";
			this.cbtnAddBook.UseVisualStyleBackColor = false;
			this.cbtnAddBook.Click += new System.EventHandler(this.cbtnAddBook_Click);
			// 
			// panel6
			// 
			this.panel6.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.panel6.Controls.Add(this.cbtnAddPicture);
			this.panel6.Location = new System.Drawing.Point(47, 51);
			this.panel6.Margin = new System.Windows.Forms.Padding(4);
			this.panel6.Name = "panel6";
			this.panel6.Size = new System.Drawing.Size(203, 71);
			this.panel6.TabIndex = 5;
			// 
			// panel8
			// 
			this.panel8.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.panel8.Controls.Add(this.cbtnBack);
			this.panel8.Location = new System.Drawing.Point(701, 51);
			this.panel8.Margin = new System.Windows.Forms.Padding(4);
			this.panel8.Name = "panel8";
			this.panel8.Size = new System.Drawing.Size(212, 71);
			this.panel8.TabIndex = 7;
			// 
			// cbtnBack
			// 
			this.cbtnBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.cbtnBack.BackColor = System.Drawing.Color.Black;
			this.cbtnBack.BorderColor = System.Drawing.Color.White;
			this.cbtnBack.BorderRadius = 40;
			this.cbtnBack.BorderSize = 0;
			this.cbtnBack.Cursor = System.Windows.Forms.Cursors.Hand;
			this.cbtnBack.FlatAppearance.BorderSize = 0;
			this.cbtnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.cbtnBack.ForeColor = System.Drawing.Color.White;
			this.cbtnBack.Location = new System.Drawing.Point(21, 17);
			this.cbtnBack.Margin = new System.Windows.Forms.Padding(4);
			this.cbtnBack.Name = "cbtnBack";
			this.cbtnBack.Size = new System.Drawing.Size(163, 43);
			this.cbtnBack.TabIndex = 16;
			this.cbtnBack.Text = "Vissza";
			this.cbtnBack.UseVisualStyleBackColor = false;
			this.cbtnBack.Click += new System.EventHandler(this.cbtnBack_Click);
			// 
			// BookDetailedPage
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(68)))));
			this.ClientSize = new System.Drawing.Size(969, 641);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Controls.Add(this.lblPicName);
			this.Controls.Add(this.lblISBN);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "BookDetailedPage";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BookDetailedPage_FormClosing);
			this.Load += new System.EventHandler(this.BookDetailedPage_Load);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.panel7.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panel3.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.panel9.ResumeLayout(false);
			this.panel4.ResumeLayout(false);
			this.panel4.PerformLayout();
			this.panel5.ResumeLayout(false);
			this.panel5.PerformLayout();
			this.panel10.ResumeLayout(false);
			this.pManage.ResumeLayout(false);
			this.pManage.PerformLayout();
			this.panel6.ResumeLayout(false);
			this.panel8.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblISBN;
        private System.Windows.Forms.Label label3;
        private CustomTextbox ctbTitle;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblPublisher;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblLang;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private CustomDateTimePicker cdtpReleaseDate;
        private System.Windows.Forms.OpenFileDialog ofdPic;
        private CustomButton cbtnAddPicture;
        private System.Windows.Forms.Label lblPicName;
        private CustomTextbox ctbISBN;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pAuthors;
        private System.Windows.Forms.Panel pCategories;
        private System.Windows.Forms.Panel panel3;
        private CustomButton cbtnAddAuthor;
        private CustomButton cbtnAddCategory;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label10;
        private CustomTextbox ctbDescription;
        private System.Windows.Forms.Panel pManage;
        private System.Windows.Forms.Label label8;
        private CustomButton cbtnDeactivate;
        private System.Windows.Forms.Label label6;
        private CustomButton cbtnAddBook;
        private System.Windows.Forms.Panel panel8;
        private CustomButton cbtnBack;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel10;
    }
}