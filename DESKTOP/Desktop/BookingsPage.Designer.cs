namespace Desktop
{
    partial class BookingsPage
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSearch = new Desktop.CustomButton();
            this.ctbSearch = new Desktop.CustomTextbox();
            this.cdgvBookings = new Desktop.CustomDataGridView();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cdgvBookings)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(68)))));
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.ctbSearch);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(693, 143);
            this.panel1.TabIndex = 5;
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
            this.btnSearch.Location = new System.Drawing.Point(284, 99);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(120, 31);
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
            this.ctbSearch.ForeColor = System.Drawing.Color.DarkGray;
            this.ctbSearch.IsReadOnly = false;
            this.ctbSearch.Location = new System.Drawing.Point(10, 99);
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
            // cdgvBookings
            // 
            this.cdgvBookings.AllowUserToAddRows = false;
            this.cdgvBookings.AllowUserToDeleteRows = false;
            this.cdgvBookings.AlternatingRowBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(71)))), ((int)(((byte)(88)))));
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(71)))), ((int)(((byte)(88)))));
            this.cdgvBookings.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.cdgvBookings.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(68)))));
            this.cdgvBookings.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.cdgvBookings.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cdgvBookings.BorderThickness = 2;
            this.cdgvBookings.CellBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(68)))));
            this.cdgvBookings.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.cdgvBookings.CellForeColor = System.Drawing.Color.WhiteSmoke;
            this.cdgvBookings.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(55)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.cdgvBookings.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.cdgvBookings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cdgvBookings.CornerRadius = 8;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(68)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.cdgvBookings.DefaultCellStyle = dataGridViewCellStyle3;
            this.cdgvBookings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cdgvBookings.EnableBorder = false;
            this.cdgvBookings.EnableHeadersVisualStyles = false;
            this.cdgvBookings.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(68)))));
            this.cdgvBookings.HeaderBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(55)))));
            this.cdgvBookings.HeaderForeColor = System.Drawing.Color.WhiteSmoke;
            this.cdgvBookings.HeaderGradientColor = System.Drawing.Color.SlateBlue;
            this.cdgvBookings.HoverRowColor = System.Drawing.Color.LightSteelBlue;
            this.cdgvBookings.Location = new System.Drawing.Point(3, 152);
            this.cdgvBookings.Name = "cdgvBookings";
            this.cdgvBookings.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(55)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.cdgvBookings.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.cdgvBookings.SelectedRowColor = System.Drawing.Color.CornflowerBlue;
            this.cdgvBookings.Size = new System.Drawing.Size(693, 295);
            this.cdgvBookings.TabIndex = 1;
            this.cdgvBookings.UseHeaderGradient = false;
            this.cdgvBookings.UseRoundedCorners = false;
            this.cdgvBookings.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.cdgvBookings_CellClick);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(68)))));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.cdgvBookings, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.27F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 66.73F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(699, 450);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // BookingsPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "BookingsPage";
            this.Text = "BookingsPage";
            this.Load += new System.EventHandler(this.BookingsPage_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cdgvBookings)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private CustomDataGridView cdgvBookings;
        private System.Windows.Forms.Panel panel1;
        private CustomButton btnSearch;
        private CustomTextbox ctbSearch;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}