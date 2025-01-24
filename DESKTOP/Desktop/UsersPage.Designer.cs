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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPanel_Users = new System.Windows.Forms.TableLayoutPanel();
            this.cdgwUsers = new Desktop.CustomDataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnKeres = new Desktop.CustomButton();
            this.ctbSearch = new Desktop.CustomTextbox();
            this.customButton1 = new Desktop.CustomButton();
            this.tableLayoutPanel_Users.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cdgwUsers)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel_Users
            // 
            this.tableLayoutPanel_Users.ColumnCount = 1;
            this.tableLayoutPanel_Users.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_Users.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel_Users.Controls.Add(this.cdgwUsers, 0, 1);
            this.tableLayoutPanel_Users.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel_Users.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_Users.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel_Users.Margin = new System.Windows.Forms.Padding(0, 0, 0, 40);
            this.tableLayoutPanel_Users.Name = "tableLayoutPanel_Users";
            this.tableLayoutPanel_Users.RowCount = 2;
            this.tableLayoutPanel_Users.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.2737F));
            this.tableLayoutPanel_Users.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 66.7263F));
            this.tableLayoutPanel_Users.Size = new System.Drawing.Size(740, 559);
            this.tableLayoutPanel_Users.TabIndex = 2;
            this.tableLayoutPanel_Users.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel_Users_Paint);
            // 
            // cdgwUsers
            // 
            this.cdgwUsers.AllowUserToAddRows = false;
            this.cdgwUsers.AllowUserToDeleteRows = false;
            this.cdgwUsers.AlternatingRowBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(71)))), ((int)(((byte)(88)))));
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(71)))), ((int)(((byte)(88)))));
            this.cdgwUsers.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.cdgwUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.cdgwUsers.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(68)))));
            this.cdgwUsers.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.cdgwUsers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cdgwUsers.BorderThickness = 2;
            this.cdgwUsers.CellBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(68)))));
            this.cdgwUsers.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.cdgwUsers.CellForeColor = System.Drawing.Color.WhiteSmoke;
            this.cdgwUsers.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(55)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle10.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.cdgwUsers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.cdgwUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cdgwUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.cdgwUsers.CornerRadius = 8;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(68)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.cdgwUsers.DefaultCellStyle = dataGridViewCellStyle11;
            this.cdgwUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cdgwUsers.EnableBorder = false;
            this.cdgwUsers.EnableHeadersVisualStyles = false;
            this.cdgwUsers.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(68)))));
            this.cdgwUsers.HeaderBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(55)))));
            this.cdgwUsers.HeaderForeColor = System.Drawing.Color.WhiteSmoke;
            this.cdgwUsers.HeaderGradientColor = System.Drawing.Color.SlateBlue;
            this.cdgwUsers.HoverRowColor = System.Drawing.Color.LightSteelBlue;
            this.cdgwUsers.Location = new System.Drawing.Point(0, 185);
            this.cdgwUsers.Margin = new System.Windows.Forms.Padding(0);
            this.cdgwUsers.Name = "cdgwUsers";
            this.cdgwUsers.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(55)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.cdgwUsers.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.cdgwUsers.SelectedRowColor = System.Drawing.Color.CornflowerBlue;
            this.cdgwUsers.Size = new System.Drawing.Size(740, 374);
            this.cdgwUsers.TabIndex = 0;
            this.cdgwUsers.UseHeaderGradient = false;
            this.cdgwUsers.UseRoundedCorners = false;
            this.cdgwUsers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.customDataGridView1_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Column2";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Column3";
            this.Column3.Name = "Column3";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnKeres);
            this.panel1.Controls.Add(this.ctbSearch);
            this.panel1.Controls.Add(this.customButton1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(734, 179);
            this.panel1.TabIndex = 1;
            // 
            // btnKeres
            // 
            this.btnKeres.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
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
            this.ctbSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
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
            this.customButton1.Location = new System.Drawing.Point(680, 9);
            this.customButton1.Name = "customButton1";
            this.customButton1.Size = new System.Drawing.Size(45, 45);
            this.customButton1.TabIndex = 0;
            this.customButton1.UseVisualStyleBackColor = false;
            // 
            // UsersPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(68)))));
            this.ClientSize = new System.Drawing.Size(740, 559);
            this.Controls.Add(this.tableLayoutPanel_Users);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UsersPage";
            this.Text = "Users";
            this.Load += new System.EventHandler(this.UsersPage_Load);
            this.tableLayoutPanel_Users.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cdgwUsers)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_Users;
        private CustomDataGridView cdgwUsers;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Panel panel1;
        private CustomTextbox ctbSearch;
        private CustomButton customButton1;
        private CustomButton btnKeres;
    }
}