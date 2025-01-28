namespace Desktop
{
    partial class UsersPage
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
			this.panel1 = new System.Windows.Forms.Panel();
			this.btnSearch = new Desktop.CustomButton();
			this.ctbSearch = new Desktop.CustomTextbox();
			this.customButton1 = new Desktop.CustomButton();
			this.tableLayoutPanel_Users = new System.Windows.Forms.TableLayoutPanel();
			this.cdgwUsers = new Desktop.CustomDataGridView();
			this.panel1.SuspendLayout();
			this.tableLayoutPanel_Users.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.cdgwUsers)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.btnSearch);
			this.panel1.Controls.Add(this.ctbSearch);
			this.panel1.Controls.Add(this.customButton1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(4, 4);
			this.panel1.Margin = new System.Windows.Forms.Padding(4);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(979, 220);
			this.panel1.TabIndex = 3;
			// 
			// btnSearch
			// 
			this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnSearch.BackColor = System.Drawing.Color.Black;
			this.btnSearch.BorderColor = System.Drawing.Color.White;
			this.btnSearch.BorderRadius = 40;
			this.btnSearch.BorderSize = 0;
			this.btnSearch.FlatAppearance.BorderSize = 0;
			this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSearch.ForeColor = System.Drawing.Color.White;
			this.btnSearch.Location = new System.Drawing.Point(379, 166);
			this.btnSearch.Margin = new System.Windows.Forms.Padding(4);
			this.btnSearch.Name = "btnSearch";
			this.btnSearch.Size = new System.Drawing.Size(160, 38);
			this.btnSearch.TabIndex = 2;
			this.btnSearch.Text = "Keresés";
			this.btnSearch.UseVisualStyleBackColor = false;
			this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
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
			this.ctbSearch.ForeColor = System.Drawing.Color.DimGray;
			this.ctbSearch.Location = new System.Drawing.Point(13, 166);
			this.ctbSearch.Margin = new System.Windows.Forms.Padding(5);
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
			this.customButton1.Margin = new System.Windows.Forms.Padding(4);
			this.customButton1.Name = "customButton1";
			this.customButton1.Size = new System.Drawing.Size(60, 55);
			this.customButton1.TabIndex = 0;
			this.customButton1.UseVisualStyleBackColor = false;
			// 
			// tableLayoutPanel_Users
			// 
			this.tableLayoutPanel_Users.ColumnCount = 1;
			this.tableLayoutPanel_Users.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel_Users.Controls.Add(this.cdgwUsers, 0, 1);
			this.tableLayoutPanel_Users.Controls.Add(this.panel1, 0, 0);
			this.tableLayoutPanel_Users.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel_Users.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel_Users.Margin = new System.Windows.Forms.Padding(0, 0, 0, 49);
			this.tableLayoutPanel_Users.Name = "tableLayoutPanel_Users";
			this.tableLayoutPanel_Users.RowCount = 2;
			this.tableLayoutPanel_Users.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.2737F));
			this.tableLayoutPanel_Users.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 66.7263F));
			this.tableLayoutPanel_Users.Size = new System.Drawing.Size(987, 688);
			this.tableLayoutPanel_Users.TabIndex = 2;
			this.tableLayoutPanel_Users.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel_Users_Paint);
			// 
			// cdgwUsers
			// 
			this.cdgwUsers.AllowUserToAddRows = false;
			this.cdgwUsers.AllowUserToDeleteRows = false;
			this.cdgwUsers.AlternatingRowBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(71)))), ((int)(((byte)(88)))));
			dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(71)))), ((int)(((byte)(88)))));
			dataGridViewCellStyle11.Padding = new System.Windows.Forms.Padding(5);
			dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.cdgwUsers.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle11;
			this.cdgwUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.cdgwUsers.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(68)))));
			this.cdgwUsers.BorderColor = System.Drawing.Color.MediumSlateBlue;
			this.cdgwUsers.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.cdgwUsers.BorderThickness = 2;
			this.cdgwUsers.CellBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(68)))));
			this.cdgwUsers.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
			this.cdgwUsers.CellForeColor = System.Drawing.Color.WhiteSmoke;
			this.cdgwUsers.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(55)))));
			dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
			dataGridViewCellStyle12.ForeColor = System.Drawing.Color.WhiteSmoke;
			dataGridViewCellStyle12.Padding = new System.Windows.Forms.Padding(15);
			dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.cdgwUsers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle12;
			this.cdgwUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.cdgwUsers.CornerRadius = 8;
			dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(68)))));
			dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			dataGridViewCellStyle13.ForeColor = System.Drawing.Color.WhiteSmoke;
			dataGridViewCellStyle13.Padding = new System.Windows.Forms.Padding(5);
			dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.CornflowerBlue;
			dataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.cdgwUsers.DefaultCellStyle = dataGridViewCellStyle13;
			this.cdgwUsers.Dock = System.Windows.Forms.DockStyle.Fill;
			this.cdgwUsers.EnableBorder = false;
			this.cdgwUsers.EnableHeadersVisualStyles = false;
			this.cdgwUsers.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(68)))));
			this.cdgwUsers.HeaderBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(55)))));
			this.cdgwUsers.HeaderForeColor = System.Drawing.Color.WhiteSmoke;
			this.cdgwUsers.HeaderGradientColor = System.Drawing.Color.SlateBlue;
			this.cdgwUsers.HoverRowColor = System.Drawing.Color.LightSteelBlue;
			this.cdgwUsers.Location = new System.Drawing.Point(0, 228);
			this.cdgwUsers.Margin = new System.Windows.Forms.Padding(0);
			this.cdgwUsers.Name = "cdgwUsers";
			this.cdgwUsers.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(55)))));
			dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			dataGridViewCellStyle14.ForeColor = System.Drawing.Color.WhiteSmoke;
			dataGridViewCellStyle14.Padding = new System.Windows.Forms.Padding(5);
			dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.CornflowerBlue;
			dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
			dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.cdgwUsers.RowHeadersDefaultCellStyle = dataGridViewCellStyle14;
			this.cdgwUsers.RowHeadersWidth = 51;
			dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle15.Padding = new System.Windows.Forms.Padding(5);
			dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.cdgwUsers.RowsDefaultCellStyle = dataGridViewCellStyle15;
			this.cdgwUsers.RowTemplate.Height = 40;
			this.cdgwUsers.SelectedRowColor = System.Drawing.Color.CornflowerBlue;
			this.cdgwUsers.Size = new System.Drawing.Size(987, 460);
			this.cdgwUsers.TabIndex = 0;
			this.cdgwUsers.UseHeaderGradient = false;
			this.cdgwUsers.UseRoundedCorners = false;
			this.cdgwUsers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.customDataGridView1_CellContentClick);
			// 
			// UsersPage
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(68)))));
			this.ClientSize = new System.Drawing.Size(987, 688);
			this.Controls.Add(this.tableLayoutPanel_Users);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "UsersPage";
			this.Text = "Users";
			this.Load += new System.EventHandler(this.UsersPage_Load);
			this.panel1.ResumeLayout(false);
			this.tableLayoutPanel_Users.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.cdgwUsers)).EndInit();
			this.ResumeLayout(false);


        }

        #endregion
        private CustomDataGridView cdgwUsers;
		private System.Windows.Forms.Panel panel1;
		private CustomButton btnSearch;
		private CustomTextbox ctbSearch;
		private CustomButton customButton1;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_Users;
	}
}