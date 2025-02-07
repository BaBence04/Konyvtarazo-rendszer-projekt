namespace Desktop
{
    partial class AddPublisher
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
            this.ctbTel = new Desktop.CustomTextbox();
            this.ctbName = new Desktop.CustomTextbox();
            this.ctbEmail = new Desktop.CustomTextbox();
            this.ctbWeb = new Desktop.CustomTextbox();
            this.cbtnAdd = new Desktop.CustomButton();
            this.button_CloseLoginForm = new Desktop.CustomButton();
            this.SuspendLayout();
            // 
            // ctbTel
            // 
            this.ctbTel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(68)))));
            this.ctbTel.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.ctbTel.BorderFocusColor = System.Drawing.Color.HotPink;
            this.ctbTel.BorderRadius = 14;
            this.ctbTel.BorderSize = 2;
            this.ctbTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ctbTel.ForeColor = System.Drawing.Color.DimGray;
            this.ctbTel.IsReadOnly = false;
            this.ctbTel.Location = new System.Drawing.Point(26, 175);
            this.ctbTel.Margin = new System.Windows.Forms.Padding(4);
            this.ctbTel.Multiline = false;
            this.ctbTel.Name = "ctbTel";
            this.ctbTel.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.ctbTel.PasswordChar = false;
            this.ctbTel.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.ctbTel.PlaceholderText = "Kiadó telefonszáma";
            this.ctbTel.Size = new System.Drawing.Size(250, 31);
            this.ctbTel.TabIndex = 0;
            this.ctbTel.Texts = "Kiadó telefonszáma";
            this.ctbTel.UnderlinedStyle = false;
            // 
            // ctbName
            // 
            this.ctbName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(68)))));
            this.ctbName.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.ctbName.BorderFocusColor = System.Drawing.Color.HotPink;
            this.ctbName.BorderRadius = 14;
            this.ctbName.BorderSize = 2;
            this.ctbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ctbName.ForeColor = System.Drawing.Color.DimGray;
            this.ctbName.IsReadOnly = false;
            this.ctbName.Location = new System.Drawing.Point(26, 103);
            this.ctbName.Margin = new System.Windows.Forms.Padding(4);
            this.ctbName.Multiline = false;
            this.ctbName.Name = "ctbName";
            this.ctbName.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.ctbName.PasswordChar = false;
            this.ctbName.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.ctbName.PlaceholderText = "Kiadó neve";
            this.ctbName.Size = new System.Drawing.Size(250, 31);
            this.ctbName.TabIndex = 1;
            this.ctbName.Texts = "Kiadó neve";
            this.ctbName.UnderlinedStyle = false;
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
            this.ctbEmail.Location = new System.Drawing.Point(26, 241);
            this.ctbEmail.Margin = new System.Windows.Forms.Padding(4);
            this.ctbEmail.Multiline = false;
            this.ctbEmail.Name = "ctbEmail";
            this.ctbEmail.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.ctbEmail.PasswordChar = false;
            this.ctbEmail.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.ctbEmail.PlaceholderText = "Kiadó e-mail címe";
            this.ctbEmail.Size = new System.Drawing.Size(250, 31);
            this.ctbEmail.TabIndex = 6;
            this.ctbEmail.Texts = "Kiadó e-mail címe";
            this.ctbEmail.UnderlinedStyle = false;
            // 
            // ctbWeb
            // 
            this.ctbWeb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(68)))));
            this.ctbWeb.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.ctbWeb.BorderFocusColor = System.Drawing.Color.HotPink;
            this.ctbWeb.BorderRadius = 14;
            this.ctbWeb.BorderSize = 2;
            this.ctbWeb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ctbWeb.ForeColor = System.Drawing.Color.DimGray;
            this.ctbWeb.IsReadOnly = false;
            this.ctbWeb.Location = new System.Drawing.Point(26, 312);
            this.ctbWeb.Margin = new System.Windows.Forms.Padding(4);
            this.ctbWeb.Multiline = false;
            this.ctbWeb.Name = "ctbWeb";
            this.ctbWeb.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.ctbWeb.PasswordChar = false;
            this.ctbWeb.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.ctbWeb.PlaceholderText = "Kiadó weboldala";
            this.ctbWeb.Size = new System.Drawing.Size(250, 31);
            this.ctbWeb.TabIndex = 7;
            this.ctbWeb.Texts = "Kiadó weboldala";
            this.ctbWeb.UnderlinedStyle = false;
            // 
            // cbtnAdd
            // 
            this.cbtnAdd.BackColor = System.Drawing.Color.DimGray;
            this.cbtnAdd.BorderColor = System.Drawing.Color.White;
            this.cbtnAdd.BorderRadius = 30;
            this.cbtnAdd.BorderSize = 0;
            this.cbtnAdd.FlatAppearance.BorderSize = 0;
            this.cbtnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbtnAdd.ForeColor = System.Drawing.Color.White;
            this.cbtnAdd.Location = new System.Drawing.Point(47, 371);
            this.cbtnAdd.Name = "cbtnAdd";
            this.cbtnAdd.Size = new System.Drawing.Size(212, 28);
            this.cbtnAdd.TabIndex = 8;
            this.cbtnAdd.Text = "Hozzáad";
            this.cbtnAdd.UseVisualStyleBackColor = false;
            this.cbtnAdd.Click += new System.EventHandler(this.cbtnAdd_Click);
            // 
            // button_CloseLoginForm
            // 
            this.button_CloseLoginForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(68)))));
            this.button_CloseLoginForm.BorderColor = System.Drawing.Color.White;
            this.button_CloseLoginForm.BorderRadius = 40;
            this.button_CloseLoginForm.BorderSize = 0;
            this.button_CloseLoginForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_CloseLoginForm.FlatAppearance.BorderSize = 0;
            this.button_CloseLoginForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_CloseLoginForm.ForeColor = System.Drawing.Color.White;
            this.button_CloseLoginForm.Location = new System.Drawing.Point(260, 2);
            this.button_CloseLoginForm.Name = "button_CloseLoginForm";
            this.button_CloseLoginForm.Size = new System.Drawing.Size(40, 40);
            this.button_CloseLoginForm.TabIndex = 9;
            this.button_CloseLoginForm.UseVisualStyleBackColor = false;
            this.button_CloseLoginForm.Click += new System.EventHandler(this.button_CloseLoginForm_Click);
            // 
            // AddPublisher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(68)))));
            this.ClientSize = new System.Drawing.Size(300, 450);
            this.Controls.Add(this.button_CloseLoginForm);
            this.Controls.Add(this.cbtnAdd);
            this.Controls.Add(this.ctbWeb);
            this.Controls.Add(this.ctbEmail);
            this.Controls.Add(this.ctbName);
            this.Controls.Add(this.ctbTel);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddPublisher";
            this.Text = "addPublisher";
            this.ResumeLayout(false);

        }

        #endregion

        private CustomTextbox ctbTel;
        private CustomTextbox ctbName;
        private CustomTextbox ctbEmail;
        private CustomTextbox ctbWeb;
        private CustomButton cbtnAdd;
        private CustomButton button_CloseLoginForm;
    }
}