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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddUser));
            this.ctbSurname = new Desktop.CustomTextbox();
            this.cbtnAdd = new Desktop.CustomButton();
            this.dtpBirthDate = new System.Windows.Forms.DateTimePicker();
            this.ctbFirstName = new Desktop.CustomTextbox();
            this.label3 = new System.Windows.Forms.Label();
            this.ctbPhone = new Desktop.CustomTextbox();
            this.ctbEmail = new Desktop.CustomTextbox();
            this.ctbBirthplace = new Desktop.CustomTextbox();
            this.ctbAddress = new Desktop.CustomTextbox();
            this.ctbMmn = new Desktop.CustomTextbox();
            this.cbtnBack = new Desktop.CustomButton();
            this.button_CloseForm = new Desktop.CustomButton();
            this.SuspendLayout();
            // 
            // ctbSurname
            // 
            this.ctbSurname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(68)))));
            this.ctbSurname.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.ctbSurname.BorderFocusColor = System.Drawing.Color.HotPink;
            this.ctbSurname.BorderRadius = 14;
            this.ctbSurname.BorderSize = 2;
            this.ctbSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ctbSurname.ForeColor = System.Drawing.Color.DimGray;
            this.ctbSurname.IsReadOnly = false;
            this.ctbSurname.Location = new System.Drawing.Point(11, 92);
            this.ctbSurname.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ctbSurname.Multiline = false;
            this.ctbSurname.Name = "ctbSurname";
            this.ctbSurname.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.ctbSurname.PasswordChar = false;
            this.ctbSurname.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.ctbSurname.PlaceholderText = "Vezetéknév";
            this.ctbSurname.Size = new System.Drawing.Size(150, 31);
            this.ctbSurname.TabIndex = 0;
            this.ctbSurname.Texts = "Vezetéknév";
            this.ctbSurname.UnderlinedStyle = false;
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
            this.cbtnAdd.Location = new System.Drawing.Point(216, 429);
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
            this.dtpBirthDate.Location = new System.Drawing.Point(11, 187);
            this.dtpBirthDate.Name = "dtpBirthDate";
            this.dtpBirthDate.Size = new System.Drawing.Size(127, 20);
            this.dtpBirthDate.TabIndex = 3;
            // 
            // ctbFirstName
            // 
            this.ctbFirstName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(68)))));
            this.ctbFirstName.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.ctbFirstName.BorderFocusColor = System.Drawing.Color.HotPink;
            this.ctbFirstName.BorderRadius = 14;
            this.ctbFirstName.BorderSize = 2;
            this.ctbFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ctbFirstName.ForeColor = System.Drawing.Color.DimGray;
            this.ctbFirstName.IsReadOnly = false;
            this.ctbFirstName.Location = new System.Drawing.Point(216, 92);
            this.ctbFirstName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ctbFirstName.Multiline = false;
            this.ctbFirstName.Name = "ctbFirstName";
            this.ctbFirstName.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.ctbFirstName.PasswordChar = false;
            this.ctbFirstName.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.ctbFirstName.PlaceholderText = "Keresztnév";
            this.ctbFirstName.Size = new System.Drawing.Size(150, 31);
            this.ctbFirstName.TabIndex = 4;
            this.ctbFirstName.Texts = "Keresztnév";
            this.ctbFirstName.UnderlinedStyle = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Születési Dátum";
            // 
            // ctbPhone
            // 
            this.ctbPhone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(68)))));
            this.ctbPhone.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.ctbPhone.BorderFocusColor = System.Drawing.Color.HotPink;
            this.ctbPhone.BorderRadius = 14;
            this.ctbPhone.BorderSize = 2;
            this.ctbPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ctbPhone.ForeColor = System.Drawing.Color.DimGray;
            this.ctbPhone.IsReadOnly = false;
            this.ctbPhone.Location = new System.Drawing.Point(216, 271);
            this.ctbPhone.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ctbPhone.Multiline = false;
            this.ctbPhone.Name = "ctbPhone";
            this.ctbPhone.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.ctbPhone.PasswordChar = false;
            this.ctbPhone.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.ctbPhone.PlaceholderText = "Telefonszám";
            this.ctbPhone.Size = new System.Drawing.Size(150, 31);
            this.ctbPhone.TabIndex = 7;
            this.ctbPhone.Texts = "Telefonszám";
            this.ctbPhone.UnderlinedStyle = false;
            // 
            // ctbEmail
            // 
            this.ctbEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(68)))));
            this.ctbEmail.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.ctbEmail.BorderFocusColor = System.Drawing.Color.HotPink;
            this.ctbEmail.BorderRadius = 14;
            this.ctbEmail.BorderSize = 2;
            this.ctbEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ctbEmail.ForeColor = System.Drawing.Color.DimGray;
            this.ctbEmail.IsReadOnly = false;
            this.ctbEmail.Location = new System.Drawing.Point(11, 271);
            this.ctbEmail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ctbEmail.Multiline = false;
            this.ctbEmail.Name = "ctbEmail";
            this.ctbEmail.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.ctbEmail.PasswordChar = false;
            this.ctbEmail.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.ctbEmail.PlaceholderText = "E-mail";
            this.ctbEmail.Size = new System.Drawing.Size(150, 31);
            this.ctbEmail.TabIndex = 9;
            this.ctbEmail.Texts = "E-mail";
            this.ctbEmail.UnderlinedStyle = false;
            // 
            // ctbBirthplace
            // 
            this.ctbBirthplace.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(68)))));
            this.ctbBirthplace.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.ctbBirthplace.BorderFocusColor = System.Drawing.Color.HotPink;
            this.ctbBirthplace.BorderRadius = 14;
            this.ctbBirthplace.BorderSize = 2;
            this.ctbBirthplace.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ctbBirthplace.ForeColor = System.Drawing.Color.DimGray;
            this.ctbBirthplace.IsReadOnly = false;
            this.ctbBirthplace.Location = new System.Drawing.Point(216, 176);
            this.ctbBirthplace.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ctbBirthplace.Multiline = false;
            this.ctbBirthplace.Name = "ctbBirthplace";
            this.ctbBirthplace.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.ctbBirthplace.PasswordChar = false;
            this.ctbBirthplace.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.ctbBirthplace.PlaceholderText = "Születési hely";
            this.ctbBirthplace.Size = new System.Drawing.Size(150, 31);
            this.ctbBirthplace.TabIndex = 11;
            this.ctbBirthplace.Texts = "Születési hely";
            this.ctbBirthplace.UnderlinedStyle = false;
            // 
            // ctbAddress
            // 
            this.ctbAddress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(68)))));
            this.ctbAddress.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.ctbAddress.BorderFocusColor = System.Drawing.Color.HotPink;
            this.ctbAddress.BorderRadius = 14;
            this.ctbAddress.BorderSize = 2;
            this.ctbAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ctbAddress.ForeColor = System.Drawing.Color.DimGray;
            this.ctbAddress.IsReadOnly = false;
            this.ctbAddress.Location = new System.Drawing.Point(11, 351);
            this.ctbAddress.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ctbAddress.Multiline = false;
            this.ctbAddress.Name = "ctbAddress";
            this.ctbAddress.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.ctbAddress.PasswordChar = false;
            this.ctbAddress.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.ctbAddress.PlaceholderText = "Lakhely/cím";
            this.ctbAddress.Size = new System.Drawing.Size(150, 31);
            this.ctbAddress.TabIndex = 15;
            this.ctbAddress.Texts = "Lakhely/cím";
            this.ctbAddress.UnderlinedStyle = false;
            // 
            // ctbMmn
            // 
            this.ctbMmn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(68)))));
            this.ctbMmn.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.ctbMmn.BorderFocusColor = System.Drawing.Color.HotPink;
            this.ctbMmn.BorderRadius = 14;
            this.ctbMmn.BorderSize = 2;
            this.ctbMmn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ctbMmn.ForeColor = System.Drawing.Color.DimGray;
            this.ctbMmn.IsReadOnly = false;
            this.ctbMmn.Location = new System.Drawing.Point(216, 351);
            this.ctbMmn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ctbMmn.Multiline = false;
            this.ctbMmn.Name = "ctbMmn";
            this.ctbMmn.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.ctbMmn.PasswordChar = false;
            this.ctbMmn.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.ctbMmn.PlaceholderText = "Anyja neve";
            this.ctbMmn.Size = new System.Drawing.Size(150, 31);
            this.ctbMmn.TabIndex = 13;
            this.ctbMmn.Texts = "Anyja neve";
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
            this.cbtnBack.Location = new System.Drawing.Point(34, 429);
            this.cbtnBack.Name = "cbtnBack";
            this.cbtnBack.Size = new System.Drawing.Size(127, 40);
            this.cbtnBack.TabIndex = 17;
            this.cbtnBack.Text = "Vissza";
            this.cbtnBack.UseVisualStyleBackColor = false;
            this.cbtnBack.Click += new System.EventHandler(this.cbtnBack_Click);
            // 
            // button_CloseForm
            // 
            this.button_CloseForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(68)))));
            this.button_CloseForm.BorderColor = System.Drawing.Color.White;
            this.button_CloseForm.BorderRadius = 40;
            this.button_CloseForm.BorderSize = 0;
            this.button_CloseForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_CloseForm.FlatAppearance.BorderSize = 0;
            this.button_CloseForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_CloseForm.ForeColor = System.Drawing.Color.White;
            this.button_CloseForm.Image = ((System.Drawing.Image)(resources.GetObject("button_CloseForm.Image")));
            this.button_CloseForm.Location = new System.Drawing.Point(336, 3);
            this.button_CloseForm.Name = "button_CloseForm";
            this.button_CloseForm.Size = new System.Drawing.Size(40, 40);
            this.button_CloseForm.TabIndex = 18;
            this.button_CloseForm.UseVisualStyleBackColor = false;
            this.button_CloseForm.Click += new System.EventHandler(this.button_CloseForm_Click);
            // 
            // AddUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(68)))));
            this.ClientSize = new System.Drawing.Size(379, 503);
            this.Controls.Add(this.button_CloseForm);
            this.Controls.Add(this.cbtnBack);
            this.Controls.Add(this.ctbAddress);
            this.Controls.Add(this.ctbMmn);
            this.Controls.Add(this.ctbBirthplace);
            this.Controls.Add(this.ctbEmail);
            this.Controls.Add(this.ctbPhone);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ctbFirstName);
            this.Controls.Add(this.dtpBirthDate);
            this.Controls.Add(this.cbtnAdd);
            this.Controls.Add(this.ctbSurname);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Felhasználó hozzáadása";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomTextbox ctbSurname;
        private CustomButton cbtnAdd;
        private System.Windows.Forms.DateTimePicker dtpBirthDate;
        private CustomTextbox ctbFirstName;
        private System.Windows.Forms.Label label3;
        private CustomTextbox ctbPhone;
        private CustomTextbox ctbEmail;
        private CustomTextbox ctbBirthplace;
        private CustomTextbox ctbAddress;
        private CustomTextbox ctbMmn;
        private CustomButton cbtnBack;
        private CustomButton button_CloseForm;
    }
}