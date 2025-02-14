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
            this.label1 = new System.Windows.Forms.Label();
            this.ctbEmplName = new Desktop.CustomTextbox();
            this.cbtnAdd = new Desktop.CustomButton();
            this.ctbEmplPass = new Desktop.CustomTextbox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbtnBack = new Desktop.CustomButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Név";
            // 
            // ctbEmplName
            // 
            this.ctbEmplName.BackColor = System.Drawing.SystemColors.Window;
            this.ctbEmplName.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.ctbEmplName.BorderFocusColor = System.Drawing.Color.HotPink;
            this.ctbEmplName.BorderRadius = 0;
            this.ctbEmplName.BorderSize = 2;
            this.ctbEmplName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ctbEmplName.ForeColor = System.Drawing.Color.DimGray;
            this.ctbEmplName.IsReadOnly = false;
            this.ctbEmplName.Location = new System.Drawing.Point(13, 42);
            this.ctbEmplName.Margin = new System.Windows.Forms.Padding(4);
            this.ctbEmplName.Multiline = false;
            this.ctbEmplName.Name = "ctbEmplName";
            this.ctbEmplName.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.ctbEmplName.PasswordChar = false;
            this.ctbEmplName.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.ctbEmplName.PlaceholderText = "";
            this.ctbEmplName.Size = new System.Drawing.Size(237, 31);
            this.ctbEmplName.TabIndex = 1;
            this.ctbEmplName.Texts = "";
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
            this.cbtnAdd.Location = new System.Drawing.Point(62, 180);
            this.cbtnAdd.Name = "cbtnAdd";
            this.cbtnAdd.Size = new System.Drawing.Size(140, 40);
            this.cbtnAdd.TabIndex = 2;
            this.cbtnAdd.Text = "Hozzáad";
            this.cbtnAdd.UseVisualStyleBackColor = false;
            this.cbtnAdd.Click += new System.EventHandler(this.cbtnAdd_Click);
            // 
            // ctbEmplPass
            // 
            this.ctbEmplPass.BackColor = System.Drawing.SystemColors.Window;
            this.ctbEmplPass.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.ctbEmplPass.BorderFocusColor = System.Drawing.Color.HotPink;
            this.ctbEmplPass.BorderRadius = 0;
            this.ctbEmplPass.BorderSize = 2;
            this.ctbEmplPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ctbEmplPass.ForeColor = System.Drawing.Color.DimGray;
            this.ctbEmplPass.IsReadOnly = false;
            this.ctbEmplPass.Location = new System.Drawing.Point(13, 129);
            this.ctbEmplPass.Margin = new System.Windows.Forms.Padding(4);
            this.ctbEmplPass.Multiline = false;
            this.ctbEmplPass.Name = "ctbEmplPass";
            this.ctbEmplPass.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.ctbEmplPass.PasswordChar = true;
            this.ctbEmplPass.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.ctbEmplPass.PlaceholderText = "";
            this.ctbEmplPass.Size = new System.Drawing.Size(237, 31);
            this.ctbEmplPass.TabIndex = 4;
            this.ctbEmplPass.Texts = "";
            this.ctbEmplPass.UnderlinedStyle = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Jelszó";
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
            this.cbtnBack.Location = new System.Drawing.Point(62, 226);
            this.cbtnBack.Name = "cbtnBack";
            this.cbtnBack.Size = new System.Drawing.Size(140, 40);
            this.cbtnBack.TabIndex = 5;
            this.cbtnBack.Text = "Vissza";
            this.cbtnBack.UseVisualStyleBackColor = false;
            this.cbtnBack.Click += new System.EventHandler(this.cbtnBack_Click);
            // 
            // AddEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(275, 277);
            this.Controls.Add(this.cbtnBack);
            this.Controls.Add(this.ctbEmplPass);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbtnAdd);
            this.Controls.Add(this.ctbEmplName);
            this.Controls.Add(this.label1);
            this.Name = "AddEmployee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alkalmazott hozzáadása";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private CustomTextbox ctbEmplName;
        private CustomButton cbtnAdd;
        private CustomTextbox ctbEmplPass;
        private System.Windows.Forms.Label label2;
        private CustomButton cbtnBack;
    }
}