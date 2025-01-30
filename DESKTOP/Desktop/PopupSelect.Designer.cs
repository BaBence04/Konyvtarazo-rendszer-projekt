namespace Desktop
{
    partial class PopupSelect
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
            this.ctbSearch = new Desktop.CustomTextbox();
            this.cdgwSelect = new Desktop.CustomDataGridView();
            this.cbtnSearch = new Desktop.CustomButton();
            ((System.ComponentModel.ISupportInitialize)(this.cdgwSelect)).BeginInit();
            this.SuspendLayout();
            // 
            // ctbSearch
            // 
            this.ctbSearch.BackColor = System.Drawing.SystemColors.Window;
            this.ctbSearch.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.ctbSearch.BorderFocusColor = System.Drawing.Color.HotPink;
            this.ctbSearch.BorderRadius = 0;
            this.ctbSearch.BorderSize = 2;
            this.ctbSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ctbSearch.ForeColor = System.Drawing.Color.DimGray;
            this.ctbSearch.Location = new System.Drawing.Point(13, 45);
            this.ctbSearch.Margin = new System.Windows.Forms.Padding(4);
            this.ctbSearch.Multiline = false;
            this.ctbSearch.Name = "ctbSearch";
            this.ctbSearch.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.ctbSearch.PasswordChar = false;
            this.ctbSearch.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.ctbSearch.PlaceholderText = "";
            this.ctbSearch.Size = new System.Drawing.Size(190, 31);
            this.ctbSearch.TabIndex = 2;
            this.ctbSearch.Texts = "";
            this.ctbSearch.UnderlinedStyle = false;
            // 
            // cdgwSelect
            // 
            this.cdgwSelect.AllowUserToAddRows = false;
            this.cdgwSelect.AllowUserToDeleteRows = false;
            this.cdgwSelect.AllowUserToResizeColumns = false;
            this.cdgwSelect.AllowUserToResizeRows = false;
            this.cdgwSelect.AlternatingRowBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(71)))), ((int)(((byte)(88)))));
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(71)))), ((int)(((byte)(88)))));
            this.cdgwSelect.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.cdgwSelect.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(68)))));
            this.cdgwSelect.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.cdgwSelect.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cdgwSelect.BorderThickness = 2;
            this.cdgwSelect.CellBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(68)))));
            this.cdgwSelect.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.cdgwSelect.CellForeColor = System.Drawing.Color.WhiteSmoke;
            this.cdgwSelect.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(55)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.cdgwSelect.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.cdgwSelect.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cdgwSelect.CornerRadius = 8;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(68)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.cdgwSelect.DefaultCellStyle = dataGridViewCellStyle3;
            this.cdgwSelect.EnableBorder = false;
            this.cdgwSelect.EnableHeadersVisualStyles = false;
            this.cdgwSelect.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(68)))));
            this.cdgwSelect.HeaderBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(55)))));
            this.cdgwSelect.HeaderForeColor = System.Drawing.Color.WhiteSmoke;
            this.cdgwSelect.HeaderGradientColor = System.Drawing.Color.SlateBlue;
            this.cdgwSelect.HoverRowColor = System.Drawing.Color.LightSteelBlue;
            this.cdgwSelect.Location = new System.Drawing.Point(13, 102);
            this.cdgwSelect.Name = "cdgwSelect";
            this.cdgwSelect.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(55)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.cdgwSelect.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.cdgwSelect.SelectedRowColor = System.Drawing.Color.CornflowerBlue;
            this.cdgwSelect.Size = new System.Drawing.Size(474, 232);
            this.cdgwSelect.TabIndex = 1;
            this.cdgwSelect.UseHeaderGradient = false;
            this.cdgwSelect.UseRoundedCorners = false;
            // 
            // cbtnSearch
            // 
            this.cbtnSearch.BackColor = System.Drawing.Color.Black;
            this.cbtnSearch.BorderColor = System.Drawing.Color.White;
            this.cbtnSearch.BorderRadius = 40;
            this.cbtnSearch.BorderSize = 0;
            this.cbtnSearch.FlatAppearance.BorderSize = 0;
            this.cbtnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbtnSearch.ForeColor = System.Drawing.Color.White;
            this.cbtnSearch.Location = new System.Drawing.Point(256, 45);
            this.cbtnSearch.Name = "cbtnSearch";
            this.cbtnSearch.Size = new System.Drawing.Size(122, 31);
            this.cbtnSearch.TabIndex = 0;
            this.cbtnSearch.Text = "Keresés";
            this.cbtnSearch.UseVisualStyleBackColor = false;
            this.cbtnSearch.Click += new System.EventHandler(this.cbtnSearch_Click);
            // 
            // PopupSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 346);
            this.Controls.Add(this.ctbSearch);
            this.Controls.Add(this.cdgwSelect);
            this.Controls.Add(this.cbtnSearch);
            this.Name = "PopupSelect";
            this.Text = "PopupSelect";
            this.Load += new System.EventHandler(this.PopupSelect_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cdgwSelect)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CustomButton cbtnSearch;
        private CustomDataGridView cdgwSelect;
        private CustomTextbox ctbSearch;
    }
}