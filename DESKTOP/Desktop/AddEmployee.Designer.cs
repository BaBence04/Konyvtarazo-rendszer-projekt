namespace Desktop
{
    partial class AddEmployee
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
			this.ctbEmplName = new Desktop.CustomTextbox();
			this.cbtnAdd = new Desktop.CustomButton();
			this.ctbEmplPass = new Desktop.CustomTextbox();
			this.cbtnBack = new Desktop.CustomButton();
			this.SuspendLayout();
			// 
			// ctbEmplName
			// 
			this.ctbEmplName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(68)))));
			this.ctbEmplName.BorderColor = System.Drawing.Color.MediumSlateBlue;
			this.ctbEmplName.BorderFocusColor = System.Drawing.Color.HotPink;
			this.ctbEmplName.BorderRadius = 14;
			this.ctbEmplName.BorderSize = 2;
			this.ctbEmplName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.ctbEmplName.ForeColor = System.Drawing.Color.DimGray;
			this.ctbEmplName.IsReadOnly = false;
			this.ctbEmplName.Location = new System.Drawing.Point(35, 54);
			this.ctbEmplName.Margin = new System.Windows.Forms.Padding(5);
			this.ctbEmplName.Multiline = false;
			this.ctbEmplName.Name = "ctbEmplName";
			this.ctbEmplName.Padding = new System.Windows.Forms.Padding(13, 9, 13, 9);
			this.ctbEmplName.PasswordChar = false;
			this.ctbEmplName.PlaceholderColor = System.Drawing.Color.DarkGray;
			this.ctbEmplName.PlaceholderText = "Név";
			this.ctbEmplName.Size = new System.Drawing.Size(316, 39);
			this.ctbEmplName.TabIndex = 1;
			this.ctbEmplName.Texts = "Név";
			this.ctbEmplName.UnderlinedStyle = false;
			// 
			// cbtnAdd
			// 
			this.cbtnAdd.BackColor = System.Drawing.Color.Black;
			this.cbtnAdd.BorderColor = System.Drawing.Color.White;
			this.cbtnAdd.BorderRadius = 40;
			this.cbtnAdd.BorderSize = 0;
			this.cbtnAdd.FlatAppearance.BorderSize = 0;
			this.cbtnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.cbtnAdd.ForeColor = System.Drawing.Color.White;
			this.cbtnAdd.Location = new System.Drawing.Point(241, 279);
			this.cbtnAdd.Margin = new System.Windows.Forms.Padding(4);
			this.cbtnAdd.Name = "cbtnAdd";
			this.cbtnAdd.Size = new System.Drawing.Size(110, 50);
			this.cbtnAdd.TabIndex = 2;
			this.cbtnAdd.Text = "Hozzáad";
			this.cbtnAdd.UseVisualStyleBackColor = false;
			this.cbtnAdd.Click += new System.EventHandler(this.cbtnAdd_Click);
			// 
			// ctbEmplPass
			// 
			this.ctbEmplPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(68)))));
			this.ctbEmplPass.BorderColor = System.Drawing.Color.MediumSlateBlue;
			this.ctbEmplPass.BorderFocusColor = System.Drawing.Color.HotPink;
			this.ctbEmplPass.BorderRadius = 14;
			this.ctbEmplPass.BorderSize = 2;
			this.ctbEmplPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.ctbEmplPass.ForeColor = System.Drawing.Color.DimGray;
			this.ctbEmplPass.IsReadOnly = false;
			this.ctbEmplPass.Location = new System.Drawing.Point(35, 161);
			this.ctbEmplPass.Margin = new System.Windows.Forms.Padding(5);
			this.ctbEmplPass.Multiline = false;
			this.ctbEmplPass.Name = "ctbEmplPass";
			this.ctbEmplPass.Padding = new System.Windows.Forms.Padding(13, 9, 13, 9);
			this.ctbEmplPass.PasswordChar = true;
			this.ctbEmplPass.PlaceholderColor = System.Drawing.Color.DarkGray;
			this.ctbEmplPass.PlaceholderText = "Jelszó";
			this.ctbEmplPass.Size = new System.Drawing.Size(316, 39);
			this.ctbEmplPass.TabIndex = 4;
			this.ctbEmplPass.Texts = "Jelszó";
			this.ctbEmplPass.UnderlinedStyle = false;
			// 
			// cbtnBack
			// 
			this.cbtnBack.BackColor = System.Drawing.Color.Black;
			this.cbtnBack.BorderColor = System.Drawing.Color.White;
			this.cbtnBack.BorderRadius = 40;
			this.cbtnBack.BorderSize = 0;
			this.cbtnBack.FlatAppearance.BorderSize = 0;
			this.cbtnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.cbtnBack.ForeColor = System.Drawing.Color.White;
			this.cbtnBack.Location = new System.Drawing.Point(35, 279);
			this.cbtnBack.Margin = new System.Windows.Forms.Padding(4);
			this.cbtnBack.Name = "cbtnBack";
			this.cbtnBack.Size = new System.Drawing.Size(110, 50);
			this.cbtnBack.TabIndex = 5;
			this.cbtnBack.Text = "Vissza";
			this.cbtnBack.UseVisualStyleBackColor = false;
			// 
			// AddEmployee
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(68)))));
			this.ClientSize = new System.Drawing.Size(386, 389);
			this.Controls.Add(this.cbtnBack);
			this.Controls.Add(this.ctbEmplPass);
			this.Controls.Add(this.cbtnAdd);
			this.Controls.Add(this.ctbEmplName);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "AddEmployee";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Alkalmazott hozzáadása";
			this.ResumeLayout(false);

        }

        #endregion
        private CustomTextbox ctbEmplName;
        private CustomButton cbtnAdd;
        private CustomTextbox ctbEmplPass;
        private CustomButton cbtnBack;
    }
}