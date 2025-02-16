namespace Desktop
{
    partial class LoginForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
			this.label1 = new System.Windows.Forms.Label();
			this.button_CloseLoginForm = new Desktop.CustomButton();
			this.customButton1 = new Desktop.CustomButton();
			this.tbLoginPw = new Desktop.CustomTextbox();
			this.tbLoginUname = new Desktop.CustomTextbox();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.label1.Location = new System.Drawing.Point(79, 102);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(241, 31);
			this.label1.TabIndex = 4;
			this.label1.Text = "BEJELENTKEZÉS";
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
			this.button_CloseLoginForm.Image = ((System.Drawing.Image)(resources.GetObject("button_CloseLoginForm.Image")));
			this.button_CloseLoginForm.Location = new System.Drawing.Point(345, 1);
			this.button_CloseLoginForm.Margin = new System.Windows.Forms.Padding(4);
			this.button_CloseLoginForm.Name = "button_CloseLoginForm";
			this.button_CloseLoginForm.Size = new System.Drawing.Size(53, 49);
			this.button_CloseLoginForm.TabIndex = 3;
			this.button_CloseLoginForm.UseVisualStyleBackColor = false;
			this.button_CloseLoginForm.Click += new System.EventHandler(this.button_CloseLoginForm_Click);
			// 
			// customButton1
			// 
			this.customButton1.BackColor = System.Drawing.Color.DimGray;
			this.customButton1.BorderColor = System.Drawing.Color.White;
			this.customButton1.BorderRadius = 30;
			this.customButton1.BorderSize = 0;
			this.customButton1.Cursor = System.Windows.Forms.Cursors.Hand;
			this.customButton1.FlatAppearance.BorderSize = 0;
			this.customButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.customButton1.ForeColor = System.Drawing.Color.White;
			this.customButton1.Location = new System.Drawing.Point(97, 453);
			this.customButton1.Margin = new System.Windows.Forms.Padding(4);
			this.customButton1.Name = "customButton1";
			this.customButton1.Size = new System.Drawing.Size(200, 38);
			this.customButton1.TabIndex = 2;
			this.customButton1.Text = "Bejelentkezés";
			this.customButton1.UseVisualStyleBackColor = false;
			this.customButton1.Click += new System.EventHandler(this.customButton1_Click);
			// 
			// tbLoginPw
			// 
			this.tbLoginPw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(68)))));
			this.tbLoginPw.BorderColor = System.Drawing.Color.MediumSlateBlue;
			this.tbLoginPw.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(205)))), ((int)(((byte)(198)))));
			this.tbLoginPw.BorderRadius = 14;
			this.tbLoginPw.BorderSize = 2;
			this.tbLoginPw.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.tbLoginPw.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.tbLoginPw.IsReadOnly = false;
			this.tbLoginPw.Location = new System.Drawing.Point(33, 295);
			this.tbLoginPw.Margin = new System.Windows.Forms.Padding(5);
			this.tbLoginPw.Multiline = false;
			this.tbLoginPw.Name = "tbLoginPw";
			this.tbLoginPw.Padding = new System.Windows.Forms.Padding(13, 9, 13, 9);
			this.tbLoginPw.PasswordChar = true;
			this.tbLoginPw.PlaceholderColor = System.Drawing.Color.DarkGray;
			this.tbLoginPw.PlaceholderText = "Jelszó";
			this.tbLoginPw.Size = new System.Drawing.Size(333, 39);
			this.tbLoginPw.TabIndex = 1;
			this.tbLoginPw.Texts = "Jelszó";
			this.tbLoginPw.UnderlinedStyle = false;
			this.tbLoginPw.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbLoginPw_KeyPress);
			// 
			// tbLoginUname
			// 
			this.tbLoginUname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(68)))));
			this.tbLoginUname.BorderColor = System.Drawing.Color.MediumSlateBlue;
			this.tbLoginUname.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(205)))), ((int)(((byte)(198)))));
			this.tbLoginUname.BorderRadius = 14;
			this.tbLoginUname.BorderSize = 2;
			this.tbLoginUname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.tbLoginUname.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.tbLoginUname.IsReadOnly = false;
			this.tbLoginUname.Location = new System.Drawing.Point(33, 208);
			this.tbLoginUname.Margin = new System.Windows.Forms.Padding(5);
			this.tbLoginUname.Multiline = false;
			this.tbLoginUname.Name = "tbLoginUname";
			this.tbLoginUname.Padding = new System.Windows.Forms.Padding(13, 9, 13, 9);
			this.tbLoginUname.PasswordChar = false;
			this.tbLoginUname.PlaceholderColor = System.Drawing.Color.DarkGray;
			this.tbLoginUname.PlaceholderText = "Felhasználónév";
			this.tbLoginUname.Size = new System.Drawing.Size(333, 39);
			this.tbLoginUname.TabIndex = 0;
			this.tbLoginUname.Texts = "Felhasználónév";
			this.tbLoginUname.UnderlinedStyle = false;
			this.tbLoginUname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbLoginUname_KeyPress);
			// 
			// LoginForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(68)))));
			this.ClientSize = new System.Drawing.Size(400, 554);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.button_CloseLoginForm);
			this.Controls.Add(this.customButton1);
			this.Controls.Add(this.tbLoginPw);
			this.Controls.Add(this.tbLoginUname);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "LoginForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "LoginForm";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private CustomTextbox tbLoginUname;
        private CustomTextbox tbLoginPw;
        private CustomButton customButton1;
        private CustomButton button_CloseLoginForm;
        private System.Windows.Forms.Label label1;
    }
}