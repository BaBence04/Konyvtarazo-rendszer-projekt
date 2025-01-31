namespace Desktop
{
	partial class UserDetailedPage
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
            this.tableLayoutPanel_UserDetails = new System.Windows.Forms.TableLayoutPanel();
            this.cdgwPublishers = new Desktop.CustomDataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDeactivateUser = new Desktop.CustomButton();
            this.tableLayoutPanel_UserDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cdgwPublishers)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel_UserDetails
            // 
            this.tableLayoutPanel_UserDetails.ColumnCount = 1;
            this.tableLayoutPanel_UserDetails.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_UserDetails.Controls.Add(this.cdgwPublishers, 0, 1);
            this.tableLayoutPanel_UserDetails.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel_UserDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_UserDetails.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel_UserDetails.Margin = new System.Windows.Forms.Padding(0, 0, 0, 40);
            this.tableLayoutPanel_UserDetails.Name = "tableLayoutPanel_UserDetails";
            this.tableLayoutPanel_UserDetails.RowCount = 2;
            this.tableLayoutPanel_UserDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.2737F));
            this.tableLayoutPanel_UserDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 66.7263F));
            this.tableLayoutPanel_UserDetails.Size = new System.Drawing.Size(727, 521);
            this.tableLayoutPanel_UserDetails.TabIndex = 3;
            // 
            // cdgwPublishers
            // 
            this.cdgwPublishers.AllowUserToAddRows = false;
            this.cdgwPublishers.AllowUserToDeleteRows = false;
            this.cdgwPublishers.AlternatingRowBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(71)))), ((int)(((byte)(88)))));
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(71)))), ((int)(((byte)(88)))));
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.cdgwPublishers.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.cdgwPublishers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.cdgwPublishers.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(68)))));
            this.cdgwPublishers.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.cdgwPublishers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cdgwPublishers.BorderThickness = 2;
            this.cdgwPublishers.CellBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(68)))));
            this.cdgwPublishers.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.cdgwPublishers.CellForeColor = System.Drawing.Color.WhiteSmoke;
            this.cdgwPublishers.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(55)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(15);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.cdgwPublishers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.cdgwPublishers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cdgwPublishers.CornerRadius = 8;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(68)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.cdgwPublishers.DefaultCellStyle = dataGridViewCellStyle3;
            this.cdgwPublishers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cdgwPublishers.EnableBorder = false;
            this.cdgwPublishers.EnableHeadersVisualStyles = false;
            this.cdgwPublishers.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(68)))));
            this.cdgwPublishers.HeaderBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(55)))));
            this.cdgwPublishers.HeaderForeColor = System.Drawing.Color.WhiteSmoke;
            this.cdgwPublishers.HeaderGradientColor = System.Drawing.Color.SlateBlue;
            this.cdgwPublishers.HoverRowColor = System.Drawing.Color.LightSteelBlue;
            this.cdgwPublishers.Location = new System.Drawing.Point(0, 173);
            this.cdgwPublishers.Margin = new System.Windows.Forms.Padding(0);
            this.cdgwPublishers.Name = "cdgwPublishers";
            this.cdgwPublishers.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(55)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.cdgwPublishers.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.cdgwPublishers.RowHeadersWidth = 51;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.cdgwPublishers.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.cdgwPublishers.RowTemplate.Height = 40;
            this.cdgwPublishers.SelectedRowColor = System.Drawing.Color.CornflowerBlue;
            this.cdgwPublishers.Size = new System.Drawing.Size(727, 348);
            this.cdgwPublishers.TabIndex = 0;
            this.cdgwPublishers.UseHeaderGradient = false;
            this.cdgwPublishers.UseRoundedCorners = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnDeactivateUser);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(721, 167);
            this.panel1.TabIndex = 3;
            // 
            // btnDeactivateUser
            // 
            this.btnDeactivateUser.BackColor = System.Drawing.Color.Black;
            this.btnDeactivateUser.BorderColor = System.Drawing.Color.White;
            this.btnDeactivateUser.BorderRadius = 40;
            this.btnDeactivateUser.BorderSize = 0;
            this.btnDeactivateUser.FlatAppearance.BorderSize = 0;
            this.btnDeactivateUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeactivateUser.ForeColor = System.Drawing.Color.White;
            this.btnDeactivateUser.Location = new System.Drawing.Point(546, 61);
            this.btnDeactivateUser.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDeactivateUser.Name = "btnDeactivateUser";
            this.btnDeactivateUser.Size = new System.Drawing.Size(160, 32);
            this.btnDeactivateUser.TabIndex = 0;
            this.btnDeactivateUser.Text = "Felhasználó deaktiválása";
            this.btnDeactivateUser.UseVisualStyleBackColor = false;
            // 
            // UserDetailedPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(68)))));
            this.ClientSize = new System.Drawing.Size(727, 521);
            this.Controls.Add(this.tableLayoutPanel_UserDetails);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "UserDetailedPage";
            this.Text = "UserDetailedPage";
            this.tableLayoutPanel_UserDetails.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cdgwPublishers)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_UserDetails;
		private CustomDataGridView cdgwPublishers;
		private System.Windows.Forms.Panel panel1;
		private CustomButton btnDeactivateUser;
	}
}