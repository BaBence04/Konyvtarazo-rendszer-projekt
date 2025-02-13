namespace Desktop
{
	partial class CustomMessageBoxForm
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
			this.panelTitleBar = new System.Windows.Forms.Panel();
			this.labelCaption = new System.Windows.Forms.Label();
			this.panelButtons = new System.Windows.Forms.Panel();
			this.labelMessage = new System.Windows.Forms.Label();
			this.button1 = new Desktop.CustomButton();
			this.button2 = new Desktop.CustomButton();
			this.button3 = new Desktop.CustomButton();
			this.panelTitleBar.SuspendLayout();
			this.panelButtons.SuspendLayout();
			this.SuspendLayout();
			// 
			// panelTitleBar
			// 
			this.panelTitleBar.BackColor = System.Drawing.Color.CornflowerBlue;
			this.panelTitleBar.Controls.Add(this.labelCaption);
			this.panelTitleBar.Location = new System.Drawing.Point(-1, 0);
			this.panelTitleBar.Margin = new System.Windows.Forms.Padding(4);
			this.panelTitleBar.Name = "panelTitleBar";
			this.panelTitleBar.Size = new System.Drawing.Size(568, 47);
			this.panelTitleBar.TabIndex = 1;
			// 
			// labelCaption
			// 
			this.labelCaption.AutoSize = true;
			this.labelCaption.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.labelCaption.Location = new System.Drawing.Point(17, 17);
			this.labelCaption.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.labelCaption.Name = "labelCaption";
			this.labelCaption.Size = new System.Drawing.Size(59, 20);
			this.labelCaption.TabIndex = 0;
			this.labelCaption.Text = "label1";
			// 
			// panelButtons
			// 
			this.panelButtons.Controls.Add(this.button3);
			this.panelButtons.Controls.Add(this.button2);
			this.panelButtons.Controls.Add(this.button1);
			this.panelButtons.Location = new System.Drawing.Point(19, 180);
			this.panelButtons.Margin = new System.Windows.Forms.Padding(4);
			this.panelButtons.Name = "panelButtons";
			this.panelButtons.Size = new System.Drawing.Size(529, 101);
			this.panelButtons.TabIndex = 6;
			// 
			// labelMessage
			// 
			this.labelMessage.AutoSize = true;
			this.labelMessage.Location = new System.Drawing.Point(73, 93);
			this.labelMessage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.labelMessage.Name = "labelMessage";
			this.labelMessage.Size = new System.Drawing.Size(44, 16);
			this.labelMessage.TabIndex = 7;
			this.labelMessage.Text = "label2";
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.Black;
			this.button1.BorderColor = System.Drawing.Color.White;
			this.button1.BorderRadius = 40;
			this.button1.BorderSize = 0;
			this.button1.FlatAppearance.BorderSize = 0;
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.ForeColor = System.Drawing.Color.White;
			this.button1.Location = new System.Drawing.Point(43, 30);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(120, 40);
			this.button1.TabIndex = 8;
			this.button1.Text = "button1";
			this.button1.UseVisualStyleBackColor = false;
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.Color.Black;
			this.button2.BorderColor = System.Drawing.Color.White;
			this.button2.BorderRadius = 40;
			this.button2.BorderSize = 0;
			this.button2.FlatAppearance.BorderSize = 0;
			this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button2.ForeColor = System.Drawing.Color.White;
			this.button2.Location = new System.Drawing.Point(205, 30);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(120, 40);
			this.button2.TabIndex = 9;
			this.button2.Text = "button2";
			this.button2.UseVisualStyleBackColor = false;
			// 
			// button3
			// 
			this.button3.BackColor = System.Drawing.Color.Black;
			this.button3.BorderColor = System.Drawing.Color.White;
			this.button3.BorderRadius = 40;
			this.button3.BorderSize = 0;
			this.button3.FlatAppearance.BorderSize = 0;
			this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button3.ForeColor = System.Drawing.Color.White;
			this.button3.Location = new System.Drawing.Point(368, 30);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(120, 40);
			this.button3.TabIndex = 10;
			this.button3.Text = "button3";
			this.button3.UseVisualStyleBackColor = false;
			// 
			// CustomMessagseBoxForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.LightSteelBlue;
			this.ClientSize = new System.Drawing.Size(567, 284);
			this.Controls.Add(this.labelMessage);
			this.Controls.Add(this.panelButtons);
			this.Controls.Add(this.panelTitleBar);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "CustomMessagseBoxForm";
			this.Text = "CustomMessagseBoxForm";
			this.panelTitleBar.ResumeLayout(false);
			this.panelTitleBar.PerformLayout();
			this.panelButtons.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel panelTitleBar;
		private System.Windows.Forms.Label labelCaption;
		private System.Windows.Forms.Panel panelButtons;
		private System.Windows.Forms.Label labelMessage;
		private CustomButton button3;
		private CustomButton button2;
		private CustomButton button1;
	}
}