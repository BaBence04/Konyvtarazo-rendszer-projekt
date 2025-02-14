namespace Desktop
{
    partial class AddUser
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
            this.ctbSurname = new Desktop.CustomTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbtnAdd = new Desktop.CustomButton();
            this.dtpBirthDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.ctbFirstName = new Desktop.CustomTextbox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ctbPhone = new Desktop.CustomTextbox();
            this.label5 = new System.Windows.Forms.Label();
            this.ctbEmail = new Desktop.CustomTextbox();
            this.label6 = new System.Windows.Forms.Label();
            this.ctbBirthplace = new Desktop.CustomTextbox();
            this.label7 = new System.Windows.Forms.Label();
            this.ctbAddress = new Desktop.CustomTextbox();
            this.label8 = new System.Windows.Forms.Label();
            this.ctbMmn = new Desktop.CustomTextbox();
            this.cbtnBack = new Desktop.CustomButton();
            this.SuspendLayout();
            // 
            // ctbSurname
            // 
            this.ctbSurname.BackColor = System.Drawing.SystemColors.Window;
            this.ctbSurname.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.ctbSurname.BorderFocusColor = System.Drawing.Color.HotPink;
            this.ctbSurname.BorderRadius = 0;
            this.ctbSurname.BorderSize = 2;
            this.ctbSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ctbSurname.ForeColor = System.Drawing.Color.DimGray;
            this.ctbSurname.IsReadOnly = false;
            this.ctbSurname.Location = new System.Drawing.Point(13, 38);
            this.ctbSurname.Margin = new System.Windows.Forms.Padding(4);
            this.ctbSurname.Multiline = false;
            this.ctbSurname.Name = "ctbSurname";
            this.ctbSurname.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.ctbSurname.PasswordChar = false;
            this.ctbSurname.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.ctbSurname.PlaceholderText = "";
            this.ctbSurname.Size = new System.Drawing.Size(127, 31);
            this.ctbSurname.TabIndex = 0;
            this.ctbSurname.Texts = "";
            this.ctbSurname.UnderlinedStyle = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Vezetéknév";
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
            this.cbtnAdd.Location = new System.Drawing.Point(198, 375);
            this.cbtnAdd.Name = "cbtnAdd";
            this.cbtnAdd.Size = new System.Drawing.Size(127, 40);
            this.cbtnAdd.TabIndex = 2;
            this.cbtnAdd.Text = "Hozzáad";
            this.cbtnAdd.UseVisualStyleBackColor = false;
            this.cbtnAdd.Click += new System.EventHandler(this.cbtnAdd_Click);
            // 
            // dtpBirthDate
            // 
            this.dtpBirthDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpBirthDate.Location = new System.Drawing.Point(13, 133);
            this.dtpBirthDate.Name = "dtpBirthDate";
            this.dtpBirthDate.Size = new System.Drawing.Size(127, 20);
            this.dtpBirthDate.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(195, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Keresztnév";
            // 
            // ctbFirstName
            // 
            this.ctbFirstName.BackColor = System.Drawing.SystemColors.Window;
            this.ctbFirstName.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.ctbFirstName.BorderFocusColor = System.Drawing.Color.HotPink;
            this.ctbFirstName.BorderRadius = 0;
            this.ctbFirstName.BorderSize = 2;
            this.ctbFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ctbFirstName.ForeColor = System.Drawing.Color.DimGray;
            this.ctbFirstName.IsReadOnly = false;
            this.ctbFirstName.Location = new System.Drawing.Point(198, 38);
            this.ctbFirstName.Margin = new System.Windows.Forms.Padding(4);
            this.ctbFirstName.Multiline = false;
            this.ctbFirstName.Name = "ctbFirstName";
            this.ctbFirstName.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.ctbFirstName.PasswordChar = false;
            this.ctbFirstName.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.ctbFirstName.PlaceholderText = "";
            this.ctbFirstName.Size = new System.Drawing.Size(127, 31);
            this.ctbFirstName.TabIndex = 4;
            this.ctbFirstName.Texts = "";
            this.ctbFirstName.UnderlinedStyle = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Születési Dátum";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(195, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Telefonszám";
            // 
            // ctbPhone
            // 
            this.ctbPhone.BackColor = System.Drawing.SystemColors.Window;
            this.ctbPhone.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.ctbPhone.BorderFocusColor = System.Drawing.Color.HotPink;
            this.ctbPhone.BorderRadius = 0;
            this.ctbPhone.BorderSize = 2;
            this.ctbPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ctbPhone.ForeColor = System.Drawing.Color.DimGray;
            this.ctbPhone.IsReadOnly = false;
            this.ctbPhone.Location = new System.Drawing.Point(198, 217);
            this.ctbPhone.Margin = new System.Windows.Forms.Padding(4);
            this.ctbPhone.Multiline = false;
            this.ctbPhone.Name = "ctbPhone";
            this.ctbPhone.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.ctbPhone.PasswordChar = false;
            this.ctbPhone.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.ctbPhone.PlaceholderText = "";
            this.ctbPhone.Size = new System.Drawing.Size(127, 31);
            this.ctbPhone.TabIndex = 7;
            this.ctbPhone.Texts = "";
            this.ctbPhone.UnderlinedStyle = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 200);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Email";
            // 
            // ctbEmail
            // 
            this.ctbEmail.BackColor = System.Drawing.SystemColors.Window;
            this.ctbEmail.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.ctbEmail.BorderFocusColor = System.Drawing.Color.HotPink;
            this.ctbEmail.BorderRadius = 0;
            this.ctbEmail.BorderSize = 2;
            this.ctbEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ctbEmail.ForeColor = System.Drawing.Color.DimGray;
            this.ctbEmail.IsReadOnly = false;
            this.ctbEmail.Location = new System.Drawing.Point(20, 217);
            this.ctbEmail.Margin = new System.Windows.Forms.Padding(4);
            this.ctbEmail.Multiline = false;
            this.ctbEmail.Name = "ctbEmail";
            this.ctbEmail.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.ctbEmail.PasswordChar = false;
            this.ctbEmail.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.ctbEmail.PlaceholderText = "";
            this.ctbEmail.Size = new System.Drawing.Size(127, 31);
            this.ctbEmail.TabIndex = 9;
            this.ctbEmail.Texts = "";
            this.ctbEmail.UnderlinedStyle = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(195, 105);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Születési hely";
            // 
            // ctbBirthplace
            // 
            this.ctbBirthplace.BackColor = System.Drawing.SystemColors.Window;
            this.ctbBirthplace.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.ctbBirthplace.BorderFocusColor = System.Drawing.Color.HotPink;
            this.ctbBirthplace.BorderRadius = 0;
            this.ctbBirthplace.BorderSize = 2;
            this.ctbBirthplace.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ctbBirthplace.ForeColor = System.Drawing.Color.DimGray;
            this.ctbBirthplace.IsReadOnly = false;
            this.ctbBirthplace.Location = new System.Drawing.Point(198, 122);
            this.ctbBirthplace.Margin = new System.Windows.Forms.Padding(4);
            this.ctbBirthplace.Multiline = false;
            this.ctbBirthplace.Name = "ctbBirthplace";
            this.ctbBirthplace.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.ctbBirthplace.PasswordChar = false;
            this.ctbBirthplace.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.ctbBirthplace.PlaceholderText = "";
            this.ctbBirthplace.Size = new System.Drawing.Size(127, 31);
            this.ctbBirthplace.TabIndex = 11;
            this.ctbBirthplace.Texts = "";
            this.ctbBirthplace.UnderlinedStyle = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 280);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Lakhely/cím";
            // 
            // ctbAddress
            // 
            this.ctbAddress.BackColor = System.Drawing.SystemColors.Window;
            this.ctbAddress.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.ctbAddress.BorderFocusColor = System.Drawing.Color.HotPink;
            this.ctbAddress.BorderRadius = 0;
            this.ctbAddress.BorderSize = 2;
            this.ctbAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ctbAddress.ForeColor = System.Drawing.Color.DimGray;
            this.ctbAddress.IsReadOnly = false;
            this.ctbAddress.Location = new System.Drawing.Point(20, 297);
            this.ctbAddress.Margin = new System.Windows.Forms.Padding(4);
            this.ctbAddress.Multiline = false;
            this.ctbAddress.Name = "ctbAddress";
            this.ctbAddress.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.ctbAddress.PasswordChar = false;
            this.ctbAddress.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.ctbAddress.PlaceholderText = "";
            this.ctbAddress.Size = new System.Drawing.Size(127, 31);
            this.ctbAddress.TabIndex = 15;
            this.ctbAddress.Texts = "";
            this.ctbAddress.UnderlinedStyle = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(195, 280);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Anyja neve";
            // 
            // ctbMmn
            // 
            this.ctbMmn.BackColor = System.Drawing.SystemColors.Window;
            this.ctbMmn.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.ctbMmn.BorderFocusColor = System.Drawing.Color.HotPink;
            this.ctbMmn.BorderRadius = 0;
            this.ctbMmn.BorderSize = 2;
            this.ctbMmn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ctbMmn.ForeColor = System.Drawing.Color.DimGray;
            this.ctbMmn.IsReadOnly = false;
            this.ctbMmn.Location = new System.Drawing.Point(198, 297);
            this.ctbMmn.Margin = new System.Windows.Forms.Padding(4);
            this.ctbMmn.Multiline = false;
            this.ctbMmn.Name = "ctbMmn";
            this.ctbMmn.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.ctbMmn.PasswordChar = false;
            this.ctbMmn.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.ctbMmn.PlaceholderText = "";
            this.ctbMmn.Size = new System.Drawing.Size(127, 31);
            this.ctbMmn.TabIndex = 13;
            this.ctbMmn.Texts = "";
            this.ctbMmn.UnderlinedStyle = false;
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
            this.cbtnBack.Location = new System.Drawing.Point(20, 375);
            this.cbtnBack.Name = "cbtnBack";
            this.cbtnBack.Size = new System.Drawing.Size(127, 40);
            this.cbtnBack.TabIndex = 17;
            this.cbtnBack.Text = "Vissza";
            this.cbtnBack.UseVisualStyleBackColor = false;
            this.cbtnBack.Click += new System.EventHandler(this.cbtnBack_Click);
            // 
            // AddUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 427);
            this.Controls.Add(this.cbtnBack);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.ctbAddress);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.ctbMmn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ctbBirthplace);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ctbEmail);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ctbPhone);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ctbFirstName);
            this.Controls.Add(this.dtpBirthDate);
            this.Controls.Add(this.cbtnAdd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ctbSurname);
            this.Name = "AddUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Felhasználó hozzáadása";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomTextbox ctbSurname;
        private System.Windows.Forms.Label label1;
        private CustomButton cbtnAdd;
        private System.Windows.Forms.DateTimePicker dtpBirthDate;
        private System.Windows.Forms.Label label2;
        private CustomTextbox ctbFirstName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private CustomTextbox ctbPhone;
        private System.Windows.Forms.Label label5;
        private CustomTextbox ctbEmail;
        private System.Windows.Forms.Label label6;
        private CustomTextbox ctbBirthplace;
        private System.Windows.Forms.Label label7;
        private CustomTextbox ctbAddress;
        private System.Windows.Forms.Label label8;
        private CustomTextbox ctbMmn;
        private CustomButton cbtnBack;
    }
}