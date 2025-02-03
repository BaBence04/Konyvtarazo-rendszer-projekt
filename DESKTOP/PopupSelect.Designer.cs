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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
			this.ctbSearch = new Desktop.CustomTextbox();
			this.cdgwSelect = new Desktop.CustomDataGridView();
			this.cbtnSearch = new Desktop.CustomButton();
			((System.ComponentModel.ISupportInitialize)(this.cdgwSelect)).BeginInit();
			this.SuspendLayout();
			// 
			// ctbSearch
			// 
			this.ctbSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(68)))));
			this.ctbSearch.BorderColor = System.Drawing.Color.MediumSlateBlue;
			this.ctbSearch.BorderFocusColor = System.Drawing.Color.HotPink;
			this.ctbSearch.BorderRadius = 14;
			this.ctbSearch.BorderSize = 2;
			this.ctbSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.ctbSearch.ForeColor = System.Drawing.Color.DimGray;
			this.ctbSearch.Location = new System.Drawing.Point(17, 55);
			this.ctbSearch.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
			this.ctbSearch.Multiline = false;
			this.ctbSearch.Name = "ctbSearch";
			this.ctbSearch.Padding = new System.Windows.Forms.Padding(13, 9, 13, 9);
			this.ctbSearch.PasswordChar = false;
			this.ctbSearch.PlaceholderColor = System.Drawing.Color.DarkGray;
			this.ctbSearch.PlaceholderText = "";
			this.ctbSearch.Size = new System.Drawing.Size(253, 39);
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
			dataGridViewCellStyle17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(71)))), ((int)(((byte)(88)))));
			this.cdgwSelect.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle17;
			this.cdgwSelect.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(68)))));
			this.cdgwSelect.BorderColor = System.Drawing.Color.MediumSlateBlue;
			this.cdgwSelect.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.cdgwSelect.BorderThickness = 2;
			this.cdgwSelect.CellBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(68)))));
			this.cdgwSelect.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
			this.cdgwSelect.CellForeColor = System.Drawing.Color.WhiteSmoke;
			this.cdgwSelect.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(55)))));
			dataGridViewCellStyle18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
			dataGridViewCellStyle18.ForeColor = System.Drawing.Color.WhiteSmoke;
			dataGridViewCellStyle18.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.cdgwSelect.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle18;
			this.cdgwSelect.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.cdgwSelect.CornerRadius = 8;
			dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(68)))));
			dataGridViewCellStyle19.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			dataGridViewCellStyle19.ForeColor = System.Drawing.Color.WhiteSmoke;
			dataGridViewCellStyle19.SelectionBackColor = System.Drawing.Color.CornflowerBlue;
			dataGridViewCellStyle19.SelectionForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.cdgwSelect.DefaultCellStyle = dataGridViewCellStyle19;
			this.cdgwSelect.EnableBorder = false;
			this.cdgwSelect.EnableHeadersVisualStyles = false;
			this.cdgwSelect.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(68)))));
			this.cdgwSelect.HeaderBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(55)))));
			this.cdgwSelect.HeaderForeColor = System.Drawing.Color.WhiteSmoke;
			this.cdgwSelect.HeaderGradientColor = System.Drawing.Color.SlateBlue;
			this.cdgwSelect.HoverRowColor = System.Drawing.Color.LightSteelBlue;
			this.cdgwSelect.Location = new System.Drawing.Point(17, 126);
			this.cdgwSelect.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.cdgwSelect.Name = "cdgwSelect";
			this.cdgwSelect.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(55)))));
			dataGridViewCellStyle20.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			dataGridViewCellStyle20.ForeColor = System.Drawing.Color.WhiteSmoke;
			dataGridViewCellStyle20.SelectionBackColor = System.Drawing.Color.CornflowerBlue;
			dataGridViewCellStyle20.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
			dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.cdgwSelect.RowHeadersDefaultCellStyle = dataGridViewCellStyle20;
			this.cdgwSelect.RowHeadersWidth = 51;
			this.cdgwSelect.SelectedRowColor = System.Drawing.Color.CornflowerBlue;
			this.cdgwSelect.Size = new System.Drawing.Size(632, 286);
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
			this.cbtnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
			this.cbtnSearch.FlatAppearance.BorderSize = 0;
			this.cbtnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.cbtnSearch.ForeColor = System.Drawing.Color.White;
			this.cbtnSearch.Location = new System.Drawing.Point(341, 55);
			this.cbtnSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.cbtnSearch.Name = "cbtnSearch";
			this.cbtnSearch.Size = new System.Drawing.Size(163, 38);
			this.cbtnSearch.TabIndex = 0;
			this.cbtnSearch.Text = "Keresés";
			this.cbtnSearch.UseVisualStyleBackColor = false;
			this.cbtnSearch.Click += new System.EventHandler(this.cbtnSearch_Click);
			// 
			// PopupSelect
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(68)))));
			this.ClientSize = new System.Drawing.Size(665, 426);
			this.Controls.Add(this.ctbSearch);
			this.Controls.Add(this.cdgwSelect);
			this.Controls.Add(this.cbtnSearch);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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