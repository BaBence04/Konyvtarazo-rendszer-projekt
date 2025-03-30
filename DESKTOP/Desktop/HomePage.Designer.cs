namespace Desktop
{
    partial class HomePage
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
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.quickAddUser = new Desktop.CustomButton();
			this.panel2 = new System.Windows.Forms.Panel();
			this.customButton4 = new Desktop.CustomButton();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// pictureBox1
			// 
			this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pictureBox1.Image = global::Desktop.Properties.Resources.main_page_ill;
			this.pictureBox1.Location = new System.Drawing.Point(0, 0);
			this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(987, 688);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.quickAddUser);
			this.panel1.Location = new System.Drawing.Point(12, 12);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(317, 74);
			this.panel1.TabIndex = 1;
			// 
			// quickAddUser
			// 
			this.quickAddUser.BackColor = System.Drawing.Color.Black;
			this.quickAddUser.BorderColor = System.Drawing.Color.White;
			this.quickAddUser.BorderRadius = 45;
			this.quickAddUser.BorderSize = 0;
			this.quickAddUser.Cursor = System.Windows.Forms.Cursors.Hand;
			this.quickAddUser.FlatAppearance.BorderSize = 0;
			this.quickAddUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.quickAddUser.ForeColor = System.Drawing.Color.White;
			this.quickAddUser.Location = new System.Drawing.Point(20, 14);
			this.quickAddUser.Name = "quickAddUser";
			this.quickAddUser.Size = new System.Drawing.Size(221, 43);
			this.quickAddUser.TabIndex = 0;
			this.quickAddUser.Text = "Új felhasználó hozzáadása";
			this.quickAddUser.UseVisualStyleBackColor = false;
			this.quickAddUser.Click += new System.EventHandler(this.quickAddUser_Click);
			// 
			// panel2
			// 
			this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.panel2.Controls.Add(this.customButton4);
			this.panel2.Location = new System.Drawing.Point(766, 12);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(209, 100);
			this.panel2.TabIndex = 2;
			// 
			// customButton4
			// 
			this.customButton4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
			this.customButton4.BorderColor = System.Drawing.Color.White;
			this.customButton4.BorderRadius = 40;
			this.customButton4.BorderSize = 0;
			this.customButton4.Cursor = System.Windows.Forms.Cursors.Hand;
			this.customButton4.FlatAppearance.BorderSize = 0;
			this.customButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.customButton4.ForeColor = System.Drawing.Color.White;
			this.customButton4.Image = global::Desktop.Properties.Resources.logout_circle_r_line_white;
			this.customButton4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.customButton4.Location = new System.Drawing.Point(42, 14);
			this.customButton4.Name = "customButton4";
			this.customButton4.Size = new System.Drawing.Size(150, 40);
			this.customButton4.TabIndex = 0;
			this.customButton4.Tag = "logoutBtn";
			this.customButton4.Text = "Kilépés";
			this.customButton4.UseVisualStyleBackColor = false;
			this.customButton4.Click += new System.EventHandler(this.customButton4_Click);
			// 
			// HomePage
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(68)))));
			this.ClientSize = new System.Drawing.Size(987, 688);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.pictureBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "HomePage";
			this.Text = "HomePage";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.ResumeLayout(false);

        }

		#endregion

		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Panel panel1;
		private CustomButton quickAddUser;
		private System.Windows.Forms.Panel panel2;
		private CustomButton customButton4;
	}
}