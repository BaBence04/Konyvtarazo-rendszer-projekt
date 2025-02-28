namespace Desktop
{
	partial class BookLendingPage
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
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pChooseBook = new System.Windows.Forms.Panel();
            this.cbtnChooseBook = new Desktop.CustomButton();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblUname = new System.Windows.Forms.Label();
            this.lblIsbn = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.pChooseUser = new System.Windows.Forms.Panel();
            this.cbtnChooseUser = new Desktop.CustomButton();
            this.lblHistory = new System.Windows.Forms.Label();
            this.cbtnKiad = new Desktop.CustomButton();
            this.backBtn = new Desktop.CustomButton();
            this.pChooseBook.SuspendLayout();
            this.pChooseUser.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(156, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(431, 42);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ez a könyv kiadása oldal";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(35, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Könyv cím";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(35, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Könyv ISBN";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(301, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Név";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(301, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "Felhasználónév";
            // 
            // pChooseBook
            // 
            this.pChooseBook.Controls.Add(this.cbtnChooseBook);
            this.pChooseBook.Location = new System.Drawing.Point(25, 120);
            this.pChooseBook.Name = "pChooseBook";
            this.pChooseBook.Size = new System.Drawing.Size(174, 128);
            this.pChooseBook.TabIndex = 14;
            this.pChooseBook.Visible = false;
            // 
            // cbtnChooseBook
            // 
            this.cbtnChooseBook.BackColor = System.Drawing.Color.Black;
            this.cbtnChooseBook.BorderColor = System.Drawing.Color.White;
            this.cbtnChooseBook.BorderRadius = 30;
            this.cbtnChooseBook.BorderSize = 0;
            this.cbtnChooseBook.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbtnChooseBook.FlatAppearance.BorderSize = 0;
            this.cbtnChooseBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbtnChooseBook.ForeColor = System.Drawing.Color.White;
            this.cbtnChooseBook.Location = new System.Drawing.Point(24, 23);
            this.cbtnChooseBook.Name = "cbtnChooseBook";
            this.cbtnChooseBook.Size = new System.Drawing.Size(132, 32);
            this.cbtnChooseBook.TabIndex = 16;
            this.cbtnChooseBook.Text = "Konyv kiválasztása";
            this.cbtnChooseBook.UseVisualStyleBackColor = false;
            this.cbtnChooseBook.Click += new System.EventHandler(this.cbtnChooseBook_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblTitle.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblTitle.Location = new System.Drawing.Point(84, 155);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(63, 20);
            this.lblTitle.TabIndex = 16;
            this.lblTitle.Text = "notSet";
            // 
            // lblUname
            // 
            this.lblUname.AutoSize = true;
            this.lblUname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblUname.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblUname.Location = new System.Drawing.Point(339, 228);
            this.lblUname.Name = "lblUname";
            this.lblUname.Size = new System.Drawing.Size(63, 20);
            this.lblUname.TabIndex = 17;
            this.lblUname.Text = "notSet";
            // 
            // lblIsbn
            // 
            this.lblIsbn.AutoSize = true;
            this.lblIsbn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblIsbn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblIsbn.Location = new System.Drawing.Point(84, 228);
            this.lblIsbn.Name = "lblIsbn";
            this.lblIsbn.Size = new System.Drawing.Size(63, 20);
            this.lblIsbn.TabIndex = 18;
            this.lblIsbn.Text = "notSet";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblName.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblName.Location = new System.Drawing.Point(339, 155);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(63, 20);
            this.lblName.TabIndex = 19;
            this.lblName.Text = "notSet";
            // 
            // pChooseUser
            // 
            this.pChooseUser.Controls.Add(this.cbtnChooseUser);
            this.pChooseUser.Location = new System.Drawing.Point(277, 120);
            this.pChooseUser.Name = "pChooseUser";
            this.pChooseUser.Size = new System.Drawing.Size(174, 128);
            this.pChooseUser.TabIndex = 17;
            this.pChooseUser.Visible = false;
            // 
            // cbtnChooseUser
            // 
            this.cbtnChooseUser.BackColor = System.Drawing.Color.Black;
            this.cbtnChooseUser.BorderColor = System.Drawing.Color.White;
            this.cbtnChooseUser.BorderRadius = 40;
            this.cbtnChooseUser.BorderSize = 0;
            this.cbtnChooseUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbtnChooseUser.FlatAppearance.BorderSize = 0;
            this.cbtnChooseUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbtnChooseUser.ForeColor = System.Drawing.Color.White;
            this.cbtnChooseUser.Location = new System.Drawing.Point(13, 16);
            this.cbtnChooseUser.Name = "cbtnChooseUser";
            this.cbtnChooseUser.Size = new System.Drawing.Size(147, 46);
            this.cbtnChooseUser.TabIndex = 16;
            this.cbtnChooseUser.Text = "Felhasználó kiválasztása";
            this.cbtnChooseUser.UseVisualStyleBackColor = false;
            this.cbtnChooseUser.Click += new System.EventHandler(this.cbtnChooseUser_Click);
            // 
            // lblHistory
            // 
            this.lblHistory.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblHistory.AutoSize = true;
            this.lblHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.75F);
            this.lblHistory.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblHistory.Location = new System.Drawing.Point(156, 364);
            this.lblHistory.Name = "lblHistory";
            this.lblHistory.Size = new System.Drawing.Size(175, 29);
            this.lblHistory.TabIndex = 21;
            this.lblHistory.Text = "Olvasas history";
            // 
            // cbtnKiad
            // 
            this.cbtnKiad.BackColor = System.Drawing.Color.Black;
            this.cbtnKiad.BorderColor = System.Drawing.Color.White;
            this.cbtnKiad.BorderRadius = 40;
            this.cbtnKiad.BorderSize = 0;
            this.cbtnKiad.Enabled = false;
            this.cbtnKiad.FlatAppearance.BorderSize = 0;
            this.cbtnKiad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbtnKiad.ForeColor = System.Drawing.Color.White;
            this.cbtnKiad.Location = new System.Drawing.Point(455, 507);
            this.cbtnKiad.Name = "cbtnKiad";
            this.cbtnKiad.Size = new System.Drawing.Size(132, 40);
            this.cbtnKiad.TabIndex = 20;
            this.cbtnKiad.Text = "Kiadás";
            this.cbtnKiad.UseVisualStyleBackColor = false;
            this.cbtnKiad.Click += new System.EventHandler(this.cbtnKiad_Click);
            // 
            // backBtn
            // 
            this.backBtn.BackColor = System.Drawing.Color.Black;
            this.backBtn.BorderColor = System.Drawing.Color.White;
            this.backBtn.BorderRadius = 40;
            this.backBtn.BorderSize = 0;
            this.backBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backBtn.FlatAppearance.BorderSize = 0;
            this.backBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backBtn.ForeColor = System.Drawing.Color.White;
            this.backBtn.Location = new System.Drawing.Point(25, 507);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(132, 40);
            this.backBtn.TabIndex = 15;
            this.backBtn.Text = "Vissza";
            this.backBtn.UseVisualStyleBackColor = false;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // BookLendingPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(68)))));
            this.ClientSize = new System.Drawing.Size(740, 559);
            this.Controls.Add(this.lblHistory);
            this.Controls.Add(this.cbtnKiad);
            this.Controls.Add(this.pChooseUser);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.pChooseBook);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblIsbn);
            this.Controls.Add(this.lblUname);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "BookLendingPage";
            this.Text = "BookLendingPage";
            this.pChooseBook.ResumeLayout(false);
            this.pChooseUser.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel pChooseBook;
        private CustomButton backBtn;
        private CustomButton cbtnChooseBook;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblUname;
        private System.Windows.Forms.Label lblIsbn;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Panel pChooseUser;
        private CustomButton cbtnChooseUser;
        private CustomButton cbtnKiad;
        private System.Windows.Forms.Label lblHistory;
    }
}