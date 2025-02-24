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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cdgvBookings = new Desktop.CustomDataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSearch = new Desktop.CustomButton();
            this.ctbSearch = new Desktop.CustomTextbox();
            ((System.ComponentModel.ISupportInitialize)(this.cdgvBookings)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cdgvBookings
            // 
            this.cdgvBookings.AlternatingRowBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(71)))), ((int)(((byte)(88)))));
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(71)))), ((int)(((byte)(88)))));
            this.cdgvBookings.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.cdgvBookings.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(68)))));
            this.cdgvBookings.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.cdgvBookings.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cdgvBookings.BorderThickness = 2;
            this.cdgvBookings.CellBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(68)))));
            this.cdgvBookings.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.cdgvBookings.CellForeColor = System.Drawing.Color.WhiteSmoke;
            this.cdgvBookings.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(55)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.cdgvBookings.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.cdgvBookings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cdgvBookings.CornerRadius = 8;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(68)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.cdgvBookings.DefaultCellStyle = dataGridViewCellStyle11;
            this.cdgvBookings.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.cdgvBookings.EnableBorder = false;
            this.cdgvBookings.EnableHeadersVisualStyles = false;
            this.cdgvBookings.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(68)))));
            this.cdgvBookings.HeaderBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(55)))));
            this.cdgvBookings.HeaderForeColor = System.Drawing.Color.WhiteSmoke;
            this.cdgvBookings.HeaderGradientColor = System.Drawing.Color.SlateBlue;
            this.cdgvBookings.HoverRowColor = System.Drawing.Color.LightSteelBlue;
            this.cdgvBookings.Location = new System.Drawing.Point(0, 123);
            this.cdgvBookings.Name = "cdgvBookings";
            this.cdgvBookings.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(55)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.cdgvBookings.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.cdgvBookings.SelectedRowColor = System.Drawing.Color.CornflowerBlue;
            this.cdgvBookings.Size = new System.Drawing.Size(699, 327);
            this.cdgvBookings.TabIndex = 1;
            this.cdgvBookings.UseHeaderGradient = false;
            this.cdgvBookings.UseRoundedCorners = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(68)))));
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.ctbSearch);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(699, 123);
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
            this.btnSearch.Location = new System.Drawing.Point(284, 79);
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
            this.ctbSearch.Location = new System.Drawing.Point(10, 79);
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
            // BookingsPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cdgvBookings);
            this.Name = "BookingsPage";
            this.Text = "BookingsPage";
            this.Load += new System.EventHandler(this.BookingsPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cdgvBookings)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private CustomDataGridView cdgvBookings;
        private System.Windows.Forms.Panel panel1;
        private CustomButton btnSearch;
        private CustomTextbox ctbSearch;
    }
}