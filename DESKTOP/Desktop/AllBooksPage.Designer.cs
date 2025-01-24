namespace Desktop
{
	partial class AllBooksPage
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cdgvBooks = new Desktop.CustomDataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnKeres = new Desktop.CustomButton();
            this.ctbSearch = new Desktop.CustomTextbox();
            this.customButton1 = new Desktop.CustomButton();
            ((System.ComponentModel.ISupportInitialize)(this.cdgvBooks)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cdgvBooks
            // 
            this.cdgvBooks.AllowUserToAddRows = false;
            this.cdgvBooks.AllowUserToDeleteRows = false;
            this.cdgvBooks.AlternatingRowBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(71)))), ((int)(((byte)(88)))));
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(71)))), ((int)(((byte)(88)))));
            this.cdgvBooks.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.cdgvBooks.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(68)))));
            this.cdgvBooks.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.cdgvBooks.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cdgvBooks.BorderThickness = 2;
            this.cdgvBooks.CellBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(68)))));
            this.cdgvBooks.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.cdgvBooks.CellForeColor = System.Drawing.Color.WhiteSmoke;
            this.cdgvBooks.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(55)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.cdgvBooks.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.cdgvBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cdgvBooks.CornerRadius = 8;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(68)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.cdgvBooks.DefaultCellStyle = dataGridViewCellStyle7;
            this.cdgvBooks.EnableBorder = false;
            this.cdgvBooks.EnableHeadersVisualStyles = false;
            this.cdgvBooks.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(68)))));
            this.cdgvBooks.HeaderBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(55)))));
            this.cdgvBooks.HeaderForeColor = System.Drawing.Color.WhiteSmoke;
            this.cdgvBooks.HeaderGradientColor = System.Drawing.Color.SlateBlue;
            this.cdgvBooks.HoverRowColor = System.Drawing.Color.LightSteelBlue;
            this.cdgvBooks.Location = new System.Drawing.Point(12, 235);
            this.cdgvBooks.Name = "cdgvBooks";
            this.cdgvBooks.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(55)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.cdgvBooks.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.cdgvBooks.SelectedRowColor = System.Drawing.Color.CornflowerBlue;
            this.cdgvBooks.Size = new System.Drawing.Size(716, 312);
            this.cdgvBooks.TabIndex = 0;
            this.cdgvBooks.UseHeaderGradient = false;
            this.cdgvBooks.UseRoundedCorners = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnKeres);
            this.panel1.Controls.Add(this.ctbSearch);
            this.panel1.Controls.Add(this.customButton1);
            this.panel1.Location = new System.Drawing.Point(12, 8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(716, 221);
            this.panel1.TabIndex = 2;
            // 
            // btnKeres
            // 
            this.btnKeres.BackColor = System.Drawing.Color.Black;
            this.btnKeres.BorderColor = System.Drawing.Color.White;
            this.btnKeres.BorderRadius = 40;
            this.btnKeres.BorderSize = 0;
            this.btnKeres.FlatAppearance.BorderSize = 0;
            this.btnKeres.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKeres.ForeColor = System.Drawing.Color.White;
            this.btnKeres.Location = new System.Drawing.Point(284, 135);
            this.btnKeres.Name = "btnKeres";
            this.btnKeres.Size = new System.Drawing.Size(120, 31);
            this.btnKeres.TabIndex = 2;
            this.btnKeres.Text = "Keresés";
            this.btnKeres.UseVisualStyleBackColor = false;
            this.btnKeres.Click += new System.EventHandler(this.btnKeres_Click);
            // 
            // ctbSearch
            // 
            this.ctbSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(71)))), ((int)(((byte)(88)))));
            this.ctbSearch.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.ctbSearch.BorderFocusColor = System.Drawing.Color.HotPink;
            this.ctbSearch.BorderRadius = 15;
            this.ctbSearch.BorderSize = 2;
            this.ctbSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ctbSearch.ForeColor = System.Drawing.Color.DimGray;
            this.ctbSearch.Location = new System.Drawing.Point(4, 135);
            this.ctbSearch.Margin = new System.Windows.Forms.Padding(4);
            this.ctbSearch.Multiline = false;
            this.ctbSearch.Name = "ctbSearch";
            this.ctbSearch.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.ctbSearch.PasswordChar = false;
            this.ctbSearch.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.ctbSearch.PlaceholderText = "Keresés";
            this.ctbSearch.Size = new System.Drawing.Size(250, 31);
            this.ctbSearch.TabIndex = 1;
            this.ctbSearch.Texts = "Keresés";
            this.ctbSearch.UnderlinedStyle = false;
            this.ctbSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ctbSearch_KeyPress);
            // 
            // customButton1
            // 
            this.customButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.customButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(71)))), ((int)(((byte)(88)))));
            this.customButton1.BorderColor = System.Drawing.Color.White;
            this.customButton1.BorderRadius = 40;
            this.customButton1.BorderSize = 0;
            this.customButton1.FlatAppearance.BorderSize = 0;
            this.customButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customButton1.ForeColor = System.Drawing.Color.White;
            this.customButton1.Image = global::Desktop.Properties.Resources.add_line_white;
            this.customButton1.Location = new System.Drawing.Point(662, 9);
            this.customButton1.Name = "customButton1";
            this.customButton1.Size = new System.Drawing.Size(45, 45);
            this.customButton1.TabIndex = 0;
            this.customButton1.UseVisualStyleBackColor = false;
            // 
            // AllBooksPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(68)))));
            this.ClientSize = new System.Drawing.Size(740, 559);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cdgvBooks);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AllBooksPage";
            this.Text = "AllBooksPage";
            this.Load += new System.EventHandler(this.AllBooksPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cdgvBooks)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

		}

        #endregion

        private CustomDataGridView cdgvBooks;
        private System.Windows.Forms.Panel panel1;
        private CustomButton btnKeres;
        private CustomTextbox ctbSearch;
        private CustomButton customButton1;
    }
}