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
            this.label1.Location = new System.Drawing.Point(59, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "BEJELENTKEZÉS";
            // 
            // button_CloseLoginForm
            // 
            this.button_CloseLoginForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(68)))));
            this.button_CloseLoginForm.BorderColor = System.Drawing.Color.White;
            this.button_CloseLoginForm.BorderRadius = 40;
            this.button_CloseLoginForm.BorderSize = 0;
            this.button_CloseLoginForm.FlatAppearance.BorderSize = 0;
            this.button_CloseLoginForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_CloseLoginForm.ForeColor = System.Drawing.Color.White;
            this.button_CloseLoginForm.Location = new System.Drawing.Point(259, 1);
            this.button_CloseLoginForm.Name = "button_CloseLoginForm";
            this.button_CloseLoginForm.Size = new System.Drawing.Size(40, 40);
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
            this.customButton1.FlatAppearance.BorderSize = 0;
            this.customButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customButton1.ForeColor = System.Drawing.Color.White;
            this.customButton1.Location = new System.Drawing.Point(73, 368);
            this.customButton1.Name = "customButton1";
            this.customButton1.Size = new System.Drawing.Size(150, 31);
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
            this.tbLoginPw.Location = new System.Drawing.Point(25, 240);
            this.tbLoginPw.Margin = new System.Windows.Forms.Padding(4);
            this.tbLoginPw.Multiline = false;
            this.tbLoginPw.Name = "tbLoginPw";
            this.tbLoginPw.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.tbLoginPw.PasswordChar = true;
            this.tbLoginPw.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tbLoginPw.PlaceholderText = "Jelszó";
            this.tbLoginPw.Size = new System.Drawing.Size(250, 31);
            this.tbLoginPw.TabIndex = 1;
            this.tbLoginPw.Texts = "Jelszó";
            this.tbLoginPw.UnderlinedStyle = false;
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
            this.tbLoginUname.Location = new System.Drawing.Point(25, 169);
            this.tbLoginUname.Margin = new System.Windows.Forms.Padding(4);
            this.tbLoginUname.Multiline = false;
            this.tbLoginUname.Name = "tbLoginUname";
            this.tbLoginUname.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.tbLoginUname.PasswordChar = false;
            this.tbLoginUname.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tbLoginUname.PlaceholderText = "Felhasználónév";
            this.tbLoginUname.Size = new System.Drawing.Size(250, 31);
            this.tbLoginUname.TabIndex = 0;
            this.tbLoginUname.Texts = "Felhasználónév";
            this.tbLoginUname.UnderlinedStyle = false;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(68)))));
            this.ClientSize = new System.Drawing.Size(300, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_CloseLoginForm);
            this.Controls.Add(this.customButton1);
            this.Controls.Add(this.tbLoginPw);
            this.Controls.Add(this.tbLoginUname);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
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