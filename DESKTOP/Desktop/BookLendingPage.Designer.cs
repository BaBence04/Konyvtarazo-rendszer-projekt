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
			this.label1.Location = new System.Drawing.Point(208, 11);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(536, 54);
			this.label1.TabIndex = 2;
			this.label1.Text = "Ez a könyv kiadása oldal";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.label5.Location = new System.Drawing.Point(47, 146);
			this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(112, 25);
			this.label5.TabIndex = 10;
			this.label5.Text = "Könyv cím";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.label2.Location = new System.Drawing.Point(47, 236);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(129, 25);
			this.label2.TabIndex = 11;
			this.label2.Text = "Könyv ISBN";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.label3.Location = new System.Drawing.Point(401, 146);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(50, 25);
			this.label3.TabIndex = 12;
			this.label3.Text = "Név";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.label4.Location = new System.Drawing.Point(401, 236);
			this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(164, 25);
			this.label4.TabIndex = 13;
			this.label4.Text = "Felhasználónév";
			// 
			// pChooseBook
			// 
			this.pChooseBook.Controls.Add(this.cbtnChooseBook);
			this.pChooseBook.Location = new System.Drawing.Point(33, 148);
			this.pChooseBook.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.pChooseBook.Name = "pChooseBook";
			this.pChooseBook.Size = new System.Drawing.Size(232, 158);
			this.pChooseBook.TabIndex = 14;
			this.pChooseBook.Visible = false;
			// 
			// cbtnChooseBook
			// 
			this.cbtnChooseBook.BackColor = System.Drawing.Color.Black;
			this.cbtnChooseBook.BorderColor = System.Drawing.Color.White;
			this.cbtnChooseBook.BorderRadius = 40;
			this.cbtnChooseBook.BorderSize = 0;
			this.cbtnChooseBook.Cursor = System.Windows.Forms.Cursors.Hand;
			this.cbtnChooseBook.FlatAppearance.BorderSize = 0;
			this.cbtnChooseBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.cbtnChooseBook.ForeColor = System.Drawing.Color.White;
			this.cbtnChooseBook.Location = new System.Drawing.Point(32, 28);
			this.cbtnChooseBook.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.cbtnChooseBook.Name = "cbtnChooseBook";
			this.cbtnChooseBook.Size = new System.Drawing.Size(176, 106);
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
			this.lblTitle.Location = new System.Drawing.Point(112, 191);
			this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblTitle.Name = "lblTitle";
			this.lblTitle.Size = new System.Drawing.Size(75, 25);
			this.lblTitle.TabIndex = 16;
			this.lblTitle.Text = "notSet";
			// 
			// lblUname
			// 
			this.lblUname.AutoSize = true;
			this.lblUname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.lblUname.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.lblUname.Location = new System.Drawing.Point(452, 281);
			this.lblUname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblUname.Name = "lblUname";
			this.lblUname.Size = new System.Drawing.Size(75, 25);
			this.lblUname.TabIndex = 17;
			this.lblUname.Text = "notSet";
			// 
			// lblIsbn
			// 
			this.lblIsbn.AutoSize = true;
			this.lblIsbn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.lblIsbn.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.lblIsbn.Location = new System.Drawing.Point(112, 281);
			this.lblIsbn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblIsbn.Name = "lblIsbn";
			this.lblIsbn.Size = new System.Drawing.Size(75, 25);
			this.lblIsbn.TabIndex = 18;
			this.lblIsbn.Text = "notSet";
			// 
			// lblName
			// 
			this.lblName.AutoSize = true;
			this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.lblName.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.lblName.Location = new System.Drawing.Point(452, 191);
			this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblName.Name = "lblName";
			this.lblName.Size = new System.Drawing.Size(75, 25);
			this.lblName.TabIndex = 19;
			this.lblName.Text = "notSet";
			// 
			// pChooseUser
			// 
			this.pChooseUser.Controls.Add(this.cbtnChooseUser);
			this.pChooseUser.Location = new System.Drawing.Point(369, 148);
			this.pChooseUser.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.pChooseUser.Name = "pChooseUser";
			this.pChooseUser.Size = new System.Drawing.Size(232, 158);
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
			this.cbtnChooseUser.Location = new System.Drawing.Point(32, 28);
			this.cbtnChooseUser.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.cbtnChooseUser.Name = "cbtnChooseUser";
			this.cbtnChooseUser.Size = new System.Drawing.Size(176, 106);
			this.cbtnChooseUser.TabIndex = 16;
			this.cbtnChooseUser.Text = "Felhasználó kiválasztása";
			this.cbtnChooseUser.UseVisualStyleBackColor = false;
			this.cbtnChooseUser.Click += new System.EventHandler(this.cbtnChooseUser_Click);
			// 
			// cbtnKiad
			// 
			this.cbtnKiad.BackColor = System.Drawing.Color.Black;
			this.cbtnKiad.BorderColor = System.Drawing.Color.White;
			this.cbtnKiad.BorderRadius = 40;
			this.cbtnKiad.BorderSize = 0;
			this.cbtnKiad.FlatAppearance.BorderSize = 0;
			this.cbtnKiad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.cbtnKiad.ForeColor = System.Drawing.Color.White;
			this.cbtnKiad.Location = new System.Drawing.Point(607, 624);
			this.cbtnKiad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.cbtnKiad.Name = "cbtnKiad";
			this.cbtnKiad.Size = new System.Drawing.Size(176, 49);
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
			this.backBtn.Location = new System.Drawing.Point(33, 624);
			this.backBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.backBtn.Name = "backBtn";
			this.backBtn.Size = new System.Drawing.Size(176, 49);
			this.backBtn.TabIndex = 15;
			this.backBtn.Text = "Vissza";
			this.backBtn.UseVisualStyleBackColor = false;
			this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
			// 
			// BookLendingPage
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(68)))));
			this.ClientSize = new System.Drawing.Size(987, 688);
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
			this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
    }
}