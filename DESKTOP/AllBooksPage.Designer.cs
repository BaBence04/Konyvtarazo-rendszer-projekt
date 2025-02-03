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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
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
			this.tableLayoutPanel_Books.Margin = new System.Windows.Forms.Padding(0, 0, 0, 49);
			this.tableLayoutPanel_Books.Name = "tableLayoutPanel_Books";
			this.tableLayoutPanel_Books.RowCount = 2;
			this.tableLayoutPanel_Books.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.27F));
			this.tableLayoutPanel_Books.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 66.73F));
			this.tableLayoutPanel_Books.Size = new System.Drawing.Size(987, 688);
			this.tableLayoutPanel_Books.TabIndex = 2;
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.btnSearch);
			this.panel1.Controls.Add(this.ctbSearch);
			this.panel1.Controls.Add(this.customButton1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(4, 4);
			this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(979, 220);
			this.panel1.TabIndex = 3;
			// 
			// btnSearch
			// 
			this.btnSearch.BackColor = System.Drawing.Color.Black;
			this.btnSearch.BorderColor = System.Drawing.Color.White;
			this.btnSearch.BorderRadius = 40;
			this.btnSearch.BorderSize = 0;
			this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnSearch.FlatAppearance.BorderSize = 0;
			this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSearch.ForeColor = System.Drawing.Color.White;
			this.btnSearch.Location = new System.Drawing.Point(379, 166);
			this.btnSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btnSearch.Name = "btnSearch";
			this.btnSearch.Size = new System.Drawing.Size(160, 38);
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
			this.ctbSearch.Location = new System.Drawing.Point(13, 166);
			this.ctbSearch.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
			this.ctbSearch.Multiline = false;
			this.ctbSearch.Name = "ctbSearch";
			this.ctbSearch.Padding = new System.Windows.Forms.Padding(13, 9, 13, 9);
			this.ctbSearch.PasswordChar = false;
			this.ctbSearch.PlaceholderColor = System.Drawing.Color.DarkGray;
			this.ctbSearch.PlaceholderText = "Keresés";
			this.ctbSearch.Size = new System.Drawing.Size(333, 39);
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
			this.customButton1.Location = new System.Drawing.Point(907, 11);
			this.customButton1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.customButton1.Name = "customButton1";
			this.customButton1.Size = new System.Drawing.Size(60, 55);
			this.customButton1.TabIndex = 0;
			this.customButton1.UseVisualStyleBackColor = false;
			// 
			// cdgvBooks
			// 
			this.cdgvBooks.AllowUserToAddRows = false;
			this.cdgvBooks.AllowUserToDeleteRows = false;
			this.cdgvBooks.AlternatingRowBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(71)))), ((int)(((byte)(88)))));
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(71)))), ((int)(((byte)(88)))));
			dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(5);
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.cdgvBooks.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.cdgvBooks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.cdgvBooks.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(68)))));
			this.cdgvBooks.BorderColor = System.Drawing.Color.MediumSlateBlue;
			this.cdgvBooks.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.cdgvBooks.BorderThickness = 2;
			this.cdgvBooks.CellBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(68)))));
			this.cdgvBooks.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
			this.cdgvBooks.CellForeColor = System.Drawing.Color.WhiteSmoke;
			this.cdgvBooks.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(55)))));
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
			dataGridViewCellStyle2.ForeColor = System.Drawing.Color.WhiteSmoke;
			dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(15);
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.cdgvBooks.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.cdgvBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.cdgvBooks.CornerRadius = 8;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(68)))));
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			dataGridViewCellStyle3.ForeColor = System.Drawing.Color.WhiteSmoke;
			dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(5);
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.CornflowerBlue;
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.cdgvBooks.DefaultCellStyle = dataGridViewCellStyle3;
			this.cdgvBooks.Dock = System.Windows.Forms.DockStyle.Fill;
			this.cdgvBooks.EnableBorder = false;
			this.cdgvBooks.EnableHeadersVisualStyles = false;
			this.cdgvBooks.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(68)))));
			this.cdgvBooks.HeaderBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(55)))));
			this.cdgvBooks.HeaderForeColor = System.Drawing.Color.WhiteSmoke;
			this.cdgvBooks.HeaderGradientColor = System.Drawing.Color.SlateBlue;
			this.cdgvBooks.HoverRowColor = System.Drawing.Color.LightSteelBlue;
			this.cdgvBooks.Location = new System.Drawing.Point(0, 228);
			this.cdgvBooks.Margin = new System.Windows.Forms.Padding(0);
			this.cdgvBooks.Name = "cdgvBooks";
			this.cdgvBooks.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(55)))));
			dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			dataGridViewCellStyle4.ForeColor = System.Drawing.Color.WhiteSmoke;
			dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(5);
			dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.CornflowerBlue;
			dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
			dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.cdgvBooks.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
			this.cdgvBooks.RowHeadersWidth = 51;
			dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(5);
			dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.cdgvBooks.RowsDefaultCellStyle = dataGridViewCellStyle5;
			this.cdgvBooks.RowTemplate.Height = 40;
			this.cdgvBooks.SelectedRowColor = System.Drawing.Color.CornflowerBlue;
			this.cdgvBooks.Size = new System.Drawing.Size(987, 460);
			this.cdgvBooks.TabIndex = 0;
			this.cdgvBooks.UseHeaderGradient = false;
			this.cdgvBooks.UseRoundedCorners = false;
			// 
			// AllBooksPage
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(68)))));
			this.ClientSize = new System.Drawing.Size(987, 688);
			this.Controls.Add(this.tableLayoutPanel_Books);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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