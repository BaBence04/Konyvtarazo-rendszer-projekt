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
            this.label9 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label6 = new System.Windows.Forms.Label();
            this.pAuthors = new System.Windows.Forms.Panel();
            this.pCategories = new System.Windows.Forms.Panel();
            this.lblAuthorDeleteMode = new System.Windows.Forms.Label();
            this.lblCategoryDeleteMode = new System.Windows.Forms.Label();
            this.cbtnDeactivate = new Desktop.CustomButton();
            this.cbtnBack = new Desktop.CustomButton();
            this.cbtnDeleteCategory = new Desktop.CustomButton();
            this.cbtnAddCategory = new Desktop.CustomButton();
            this.cbtnDeleteAuthor = new Desktop.CustomButton();
            this.cbtnAddAuthor = new Desktop.CustomButton();
            this.ctbTitle = new Desktop.CustomTextbox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbtnAddBook = new Desktop.CustomButton();
            this.cdtpReleaseDate = new Desktop.CustomDateTimePicker();
            this.ctbDescription = new Desktop.CustomTextbox();
            this.label10 = new System.Windows.Forms.Label();
            this.ofdPic = new System.Windows.Forms.OpenFileDialog();
            this.cbtnAddPicture = new Desktop.CustomButton();
            this.lblPicName = new System.Windows.Forms.Label();
            this.ctbISBN = new Desktop.CustomTextbox();
            this.pManage = new System.Windows.Forms.Panel();
            this.pManage.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ISBN";
            // 
            // lblISBN
            // 
            this.lblISBN.AutoSize = true;
            this.lblISBN.Location = new System.Drawing.Point(42, 45);
            this.lblISBN.Name = "lblISBN";
            this.lblISBN.Size = new System.Drawing.Size(35, 13);
            this.lblISBN.TabIndex = 1;
            this.lblISBN.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Könyv cím";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Megjelenési dátum";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 235);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Kiadó";
            // 
            // lblPublisher
            // 
            this.lblPublisher.AutoSize = true;
            this.lblPublisher.Location = new System.Drawing.Point(42, 264);
            this.lblPublisher.Name = "lblPublisher";
            this.lblPublisher.Size = new System.Drawing.Size(34, 13);
            this.lblPublisher.TabIndex = 7;
            this.lblPublisher.Text = "Kiadó";
            this.lblPublisher.Click += new System.EventHandler(this.lblPublisher_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 297);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Nyelv";
            // 
            // lblLang
            // 
            this.lblLang.AutoSize = true;
            this.lblLang.Location = new System.Drawing.Point(42, 325);
            this.lblLang.Name = "lblLang";
            this.lblLang.Size = new System.Drawing.Size(34, 13);
            this.lblLang.TabIndex = 9;
            this.lblLang.Text = "Nyelv";
            this.lblLang.Click += new System.EventHandler(this.lblLang_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(316, 61);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "Szerzők";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(316, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Kategóriák";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Könyv leselejtezése";
            // 
            // pAuthors
            // 
            this.pAuthors.Location = new System.Drawing.Point(319, 77);
            this.pAuthors.Name = "pAuthors";
            this.pAuthors.Size = new System.Drawing.Size(225, 76);
            this.pAuthors.TabIndex = 19;
            // 
            // pCategories
            // 
            this.pCategories.Location = new System.Drawing.Point(319, 194);
            this.pCategories.Name = "pCategories";
            this.pCategories.Size = new System.Drawing.Size(225, 76);
            this.pCategories.TabIndex = 20;
            // 
            // lblAuthorDeleteMode
            // 
            this.lblAuthorDeleteMode.AutoSize = true;
            this.lblAuthorDeleteMode.ForeColor = System.Drawing.Color.Red;
            this.lblAuthorDeleteMode.Location = new System.Drawing.Point(430, 61);
            this.lblAuthorDeleteMode.Name = "lblAuthorDeleteMode";
            this.lblAuthorDeleteMode.Size = new System.Drawing.Size(114, 13);
            this.lblAuthorDeleteMode.TabIndex = 0;
            this.lblAuthorDeleteMode.Text = "Szerzők törlés módban";
            this.lblAuthorDeleteMode.Visible = false;
            // 
            // lblCategoryDeleteMode
            // 
            this.lblCategoryDeleteMode.AutoSize = true;
            this.lblCategoryDeleteMode.ForeColor = System.Drawing.Color.Red;
            this.lblCategoryDeleteMode.Location = new System.Drawing.Point(417, 178);
            this.lblCategoryDeleteMode.Name = "lblCategoryDeleteMode";
            this.lblCategoryDeleteMode.Size = new System.Drawing.Size(127, 13);
            this.lblCategoryDeleteMode.TabIndex = 21;
            this.lblCategoryDeleteMode.Text = "Kategóriák törlés módban";
            this.lblCategoryDeleteMode.Visible = false;
            // 
            // cbtnDeactivate
            // 
            this.cbtnDeactivate.BackColor = System.Drawing.Color.Black;
            this.cbtnDeactivate.BorderColor = System.Drawing.Color.White;
            this.cbtnDeactivate.BorderRadius = 40;
            this.cbtnDeactivate.BorderSize = 0;
            this.cbtnDeactivate.FlatAppearance.BorderSize = 0;
            this.cbtnDeactivate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbtnDeactivate.ForeColor = System.Drawing.Color.White;
            this.cbtnDeactivate.Location = new System.Drawing.Point(15, 40);
            this.cbtnDeactivate.Name = "cbtnDeactivate";
            this.cbtnDeactivate.Size = new System.Drawing.Size(146, 35);
            this.cbtnDeactivate.TabIndex = 17;
            this.cbtnDeactivate.Text = "Leselejtez";
            this.cbtnDeactivate.UseVisualStyleBackColor = false;
            this.cbtnDeactivate.Click += new System.EventHandler(this.cbtnDeactivate_Click);
            // 
            // cbtnBack
            // 
            this.cbtnBack.BackColor = System.Drawing.Color.Black;
            this.cbtnBack.BorderColor = System.Drawing.Color.White;
            this.cbtnBack.BorderRadius = 40;
            this.cbtnBack.BorderSize = 0;
            this.cbtnBack.FlatAppearance.BorderSize = 0;
            this.cbtnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbtnBack.ForeColor = System.Drawing.Color.White;
            this.cbtnBack.Location = new System.Drawing.Point(573, 403);
            this.cbtnBack.Name = "cbtnBack";
            this.cbtnBack.Size = new System.Drawing.Size(122, 35);
            this.cbtnBack.TabIndex = 16;
            this.cbtnBack.Text = "Vissza";
            this.cbtnBack.UseVisualStyleBackColor = false;
            this.cbtnBack.Click += new System.EventHandler(this.cbtnBack_Click);
            // 
            // cbtnDeleteCategory
            // 
            this.cbtnDeleteCategory.BackColor = System.Drawing.Color.Black;
            this.cbtnDeleteCategory.BorderColor = System.Drawing.Color.White;
            this.cbtnDeleteCategory.BorderRadius = 40;
            this.cbtnDeleteCategory.BorderSize = 0;
            this.cbtnDeleteCategory.FlatAppearance.BorderSize = 0;
            this.cbtnDeleteCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbtnDeleteCategory.ForeColor = System.Drawing.Color.White;
            this.cbtnDeleteCategory.Location = new System.Drawing.Point(550, 235);
            this.cbtnDeleteCategory.Name = "cbtnDeleteCategory";
            this.cbtnDeleteCategory.Size = new System.Drawing.Size(122, 35);
            this.cbtnDeleteCategory.TabIndex = 15;
            this.cbtnDeleteCategory.Text = "Töröl";
            this.cbtnDeleteCategory.UseVisualStyleBackColor = false;
            this.cbtnDeleteCategory.Click += new System.EventHandler(this.cbtnDeleteCategory_Click);
            // 
            // cbtnAddCategory
            // 
            this.cbtnAddCategory.BackColor = System.Drawing.Color.Black;
            this.cbtnAddCategory.BorderColor = System.Drawing.Color.White;
            this.cbtnAddCategory.BorderRadius = 40;
            this.cbtnAddCategory.BorderSize = 0;
            this.cbtnAddCategory.FlatAppearance.BorderSize = 0;
            this.cbtnAddCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbtnAddCategory.ForeColor = System.Drawing.Color.White;
            this.cbtnAddCategory.Location = new System.Drawing.Point(550, 194);
            this.cbtnAddCategory.Name = "cbtnAddCategory";
            this.cbtnAddCategory.Size = new System.Drawing.Size(122, 35);
            this.cbtnAddCategory.TabIndex = 14;
            this.cbtnAddCategory.Text = "Hozzáad";
            this.cbtnAddCategory.UseVisualStyleBackColor = false;
            this.cbtnAddCategory.Click += new System.EventHandler(this.cbtnAddCategory_Click);
            // 
            // cbtnDeleteAuthor
            // 
            this.cbtnDeleteAuthor.BackColor = System.Drawing.Color.Black;
            this.cbtnDeleteAuthor.BorderColor = System.Drawing.Color.White;
            this.cbtnDeleteAuthor.BorderRadius = 40;
            this.cbtnDeleteAuthor.BorderSize = 0;
            this.cbtnDeleteAuthor.FlatAppearance.BorderSize = 0;
            this.cbtnDeleteAuthor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbtnDeleteAuthor.ForeColor = System.Drawing.Color.White;
            this.cbtnDeleteAuthor.Location = new System.Drawing.Point(550, 118);
            this.cbtnDeleteAuthor.Name = "cbtnDeleteAuthor";
            this.cbtnDeleteAuthor.Size = new System.Drawing.Size(122, 35);
            this.cbtnDeleteAuthor.TabIndex = 13;
            this.cbtnDeleteAuthor.Text = "Töröl";
            this.cbtnDeleteAuthor.UseVisualStyleBackColor = false;
            this.cbtnDeleteAuthor.Click += new System.EventHandler(this.cbtnDeleteAuthor_Click);
            // 
            // cbtnAddAuthor
            // 
            this.cbtnAddAuthor.BackColor = System.Drawing.Color.Black;
            this.cbtnAddAuthor.BorderColor = System.Drawing.Color.White;
            this.cbtnAddAuthor.BorderRadius = 40;
            this.cbtnAddAuthor.BorderSize = 0;
            this.cbtnAddAuthor.FlatAppearance.BorderSize = 0;
            this.cbtnAddAuthor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbtnAddAuthor.ForeColor = System.Drawing.Color.White;
            this.cbtnAddAuthor.Location = new System.Drawing.Point(550, 77);
            this.cbtnAddAuthor.Name = "cbtnAddAuthor";
            this.cbtnAddAuthor.Size = new System.Drawing.Size(122, 35);
            this.cbtnAddAuthor.TabIndex = 12;
            this.cbtnAddAuthor.Text = "Hozzáad";
            this.cbtnAddAuthor.UseVisualStyleBackColor = false;
            this.cbtnAddAuthor.Click += new System.EventHandler(this.cbtnAddAuthor_Click);
            // 
            // ctbTitle
            // 
            this.ctbTitle.BackColor = System.Drawing.SystemColors.Window;
            this.ctbTitle.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.ctbTitle.BorderFocusColor = System.Drawing.Color.HotPink;
            this.ctbTitle.BorderRadius = 10;
            this.ctbTitle.BorderSize = 2;
            this.ctbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ctbTitle.ForeColor = System.Drawing.Color.DimGray;
            this.ctbTitle.IsReadOnly = false;
            this.ctbTitle.Location = new System.Drawing.Point(24, 98);
            this.ctbTitle.Margin = new System.Windows.Forms.Padding(4);
            this.ctbTitle.Multiline = false;
            this.ctbTitle.Name = "ctbTitle";
            this.ctbTitle.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.ctbTitle.PasswordChar = false;
            this.ctbTitle.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.ctbTitle.PlaceholderText = "";
            this.ctbTitle.Size = new System.Drawing.Size(178, 31);
            this.ctbTitle.TabIndex = 3;
            this.ctbTitle.Texts = "";
            this.ctbTitle.UnderlinedStyle = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(188, 14);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 13);
            this.label8.TabIndex = 23;
            this.label8.Text = "Könyv felvétele";
            // 
            // cbtnAddBook
            // 
            this.cbtnAddBook.BackColor = System.Drawing.Color.Black;
            this.cbtnAddBook.BorderColor = System.Drawing.Color.White;
            this.cbtnAddBook.BorderRadius = 40;
            this.cbtnAddBook.BorderSize = 0;
            this.cbtnAddBook.FlatAppearance.BorderSize = 0;
            this.cbtnAddBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbtnAddBook.ForeColor = System.Drawing.Color.White;
            this.cbtnAddBook.Location = new System.Drawing.Point(191, 40);
            this.cbtnAddBook.Name = "cbtnAddBook";
            this.cbtnAddBook.Size = new System.Drawing.Size(146, 35);
            this.cbtnAddBook.TabIndex = 22;
            this.cbtnAddBook.Text = "Felvesz";
            this.cbtnAddBook.UseVisualStyleBackColor = false;
            this.cbtnAddBook.Click += new System.EventHandler(this.cbtnAddBook_Click);
            // 
            // cdtpReleaseDate
            // 
            this.cdtpReleaseDate.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.cdtpReleaseDate.BorderRadius = 1;
            this.cdtpReleaseDate.BorderSize = 0;
            this.cdtpReleaseDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.cdtpReleaseDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.cdtpReleaseDate.Location = new System.Drawing.Point(24, 178);
            this.cdtpReleaseDate.MinimumSize = new System.Drawing.Size(4, 35);
            this.cdtpReleaseDate.Name = "cdtpReleaseDate";
            this.cdtpReleaseDate.Size = new System.Drawing.Size(178, 35);
            this.cdtpReleaseDate.SkinColor = System.Drawing.Color.MediumSlateBlue;
            this.cdtpReleaseDate.TabIndex = 24;
            this.cdtpReleaseDate.TextColor = System.Drawing.Color.White;
            // 
            // ctbDescription
            // 
            this.ctbDescription.BackColor = System.Drawing.SystemColors.Window;
            this.ctbDescription.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.ctbDescription.BorderFocusColor = System.Drawing.Color.HotPink;
            this.ctbDescription.BorderRadius = 0;
            this.ctbDescription.BorderSize = 2;
            this.ctbDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ctbDescription.ForeColor = System.Drawing.Color.DimGray;
            this.ctbDescription.IsReadOnly = false;
            this.ctbDescription.Location = new System.Drawing.Point(123, 264);
            this.ctbDescription.Margin = new System.Windows.Forms.Padding(4);
            this.ctbDescription.Multiline = true;
            this.ctbDescription.Name = "ctbDescription";
            this.ctbDescription.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.ctbDescription.PasswordChar = false;
            this.ctbDescription.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.ctbDescription.PlaceholderText = "";
            this.ctbDescription.Size = new System.Drawing.Size(186, 91);
            this.ctbDescription.TabIndex = 25;
            this.ctbDescription.Texts = "";
            this.ctbDescription.UnderlinedStyle = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(120, 247);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 13);
            this.label10.TabIndex = 26;
            this.label10.Text = "Leírás";
            // 
            // ofdPic
            // 
            this.ofdPic.FileName = "openFileDialog1";
            this.ofdPic.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.webp;*.svg;*.bmp";
            // 
            // cbtnAddPicture
            // 
            this.cbtnAddPicture.BackColor = System.Drawing.Color.Black;
            this.cbtnAddPicture.BorderColor = System.Drawing.Color.White;
            this.cbtnAddPicture.BorderRadius = 40;
            this.cbtnAddPicture.BorderSize = 0;
            this.cbtnAddPicture.FlatAppearance.BorderSize = 0;
            this.cbtnAddPicture.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbtnAddPicture.ForeColor = System.Drawing.Color.White;
            this.cbtnAddPicture.Location = new System.Drawing.Point(24, 387);
            this.cbtnAddPicture.Name = "cbtnAddPicture";
            this.cbtnAddPicture.Size = new System.Drawing.Size(92, 40);
            this.cbtnAddPicture.TabIndex = 27;
            this.cbtnAddPicture.Text = "Kép cseréje";
            this.cbtnAddPicture.UseVisualStyleBackColor = false;
            this.cbtnAddPicture.Click += new System.EventHandler(this.cbtnAddPicture_Click);
            // 
            // lblPicName
            // 
            this.lblPicName.AutoSize = true;
            this.lblPicName.Location = new System.Drawing.Point(122, 403);
            this.lblPicName.Name = "lblPicName";
            this.lblPicName.Size = new System.Drawing.Size(0, 13);
            this.lblPicName.TabIndex = 28;
            // 
            // ctbISBN
            // 
            this.ctbISBN.BackColor = System.Drawing.SystemColors.Window;
            this.ctbISBN.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.ctbISBN.BorderFocusColor = System.Drawing.Color.HotPink;
            this.ctbISBN.BorderRadius = 10;
            this.ctbISBN.BorderSize = 2;
            this.ctbISBN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ctbISBN.ForeColor = System.Drawing.Color.DimGray;
            this.ctbISBN.IsReadOnly = false;
            this.ctbISBN.Location = new System.Drawing.Point(24, 35);
            this.ctbISBN.Margin = new System.Windows.Forms.Padding(4);
            this.ctbISBN.Multiline = false;
            this.ctbISBN.Name = "ctbISBN";
            this.ctbISBN.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.ctbISBN.PasswordChar = false;
            this.ctbISBN.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.ctbISBN.PlaceholderText = "";
            this.ctbISBN.Size = new System.Drawing.Size(178, 31);
            this.ctbISBN.TabIndex = 29;
            this.ctbISBN.Texts = "";
            this.ctbISBN.UnderlinedStyle = false;
            this.ctbISBN.Visible = false;
            this.ctbISBN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ctbISBN_KeyPress);
            // 
            // pManage
            // 
            this.pManage.Controls.Add(this.label8);
            this.pManage.Controls.Add(this.cbtnDeactivate);
            this.pManage.Controls.Add(this.label6);
            this.pManage.Controls.Add(this.cbtnAddBook);
            this.pManage.Location = new System.Drawing.Point(335, 297);
            this.pManage.Name = "pManage";
            this.pManage.Size = new System.Drawing.Size(348, 100);
            this.pManage.TabIndex = 30;
            // 
            // BookDetailedPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 450);
            this.Controls.Add(this.pManage);
            this.Controls.Add(this.ctbISBN);
            this.Controls.Add(this.lblPicName);
            this.Controls.Add(this.cbtnAddPicture);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.ctbDescription);
            this.Controls.Add(this.cdtpReleaseDate);
            this.Controls.Add(this.lblCategoryDeleteMode);
            this.Controls.Add(this.lblAuthorDeleteMode);
            this.Controls.Add(this.pCategories);
            this.Controls.Add(this.pAuthors);
            this.Controls.Add(this.cbtnBack);
            this.Controls.Add(this.cbtnDeleteCategory);
            this.Controls.Add(this.cbtnAddCategory);
            this.Controls.Add(this.cbtnDeleteAuthor);
            this.Controls.Add(this.cbtnAddAuthor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblLang);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblPublisher);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ctbTitle);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblISBN);
            this.Controls.Add(this.label1);
            this.Name = "BookDetailedPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BookDetailedPage_FormClosing);
            this.Load += new System.EventHandler(this.BookDetailedPage_Load);
            this.pManage.ResumeLayout(false);
            this.pManage.PerformLayout();
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
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label2;
        private CustomButton cbtnAddAuthor;
        private CustomButton cbtnDeleteAuthor;
        private CustomButton cbtnDeleteCategory;
        private CustomButton cbtnAddCategory;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private CustomButton cbtnBack;
        private CustomButton cbtnDeactivate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel pAuthors;
        private System.Windows.Forms.Panel pCategories;
        private System.Windows.Forms.Label lblAuthorDeleteMode;
        private System.Windows.Forms.Label lblCategoryDeleteMode;
        private System.Windows.Forms.Label label8;
        private CustomButton cbtnAddBook;
        private CustomDateTimePicker cdtpReleaseDate;
        private CustomTextbox ctbDescription;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.OpenFileDialog ofdPic;
        private CustomButton cbtnAddPicture;
        private System.Windows.Forms.Label lblPicName;
        private CustomTextbox ctbISBN;
        private System.Windows.Forms.Panel pManage;
    }
}