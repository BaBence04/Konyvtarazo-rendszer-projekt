namespace Desktop
{
	partial class PublishersPage
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
			this.tableLayoutPanel_Users = new System.Windows.Forms.TableLayoutPanel();
			this.cdgvPublishers = new Desktop.CustomDataGridView();
			this.panel1 = new System.Windows.Forms.Panel();
			this.btnSearch = new Desktop.CustomButton();
			this.ctbSearch = new Desktop.CustomTextbox();
			this.customButton1 = new Desktop.CustomButton();
			this.tableLayoutPanel_Users.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.cdgvPublishers)).BeginInit();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// tableLayoutPanel_Users
			// 
			this.tableLayoutPanel_Users.ColumnCount = 1;
			this.tableLayoutPanel_Users.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel_Users.Controls.Add(this.cdgvPublishers, 0, 1);
			this.tableLayoutPanel_Users.Controls.Add(this.panel1, 0, 0);
			this.tableLayoutPanel_Users.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel_Users.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel_Users.Margin = new System.Windows.Forms.Padding(0, 0, 0, 49);
			this.tableLayoutPanel_Users.Name = "tableLayoutPanel_Users";
			this.tableLayoutPanel_Users.RowCount = 2;
			this.tableLayoutPanel_Users.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.2737F));
			this.tableLayoutPanel_Users.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 66.7263F));
			this.tableLayoutPanel_Users.Size = new System.Drawing.Size(969, 641);
			this.tableLayoutPanel_Users.TabIndex = 3;
			// 
			// cdgvPublishers
			// 
			this.cdgvPublishers.AllowUserToAddRows = false;
			this.cdgvPublishers.AllowUserToDeleteRows = false;
			this.cdgvPublishers.AlternatingRowBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(71)))), ((int)(((byte)(88)))));
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(71)))), ((int)(((byte)(88)))));
			dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(5);
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.cdgvPublishers.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.cdgvPublishers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.cdgvPublishers.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(68)))));
			this.cdgvPublishers.BorderColor = System.Drawing.Color.MediumSlateBlue;
			this.cdgvPublishers.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.cdgvPublishers.BorderThickness = 2;
			this.cdgvPublishers.CellBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(68)))));
			this.cdgvPublishers.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
			this.cdgvPublishers.CellForeColor = System.Drawing.Color.WhiteSmoke;
			this.cdgvPublishers.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(55)))));
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
			dataGridViewCellStyle2.ForeColor = System.Drawing.Color.WhiteSmoke;
			dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(15);
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.cdgvPublishers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.cdgvPublishers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.cdgvPublishers.CornerRadius = 8;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(68)))));
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			dataGridViewCellStyle3.ForeColor = System.Drawing.Color.WhiteSmoke;
			dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(5);
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.CornflowerBlue;
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.cdgvPublishers.DefaultCellStyle = dataGridViewCellStyle3;
			this.cdgvPublishers.Dock = System.Windows.Forms.DockStyle.Fill;
			this.cdgvPublishers.EnableBorder = false;
			this.cdgvPublishers.EnableHeadersVisualStyles = false;
			this.cdgvPublishers.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(68)))));
			this.cdgvPublishers.HeaderBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(55)))));
			this.cdgvPublishers.HeaderForeColor = System.Drawing.Color.WhiteSmoke;
			this.cdgvPublishers.HeaderGradientColor = System.Drawing.Color.SlateBlue;
			this.cdgvPublishers.HoverRowColor = System.Drawing.Color.LightSteelBlue;
			this.cdgvPublishers.Location = new System.Drawing.Point(0, 213);
			this.cdgvPublishers.Margin = new System.Windows.Forms.Padding(0);
			this.cdgvPublishers.Name = "cdgvPublishers";
			this.cdgvPublishers.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(55)))));
			dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			dataGridViewCellStyle4.ForeColor = System.Drawing.Color.WhiteSmoke;
			dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(5);
			dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.CornflowerBlue;
			dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
			dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.cdgvPublishers.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
			this.cdgvPublishers.RowHeadersWidth = 51;
			dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(5);
			dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.cdgvPublishers.RowsDefaultCellStyle = dataGridViewCellStyle5;
			this.cdgvPublishers.RowTemplate.Height = 40;
			this.cdgvPublishers.SelectedRowColor = System.Drawing.Color.CornflowerBlue;
			this.cdgvPublishers.Size = new System.Drawing.Size(969, 428);
			this.cdgvPublishers.TabIndex = 0;
			this.cdgvPublishers.UseHeaderGradient = false;
			this.cdgvPublishers.UseRoundedCorners = false;
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
			this.panel1.Size = new System.Drawing.Size(961, 205);
			this.panel1.TabIndex = 3;
			// 
			// btnSearch
			// 
			this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnSearch.BackColor = System.Drawing.Color.Black;
			this.btnSearch.BorderColor = System.Drawing.Color.White;
			this.btnSearch.BorderRadius = 40;
			this.btnSearch.BorderSize = 0;
			this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnSearch.FlatAppearance.BorderSize = 0;
			this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSearch.ForeColor = System.Drawing.Color.White;
			this.btnSearch.Location = new System.Drawing.Point(377, 151);
			this.btnSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btnSearch.Name = "btnSearch";
			this.btnSearch.Size = new System.Drawing.Size(160, 38);
			this.btnSearch.TabIndex = 2;
			this.btnSearch.Text = "Keresés";
			this.btnSearch.UseVisualStyleBackColor = false;
			// 
			// ctbSearch
			// 
			this.ctbSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.ctbSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(71)))), ((int)(((byte)(88)))));
			this.ctbSearch.BorderColor = System.Drawing.Color.MediumSlateBlue;
			this.ctbSearch.BorderFocusColor = System.Drawing.Color.HotPink;
			this.ctbSearch.BorderRadius = 15;
			this.ctbSearch.BorderSize = 2;
			this.ctbSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.ctbSearch.ForeColor = System.Drawing.Color.DarkGray;
			this.ctbSearch.Location = new System.Drawing.Point(13, 150);
			this.ctbSearch.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
			this.ctbSearch.Multiline = false;
			this.ctbSearch.Name = "ctbSearch";
			this.ctbSearch.Padding = new System.Windows.Forms.Padding(13, 9, 13, 9);
			this.ctbSearch.PasswordChar = false;
			this.ctbSearch.PlaceholderColor = System.Drawing.Color.DimGray;
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
			this.customButton1.Location = new System.Drawing.Point(889, 11);
			this.customButton1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.customButton1.Name = "customButton1";
			this.customButton1.Size = new System.Drawing.Size(60, 55);
			this.customButton1.TabIndex = 0;
			this.customButton1.UseVisualStyleBackColor = false;
			// 
			// PublishersPage
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(68)))));
			this.ClientSize = new System.Drawing.Size(969, 641);
			this.Controls.Add(this.tableLayoutPanel_Users);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.Name = "PublishersPage";
			this.Text = "PublishersPage";
			this.tableLayoutPanel_Users.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.cdgvPublishers)).EndInit();
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_Users;
		private CustomDataGridView cdgvPublishers;
		private System.Windows.Forms.Panel panel1;
		private CustomButton btnSearch;
		private CustomTextbox ctbSearch;
		private CustomButton customButton1;
	}
}