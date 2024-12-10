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
            this.button_CloseLoginForm = new Desktop.CustomButton();
            this.customButton1 = new Desktop.CustomButton();
            this.customTextbox2 = new Desktop.CustomTextbox();
            this.customTextbox1 = new Desktop.CustomTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
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
            // 
            // customTextbox2
            // 
            this.customTextbox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(68)))));
            this.customTextbox2.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.customTextbox2.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(205)))), ((int)(((byte)(198)))));
            this.customTextbox2.BorderRadius = 14;
            this.customTextbox2.BorderSize = 2;
            this.customTextbox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.customTextbox2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.customTextbox2.Location = new System.Drawing.Point(25, 240);
            this.customTextbox2.Margin = new System.Windows.Forms.Padding(4);
            this.customTextbox2.Multiline = false;
            this.customTextbox2.Name = "customTextbox2";
            this.customTextbox2.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.customTextbox2.PasswordChar = true;
            this.customTextbox2.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.customTextbox2.PlaceholderText = "Jelszó";
            this.customTextbox2.Size = new System.Drawing.Size(250, 31);
            this.customTextbox2.TabIndex = 1;
            this.customTextbox2.Texts = "Jelszó";
            this.customTextbox2.UnderlinedStyle = false;
            // 
            // customTextbox1
            // 
            this.customTextbox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(68)))));
            this.customTextbox1.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.customTextbox1.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(205)))), ((int)(((byte)(198)))));
            this.customTextbox1.BorderRadius = 14;
            this.customTextbox1.BorderSize = 2;
            this.customTextbox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.customTextbox1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.customTextbox1.Location = new System.Drawing.Point(25, 169);
            this.customTextbox1.Margin = new System.Windows.Forms.Padding(4);
            this.customTextbox1.Multiline = false;
            this.customTextbox1.Name = "customTextbox1";
            this.customTextbox1.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.customTextbox1.PasswordChar = false;
            this.customTextbox1.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.customTextbox1.PlaceholderText = "E-mail";
            this.customTextbox1.Size = new System.Drawing.Size(250, 31);
            this.customTextbox1.TabIndex = 0;
            this.customTextbox1.Texts = "E-mail";
            this.customTextbox1.UnderlinedStyle = false;
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
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(68)))));
            this.ClientSize = new System.Drawing.Size(300, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_CloseLoginForm);
            this.Controls.Add(this.customButton1);
            this.Controls.Add(this.customTextbox2);
            this.Controls.Add(this.customTextbox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomTextbox customTextbox1;
        private CustomTextbox customTextbox2;
        private CustomButton customButton1;
        private CustomButton button_CloseLoginForm;
        private System.Windows.Forms.Label label1;
    }
}