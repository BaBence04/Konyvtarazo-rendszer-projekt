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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.lbUname = new System.Windows.Forms.Label();
            this.cbtnChangePass = new Desktop.CustomButton();
            this.ctbOldPass = new Desktop.CustomTextbox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.ctbNewPass = new Desktop.CustomTextbox();
            this.label8 = new System.Windows.Forms.Label();
            this.ctbNewPassAgain = new Desktop.CustomTextbox();
            this.cbtnDeleteEmpl = new Desktop.CustomButton();
            this.cbtnLogout = new Desktop.CustomButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Név";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Felhasználónév";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(53, 54);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(29, 13);
            this.lbName.TabIndex = 2;
            this.lbName.Text = "label";
            // 
            // lbUname
            // 
            this.lbUname.AutoSize = true;
            this.lbUname.Location = new System.Drawing.Point(53, 117);
            this.lbUname.Name = "lbUname";
            this.lbUname.Size = new System.Drawing.Size(29, 13);
            this.lbUname.TabIndex = 3;
            this.lbUname.Text = "label";
            // 
            // cbtnChangePass
            // 
            this.cbtnChangePass.BackColor = System.Drawing.Color.Black;
            this.cbtnChangePass.BorderColor = System.Drawing.Color.White;
            this.cbtnChangePass.BorderRadius = 40;
            this.cbtnChangePass.BorderSize = 0;
            this.cbtnChangePass.FlatAppearance.BorderSize = 0;
            this.cbtnChangePass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbtnChangePass.ForeColor = System.Drawing.Color.White;
            this.cbtnChangePass.Location = new System.Drawing.Point(33, 379);
            this.cbtnChangePass.Name = "cbtnChangePass";
            this.cbtnChangePass.Size = new System.Drawing.Size(150, 40);
            this.cbtnChangePass.TabIndex = 4;
            this.cbtnChangePass.Text = "Változtat";
            this.cbtnChangePass.UseVisualStyleBackColor = false;
            this.cbtnChangePass.Click += new System.EventHandler(this.cbtnChangePass_Click);
            // 
            // ctbOldPass
            // 
            this.ctbOldPass.BackColor = System.Drawing.SystemColors.Window;
            this.ctbOldPass.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.ctbOldPass.BorderFocusColor = System.Drawing.Color.HotPink;
            this.ctbOldPass.BorderRadius = 0;
            this.ctbOldPass.BorderSize = 2;
            this.ctbOldPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ctbOldPass.ForeColor = System.Drawing.Color.DimGray;
            this.ctbOldPass.IsReadOnly = false;
            this.ctbOldPass.Location = new System.Drawing.Point(33, 205);
            this.ctbOldPass.Margin = new System.Windows.Forms.Padding(4);
            this.ctbOldPass.Multiline = false;
            this.ctbOldPass.Name = "ctbOldPass";
            this.ctbOldPass.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.ctbOldPass.PasswordChar = true;
            this.ctbOldPass.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.ctbOldPass.PlaceholderText = "";
            this.ctbOldPass.Size = new System.Drawing.Size(157, 31);
            this.ctbOldPass.TabIndex = 5;
            this.ctbOldPass.Texts = "";
            this.ctbOldPass.UnderlinedStyle = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Jelszó megváltoztatása";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 188);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Régi jelszó";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(30, 254);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Új jelszó";
            // 
            // ctbNewPass
            // 
            this.ctbNewPass.BackColor = System.Drawing.SystemColors.Window;
            this.ctbNewPass.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.ctbNewPass.BorderFocusColor = System.Drawing.Color.HotPink;
            this.ctbNewPass.BorderRadius = 0;
            this.ctbNewPass.BorderSize = 2;
            this.ctbNewPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ctbNewPass.ForeColor = System.Drawing.Color.DimGray;
            this.ctbNewPass.IsReadOnly = false;
            this.ctbNewPass.Location = new System.Drawing.Point(33, 271);
            this.ctbNewPass.Margin = new System.Windows.Forms.Padding(4);
            this.ctbNewPass.Multiline = false;
            this.ctbNewPass.Name = "ctbNewPass";
            this.ctbNewPass.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.ctbNewPass.PasswordChar = true;
            this.ctbNewPass.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.ctbNewPass.PlaceholderText = "";
            this.ctbNewPass.Size = new System.Drawing.Size(157, 31);
            this.ctbNewPass.TabIndex = 8;
            this.ctbNewPass.Texts = "";
            this.ctbNewPass.UnderlinedStyle = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(30, 314);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Új jelszó ismétlése";
            // 
            // ctbNewPassAgain
            // 
            this.ctbNewPassAgain.BackColor = System.Drawing.SystemColors.Window;
            this.ctbNewPassAgain.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.ctbNewPassAgain.BorderFocusColor = System.Drawing.Color.HotPink;
            this.ctbNewPassAgain.BorderRadius = 0;
            this.ctbNewPassAgain.BorderSize = 2;
            this.ctbNewPassAgain.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ctbNewPassAgain.ForeColor = System.Drawing.Color.DimGray;
            this.ctbNewPassAgain.IsReadOnly = false;
            this.ctbNewPassAgain.Location = new System.Drawing.Point(33, 331);
            this.ctbNewPassAgain.Margin = new System.Windows.Forms.Padding(4);
            this.ctbNewPassAgain.Multiline = false;
            this.ctbNewPassAgain.Name = "ctbNewPassAgain";
            this.ctbNewPassAgain.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.ctbNewPassAgain.PasswordChar = true;
            this.ctbNewPassAgain.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.ctbNewPassAgain.PlaceholderText = "";
            this.ctbNewPassAgain.Size = new System.Drawing.Size(157, 31);
            this.ctbNewPassAgain.TabIndex = 10;
            this.ctbNewPassAgain.Texts = "";
            this.ctbNewPassAgain.UnderlinedStyle = false;
            // 
            // cbtnDeleteEmpl
            // 
            this.cbtnDeleteEmpl.BackColor = System.Drawing.Color.Black;
            this.cbtnDeleteEmpl.BorderColor = System.Drawing.Color.White;
            this.cbtnDeleteEmpl.BorderRadius = 40;
            this.cbtnDeleteEmpl.BorderSize = 0;
            this.cbtnDeleteEmpl.FlatAppearance.BorderSize = 0;
            this.cbtnDeleteEmpl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbtnDeleteEmpl.ForeColor = System.Drawing.Color.White;
            this.cbtnDeleteEmpl.Location = new System.Drawing.Point(355, 27);
            this.cbtnDeleteEmpl.Name = "cbtnDeleteEmpl";
            this.cbtnDeleteEmpl.Size = new System.Drawing.Size(150, 52);
            this.cbtnDeleteEmpl.TabIndex = 12;
            this.cbtnDeleteEmpl.Text = "Alkalmazott végleges deaktiválása";
            this.cbtnDeleteEmpl.UseVisualStyleBackColor = false;
            // 
            // cbtnLogout
            // 
            this.cbtnLogout.BackColor = System.Drawing.Color.Black;
            this.cbtnLogout.BorderColor = System.Drawing.Color.White;
            this.cbtnLogout.BorderRadius = 40;
            this.cbtnLogout.BorderSize = 0;
            this.cbtnLogout.FlatAppearance.BorderSize = 0;
            this.cbtnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbtnLogout.ForeColor = System.Drawing.Color.White;
            this.cbtnLogout.Location = new System.Drawing.Point(355, 379);
            this.cbtnLogout.Name = "cbtnLogout";
            this.cbtnLogout.Size = new System.Drawing.Size(150, 40);
            this.cbtnLogout.TabIndex = 13;
            this.cbtnLogout.Text = "Kijelentkezés";
            this.cbtnLogout.UseVisualStyleBackColor = false;
            this.cbtnLogout.Click += new System.EventHandler(this.cbtnLogout_Click);
            // 
            // EmployeeDetailedPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 450);
            this.Controls.Add(this.cbtnLogout);
            this.Controls.Add(this.cbtnDeleteEmpl);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.ctbNewPassAgain);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.ctbNewPass);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ctbOldPass);
            this.Controls.Add(this.cbtnChangePass);
            this.Controls.Add(this.lbUname);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "EmployeeDetailedPage";
            this.Text = "EmployeeDetailedPage";
            this.Load += new System.EventHandler(this.EmployeeDetailedPage_Load);
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
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private CustomTextbox ctbNewPass;
        private System.Windows.Forms.Label label8;
        private CustomTextbox ctbNewPassAgain;
        private CustomButton cbtnDeleteEmpl;
        private CustomButton cbtnLogout;
    }
}