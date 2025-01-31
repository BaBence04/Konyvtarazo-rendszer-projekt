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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPanel_Books = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSearch = new Desktop.CustomButton();
            this.ctbSearch = new Desktop.CustomTextbox();
            this.customButton1 = new Desktop.CustomButton();
            this.cdgvBooks = new Desktop.CustomDataGridView();
            this.tableLayoutPanel_Books.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cdgvBooks)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel_Books
            // 
            this.tableLayoutPanel_Books.ColumnCount = 1;
            this.tableLayoutPanel_Books.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_Books.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel_Books.Controls.Add(this.cdgvBooks, 0, 1);
            this.tableLayoutPanel_Books.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_Books.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel_Books.Margin = new System.Windows.Forms.Padding(0, 0, 0, 40);
            this.tableLayoutPanel_Books.Name = "tableLayoutPanel_Books";
            this.tableLayoutPanel_Books.RowCount = 2;
            this.tableLayoutPanel_Books.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.27F));
            this.tableLayoutPanel_Books.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 66.73F));
            this.tableLayoutPanel_Books.Size = new System.Drawing.Size(740, 559);
            this.tableLayoutPanel_Books.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.ctbSearch);
            this.panel1.Controls.Add(this.customButton1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(734, 179);
            this.panel1.TabIndex = 3;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Black;
            this.btnSearch.BorderColor = System.Drawing.Color.White;
            this.btnSearch.BorderRadius = 40;
            this.btnSearch.BorderSize = 0;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(284, 135);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(120, 31);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Keresés";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
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
            this.ctbSearch.Location = new System.Drawing.Point(10, 135);
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
            this.customButton1.Location = new System.Drawing.Point(680, 9);
            this.customButton1.Name = "customButton1";
            this.customButton1.Size = new System.Drawing.Size(45, 45);
            this.customButton1.TabIndex = 0;
            this.customButton1.UseVisualStyleBackColor = false;
            // 
            // cdgvBooks
            // 
            this.cdgvBooks.AllowUserToAddRows = false;
            this.cdgvBooks.AllowUserToDeleteRows = false;
            this.cdgvBooks.AlternatingRowBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(71)))), ((int)(((byte)(88)))));
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(71)))), ((int)(((byte)(88)))));
            dataGridViewCellStyle6.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.cdgvBooks.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.cdgvBooks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.cdgvBooks.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(68)))));
            this.cdgvBooks.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.cdgvBooks.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cdgvBooks.BorderThickness = 2;
            this.cdgvBooks.CellBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(68)))));
            this.cdgvBooks.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.cdgvBooks.CellForeColor = System.Drawing.Color.WhiteSmoke;
            this.cdgvBooks.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(55)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle7.Padding = new System.Windows.Forms.Padding(15);
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.cdgvBooks.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.cdgvBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cdgvBooks.CornerRadius = 8;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(68)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle8.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.cdgvBooks.DefaultCellStyle = dataGridViewCellStyle8;
            this.cdgvBooks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cdgvBooks.EnableBorder = false;
            this.cdgvBooks.EnableHeadersVisualStyles = false;
            this.cdgvBooks.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(68)))));
            this.cdgvBooks.HeaderBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(55)))));
            this.cdgvBooks.HeaderForeColor = System.Drawing.Color.WhiteSmoke;
            this.cdgvBooks.HeaderGradientColor = System.Drawing.Color.SlateBlue;
            this.cdgvBooks.HoverRowColor = System.Drawing.Color.LightSteelBlue;
            this.cdgvBooks.Location = new System.Drawing.Point(0, 185);
            this.cdgvBooks.Margin = new System.Windows.Forms.Padding(0);
            this.cdgvBooks.Name = "cdgvBooks";
            this.cdgvBooks.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(55)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle9.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.cdgvBooks.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.cdgvBooks.RowHeadersWidth = 51;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.cdgvBooks.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.cdgvBooks.RowTemplate.Height = 40;
            this.cdgvBooks.SelectedRowColor = System.Drawing.Color.CornflowerBlue;
            this.cdgvBooks.Size = new System.Drawing.Size(740, 374);
            this.cdgvBooks.TabIndex = 0;
            this.cdgvBooks.UseHeaderGradient = false;
            this.cdgvBooks.UseRoundedCorners = false;
            // 
            // AllBooksPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(68)))));
            this.ClientSize = new System.Drawing.Size(740, 559);
            this.Controls.Add(this.tableLayoutPanel_Books);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "AllBooksPage";
            this.Text = "AllBooksPage";
            this.Load += new System.EventHandler(this.AllBooksPage_Load);
            this.VisibleChanged += new System.EventHandler(this.AllBooksPage_VisibleChanged);
            this.tableLayoutPanel_Books.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cdgvBooks)).EndInit();
            this.ResumeLayout(false);

		}

        #endregion

        private CustomDataGridView cdgvBooks;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_Books;
		private System.Windows.Forms.Panel panel1;
		private CustomButton btnSearch;
		private CustomTextbox ctbSearch;
		private CustomButton customButton1;
	}
}