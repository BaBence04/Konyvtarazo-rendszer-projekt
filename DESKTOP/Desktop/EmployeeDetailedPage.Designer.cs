namespace Desktop
{
    partial class EmployeeDetailedPage
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.lbName = new System.Windows.Forms.Label();
			this.lbUname = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.pEmpolyees = new System.Windows.Forms.Panel();
			this.panel1 = new System.Windows.Forms.Panel();
			this.cdgvEmployees = new Desktop.CustomDataGridView();
			this.cbtnSysSetting = new Desktop.CustomButton();
			this.lblCdgwTitle = new System.Windows.Forms.Label();
			this.cbtnEmployees = new Desktop.CustomButton();
			this.cbtnLogout = new Desktop.CustomButton();
			this.cbtnDeleteEmpl = new Desktop.CustomButton();
			this.ctbNewPassAgain = new Desktop.CustomTextbox();
			this.ctbNewPass = new Desktop.CustomTextbox();
			this.ctbOldPass = new Desktop.CustomTextbox();
			this.cbtnChangePass = new Desktop.CustomButton();
			this.pEmpolyees.SuspendLayout();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.cdgvEmployees)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(40, 34);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(32, 16);
			this.label1.TabIndex = 0;
			this.label1.Text = "Név";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(40, 110);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(102, 16);
			this.label2.TabIndex = 1;
			this.label2.Text = "Felhasználónév";
			// 
			// lbName
			// 
			this.lbName.AutoSize = true;
			this.lbName.Location = new System.Drawing.Point(71, 66);
			this.lbName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lbName.Name = "lbName";
			this.lbName.Size = new System.Drawing.Size(37, 16);
			this.lbName.TabIndex = 2;
			this.lbName.Text = "label";
			// 
			// lbUname
			// 
			this.lbUname.AutoSize = true;
			this.lbUname.Location = new System.Drawing.Point(71, 144);
			this.lbUname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lbUname.Name = "lbUname";
			this.lbUname.Size = new System.Drawing.Size(37, 16);
			this.lbUname.TabIndex = 3;
			this.lbUname.Text = "label";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(40, 198);
			this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(148, 16);
			this.label5.TabIndex = 6;
			this.label5.Text = "Jelszó megváltoztatása";
			// 
			// pEmpolyees
			// 
			this.pEmpolyees.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.pEmpolyees.Controls.Add(this.panel1);
			this.pEmpolyees.Controls.Add(this.cbtnSysSetting);
			this.pEmpolyees.Controls.Add(this.lblCdgwTitle);
			this.pEmpolyees.Controls.Add(this.cbtnEmployees);
			this.pEmpolyees.Location = new System.Drawing.Point(289, 144);
			this.pEmpolyees.Margin = new System.Windows.Forms.Padding(4);
			this.pEmpolyees.Name = "pEmpolyees";
			this.pEmpolyees.Size = new System.Drawing.Size(681, 439);
			this.pEmpolyees.TabIndex = 14;
			this.pEmpolyees.Visible = false;
			// 
			// panel1
			// 
			this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panel1.Controls.Add(this.cdgvEmployees);
			this.panel1.Location = new System.Drawing.Point(0, 108);
			this.panel1.Margin = new System.Windows.Forms.Padding(4);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(681, 331);
			this.panel1.TabIndex = 17;
			// 
			// cdgvEmployees
			// 
			this.cdgvEmployees.AllowUserToAddRows = false;
			this.cdgvEmployees.AllowUserToDeleteRows = false;
			this.cdgvEmployees.AlternatingRowBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(71)))), ((int)(((byte)(88)))));
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(71)))), ((int)(((byte)(88)))));
			this.cdgvEmployees.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.cdgvEmployees.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.cdgvEmployees.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.cdgvEmployees.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(68)))));
			this.cdgvEmployees.BorderColor = System.Drawing.Color.MediumSlateBlue;
			this.cdgvEmployees.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.cdgvEmployees.BorderThickness = 2;
			this.cdgvEmployees.CellBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(68)))));
			this.cdgvEmployees.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
			this.cdgvEmployees.CellForeColor = System.Drawing.Color.WhiteSmoke;
			this.cdgvEmployees.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(55)))));
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
			dataGridViewCellStyle2.ForeColor = System.Drawing.Color.WhiteSmoke;
			dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(5);
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.cdgvEmployees.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.cdgvEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.cdgvEmployees.CornerRadius = 8;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(68)))));
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			dataGridViewCellStyle3.ForeColor = System.Drawing.Color.WhiteSmoke;
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.CornflowerBlue;
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.cdgvEmployees.DefaultCellStyle = dataGridViewCellStyle3;
			this.cdgvEmployees.Dock = System.Windows.Forms.DockStyle.Fill;
			this.cdgvEmployees.EnableBorder = false;
			this.cdgvEmployees.EnableHeadersVisualStyles = false;
			this.cdgvEmployees.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(68)))));
			this.cdgvEmployees.HeaderBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(55)))));
			this.cdgvEmployees.HeaderForeColor = System.Drawing.Color.WhiteSmoke;
			this.cdgvEmployees.HeaderGradientColor = System.Drawing.Color.SlateBlue;
			this.cdgvEmployees.HoverRowColor = System.Drawing.Color.LightSteelBlue;
			this.cdgvEmployees.Location = new System.Drawing.Point(0, 0);
			this.cdgvEmployees.Margin = new System.Windows.Forms.Padding(4);
			this.cdgvEmployees.Name = "cdgvEmployees";
			this.cdgvEmployees.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(55)))));
			dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			dataGridViewCellStyle4.ForeColor = System.Drawing.Color.WhiteSmoke;
			dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.CornflowerBlue;
			dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
			dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.cdgvEmployees.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
			this.cdgvEmployees.RowHeadersWidth = 51;
			dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(5);
			this.cdgvEmployees.RowsDefaultCellStyle = dataGridViewCellStyle5;
			this.cdgvEmployees.SelectedRowColor = System.Drawing.Color.CornflowerBlue;
			this.cdgvEmployees.Size = new System.Drawing.Size(681, 331);
			this.cdgvEmployees.TabIndex = 0;
			this.cdgvEmployees.UseHeaderGradient = false;
			this.cdgvEmployees.UseRoundedCorners = false;
			// 
			// cbtnSysSetting
			// 
			this.cbtnSysSetting.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.cbtnSysSetting.BackColor = System.Drawing.Color.Black;
			this.cbtnSysSetting.BorderColor = System.Drawing.Color.White;
			this.cbtnSysSetting.BorderRadius = 40;
			this.cbtnSysSetting.BorderSize = 0;
			this.cbtnSysSetting.Cursor = System.Windows.Forms.Cursors.Hand;
			this.cbtnSysSetting.FlatAppearance.BorderSize = 0;
			this.cbtnSysSetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.cbtnSysSetting.ForeColor = System.Drawing.Color.White;
			this.cbtnSysSetting.Location = new System.Drawing.Point(508, 14);
			this.cbtnSysSetting.Margin = new System.Windows.Forms.Padding(4);
			this.cbtnSysSetting.Name = "cbtnSysSetting";
			this.cbtnSysSetting.Size = new System.Drawing.Size(161, 43);
			this.cbtnSysSetting.TabIndex = 16;
			this.cbtnSysSetting.Text = "Rendszerbeállítások";
			this.cbtnSysSetting.UseVisualStyleBackColor = false;
			this.cbtnSysSetting.Click += new System.EventHandler(this.cbtnSysSetting_Click);
			// 
			// lblCdgwTitle
			// 
			this.lblCdgwTitle.AutoSize = true;
			this.lblCdgwTitle.Location = new System.Drawing.Point(4, 31);
			this.lblCdgwTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblCdgwTitle.Name = "lblCdgwTitle";
			this.lblCdgwTitle.Size = new System.Drawing.Size(122, 16);
			this.lblCdgwTitle.TabIndex = 1;
			this.lblCdgwTitle.Text = "Aktív alkalmazottak";
			// 
			// cbtnEmployees
			// 
			this.cbtnEmployees.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.cbtnEmployees.BackColor = System.Drawing.Color.Black;
			this.cbtnEmployees.BorderColor = System.Drawing.Color.White;
			this.cbtnEmployees.BorderRadius = 40;
			this.cbtnEmployees.BorderSize = 0;
			this.cbtnEmployees.Cursor = System.Windows.Forms.Cursors.Hand;
			this.cbtnEmployees.Enabled = false;
			this.cbtnEmployees.FlatAppearance.BorderSize = 0;
			this.cbtnEmployees.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.cbtnEmployees.ForeColor = System.Drawing.Color.White;
			this.cbtnEmployees.Location = new System.Drawing.Point(301, 14);
			this.cbtnEmployees.Margin = new System.Windows.Forms.Padding(4);
			this.cbtnEmployees.Name = "cbtnEmployees";
			this.cbtnEmployees.Size = new System.Drawing.Size(161, 43);
			this.cbtnEmployees.TabIndex = 15;
			this.cbtnEmployees.Text = "Alkalmazottak";
			this.cbtnEmployees.UseVisualStyleBackColor = false;
			this.cbtnEmployees.Click += new System.EventHandler(this.cbtnEmployees_Click);
			// 
			// cbtnLogout
			// 
			this.cbtnLogout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.cbtnLogout.BackColor = System.Drawing.Color.Brown;
			this.cbtnLogout.BorderColor = System.Drawing.Color.White;
			this.cbtnLogout.BorderRadius = 40;
			this.cbtnLogout.BorderSize = 0;
			this.cbtnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
			this.cbtnLogout.FlatAppearance.BorderSize = 0;
			this.cbtnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.cbtnLogout.ForeColor = System.Drawing.Color.White;
			this.cbtnLogout.Location = new System.Drawing.Point(733, 607);
			this.cbtnLogout.Margin = new System.Windows.Forms.Padding(4);
			this.cbtnLogout.Name = "cbtnLogout";
			this.cbtnLogout.Size = new System.Drawing.Size(200, 43);
			this.cbtnLogout.TabIndex = 13;
			this.cbtnLogout.Tag = "logoutBtn";
			this.cbtnLogout.Text = "Kilépés";
			this.cbtnLogout.UseVisualStyleBackColor = false;
			this.cbtnLogout.Click += new System.EventHandler(this.cbtnLogout_Click);
			// 
			// cbtnDeleteEmpl
			// 
			this.cbtnDeleteEmpl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.cbtnDeleteEmpl.BackColor = System.Drawing.Color.Black;
			this.cbtnDeleteEmpl.BorderColor = System.Drawing.Color.White;
			this.cbtnDeleteEmpl.BorderRadius = 40;
			this.cbtnDeleteEmpl.BorderSize = 0;
			this.cbtnDeleteEmpl.Cursor = System.Windows.Forms.Cursors.Hand;
			this.cbtnDeleteEmpl.FlatAppearance.BorderSize = 0;
			this.cbtnDeleteEmpl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.cbtnDeleteEmpl.ForeColor = System.Drawing.Color.White;
			this.cbtnDeleteEmpl.Location = new System.Drawing.Point(661, 33);
			this.cbtnDeleteEmpl.Margin = new System.Windows.Forms.Padding(4);
			this.cbtnDeleteEmpl.Name = "cbtnDeleteEmpl";
			this.cbtnDeleteEmpl.Size = new System.Drawing.Size(272, 43);
			this.cbtnDeleteEmpl.TabIndex = 12;
			this.cbtnDeleteEmpl.Text = "Alkalmazott végleges deaktiválása";
			this.cbtnDeleteEmpl.UseVisualStyleBackColor = false;
			this.cbtnDeleteEmpl.Click += new System.EventHandler(this.cbtnDeleteEmpl_Click);
			// 
			// ctbNewPassAgain
			// 
			this.ctbNewPassAgain.BackColor = System.Drawing.SystemColors.Window;
			this.ctbNewPassAgain.BorderColor = System.Drawing.Color.MediumSlateBlue;
			this.ctbNewPassAgain.BorderFocusColor = System.Drawing.Color.HotPink;
			this.ctbNewPassAgain.BorderRadius = 14;
			this.ctbNewPassAgain.BorderSize = 2;
			this.ctbNewPassAgain.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.ctbNewPassAgain.ForeColor = System.Drawing.Color.DimGray;
			this.ctbNewPassAgain.IsReadOnly = false;
			this.ctbNewPassAgain.Location = new System.Drawing.Point(44, 407);
			this.ctbNewPassAgain.Margin = new System.Windows.Forms.Padding(5);
			this.ctbNewPassAgain.Multiline = false;
			this.ctbNewPassAgain.Name = "ctbNewPassAgain";
			this.ctbNewPassAgain.Padding = new System.Windows.Forms.Padding(13, 9, 13, 9);
			this.ctbNewPassAgain.PasswordChar = true;
			this.ctbNewPassAgain.PlaceholderColor = System.Drawing.Color.DarkGray;
			this.ctbNewPassAgain.PlaceholderText = "Új jelszó ismétlése";
			this.ctbNewPassAgain.Size = new System.Drawing.Size(209, 39);
			this.ctbNewPassAgain.TabIndex = 10;
			this.ctbNewPassAgain.TextBoxScrollBars = System.Windows.Forms.ScrollBars.None;
			this.ctbNewPassAgain.Texts = "Új jelszó ismétlése";
			this.ctbNewPassAgain.UnderlinedStyle = false;
			// 
			// ctbNewPass
			// 
			this.ctbNewPass.BackColor = System.Drawing.SystemColors.Window;
			this.ctbNewPass.BorderColor = System.Drawing.Color.MediumSlateBlue;
			this.ctbNewPass.BorderFocusColor = System.Drawing.Color.HotPink;
			this.ctbNewPass.BorderRadius = 14;
			this.ctbNewPass.BorderSize = 2;
			this.ctbNewPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.ctbNewPass.ForeColor = System.Drawing.Color.DimGray;
			this.ctbNewPass.IsReadOnly = false;
			this.ctbNewPass.Location = new System.Drawing.Point(44, 334);
			this.ctbNewPass.Margin = new System.Windows.Forms.Padding(5);
			this.ctbNewPass.Multiline = false;
			this.ctbNewPass.Name = "ctbNewPass";
			this.ctbNewPass.Padding = new System.Windows.Forms.Padding(13, 9, 13, 9);
			this.ctbNewPass.PasswordChar = true;
			this.ctbNewPass.PlaceholderColor = System.Drawing.Color.DarkGray;
			this.ctbNewPass.PlaceholderText = "Új jelszó ";
			this.ctbNewPass.Size = new System.Drawing.Size(209, 39);
			this.ctbNewPass.TabIndex = 8;
			this.ctbNewPass.TextBoxScrollBars = System.Windows.Forms.ScrollBars.None;
			this.ctbNewPass.Texts = "Új jelszó ";
			this.ctbNewPass.UnderlinedStyle = false;
			// 
			// ctbOldPass
			// 
			this.ctbOldPass.BackColor = System.Drawing.SystemColors.Window;
			this.ctbOldPass.BorderColor = System.Drawing.Color.MediumSlateBlue;
			this.ctbOldPass.BorderFocusColor = System.Drawing.Color.HotPink;
			this.ctbOldPass.BorderRadius = 14;
			this.ctbOldPass.BorderSize = 2;
			this.ctbOldPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.ctbOldPass.ForeColor = System.Drawing.Color.DimGray;
			this.ctbOldPass.IsReadOnly = false;
			this.ctbOldPass.Location = new System.Drawing.Point(44, 252);
			this.ctbOldPass.Margin = new System.Windows.Forms.Padding(5);
			this.ctbOldPass.Multiline = false;
			this.ctbOldPass.Name = "ctbOldPass";
			this.ctbOldPass.Padding = new System.Windows.Forms.Padding(13, 9, 13, 9);
			this.ctbOldPass.PasswordChar = true;
			this.ctbOldPass.PlaceholderColor = System.Drawing.Color.DarkGray;
			this.ctbOldPass.PlaceholderText = "Régi jelszó";
			this.ctbOldPass.Size = new System.Drawing.Size(209, 39);
			this.ctbOldPass.TabIndex = 5;
			this.ctbOldPass.TextBoxScrollBars = System.Windows.Forms.ScrollBars.None;
			this.ctbOldPass.Texts = "Régi jelszó";
			this.ctbOldPass.UnderlinedStyle = false;
			// 
			// cbtnChangePass
			// 
			this.cbtnChangePass.BackColor = System.Drawing.Color.Black;
			this.cbtnChangePass.BorderColor = System.Drawing.Color.White;
			this.cbtnChangePass.BorderRadius = 40;
			this.cbtnChangePass.BorderSize = 0;
			this.cbtnChangePass.Cursor = System.Windows.Forms.Cursors.Hand;
			this.cbtnChangePass.FlatAppearance.BorderSize = 0;
			this.cbtnChangePass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.cbtnChangePass.ForeColor = System.Drawing.Color.White;
			this.cbtnChangePass.Location = new System.Drawing.Point(44, 484);
			this.cbtnChangePass.Margin = new System.Windows.Forms.Padding(4);
			this.cbtnChangePass.Name = "cbtnChangePass";
			this.cbtnChangePass.Size = new System.Drawing.Size(200, 43);
			this.cbtnChangePass.TabIndex = 4;
			this.cbtnChangePass.Text = "Változtat";
			this.cbtnChangePass.UseVisualStyleBackColor = false;
			this.cbtnChangePass.Click += new System.EventHandler(this.cbtnChangePass_Click);
			// 
			// EmployeeDetailedPage
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(987, 688);
			this.Controls.Add(this.pEmpolyees);
			this.Controls.Add(this.cbtnLogout);
			this.Controls.Add(this.cbtnDeleteEmpl);
			this.Controls.Add(this.ctbNewPassAgain);
			this.Controls.Add(this.ctbNewPass);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.ctbOldPass);
			this.Controls.Add(this.cbtnChangePass);
			this.Controls.Add(this.lbUname);
			this.Controls.Add(this.lbName);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "EmployeeDetailedPage";
			this.Text = "EmployeeDetailedPage";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EmployeeDetailedPage_FormClosing);
			this.Load += new System.EventHandler(this.EmployeeDetailedPage_Load);
			this.pEmpolyees.ResumeLayout(false);
			this.pEmpolyees.PerformLayout();
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.cdgvEmployees)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbUname;
        private CustomButton cbtnChangePass;
        private CustomTextbox ctbOldPass;
        private System.Windows.Forms.Label label5;
        private CustomTextbox ctbNewPass;
        private CustomTextbox ctbNewPassAgain;
        private CustomButton cbtnDeleteEmpl;
        private CustomButton cbtnLogout;
        private System.Windows.Forms.Panel pEmpolyees;
        private CustomDataGridView cdgvEmployees;
        private System.Windows.Forms.Label lblCdgwTitle;
        private CustomButton cbtnEmployees;
        private CustomButton cbtnSysSetting;
        private System.Windows.Forms.Panel panel1;
    }
}