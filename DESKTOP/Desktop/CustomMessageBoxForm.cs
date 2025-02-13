using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desktop
{
	public partial class CustomMessageBoxForm : Form
	{
		private Color primaryColor = Color.CornflowerBlue;
		private Color secondaryColor = Color.LightSteelBlue;
		private int borderSize = 2;


		public Color PrimaryColor
		{
			get { return primaryColor; }
			set
			{
				primaryColor = value;
				this.BackColor = secondaryColor;
				this.panelTitleBar.BackColor = PrimaryColor;
			}
		}


		public CustomMessageBoxForm(string text)
		{
			InitializeComponent();
			InitializeItems();
			this.PrimaryColor = primaryColor;
			this.labelMessage.Text = text;
			this.labelCaption.Text = "";
			SetButtons(MessageBoxButtons.OK, MessageBoxDefaultButton.Button1);
		}
		public CustomMessageBoxForm(string text, string caption)
		{
			InitializeComponent();
			InitializeItems();
			this.PrimaryColor = primaryColor;
			this.labelMessage.Text = text;
			this.labelCaption.Text = caption;
			SetButtons(MessageBoxButtons.OK, MessageBoxDefaultButton.Button1);
		}
		public CustomMessageBoxForm(string text, string caption, MessageBoxButtons buttons)
		{
			InitializeComponent();
			InitializeItems();
			this.PrimaryColor = primaryColor;
			this.labelMessage.Text = text;
			this.labelCaption.Text = caption;
			SetButtons(buttons, MessageBoxDefaultButton.Button1);
		}
		public CustomMessageBoxForm(string text, string caption, MessageBoxButtons buttons, MessageBoxIcon icon)
		{
			InitializeComponent();
			InitializeItems();
			this.PrimaryColor = primaryColor;
			this.labelMessage.Text = text;
			this.labelCaption.Text = caption;
			SetButtons(buttons, MessageBoxDefaultButton.Button1);
		}
		public CustomMessageBoxForm(string text, string caption, MessageBoxButtons buttons, MessageBoxIcon icon, MessageBoxDefaultButton defaultButton)
		{
			InitializeComponent();
			InitializeItems();
			this.PrimaryColor = primaryColor;
			this.labelMessage.Text = text;
			this.labelCaption.Text = caption;
			SetButtons(buttons, defaultButton);

		}



		private void InitializeItems()
		{
			this.FormBorderStyle = FormBorderStyle.None;
			this.Padding = new Padding(borderSize);
			this.labelMessage.MaximumSize = new Size(550, 0);
			this.button1.Visible = false;
			this.button2.Visible = false;
			this.button3.Visible = false;
		}
		private void SetButtons(MessageBoxButtons buttons, MessageBoxDefaultButton defaultButton)
		{
			switch (buttons)
			{
				case MessageBoxButtons.OK:
					button1.Visible = true;
					button1.Text = "OK";
					button1.DialogResult = DialogResult.OK;

					SetDefaultButton(defaultButton);
					break;

				case MessageBoxButtons.YesNoCancel:
					button1.Visible = true;
					button1.Text = "Igen";
					button1.DialogResult = DialogResult.Yes;
					button1.BackColor = Color.ForestGreen;

					button2.Visible = true;
					button2.Text = "Nem";
					button2.DialogResult = DialogResult.No;
					button2.BackColor = Color.IndianRed;

					button3.Visible = true;
					button3.Text = "Mégsem";
					button3.DialogResult = DialogResult.Cancel;
					button3.BackColor = Color.DimGray;

					SetDefaultButton(defaultButton);
					break;

				case MessageBoxButtons.YesNo:
					button1.Visible = true;
					button1.Text = "Igen";
					button1.DialogResult = DialogResult.Yes;

					button2.Visible = true;
					button2.Text = "Nem";
					button2.DialogResult = DialogResult.No;
					button2.BackColor = Color.IndianRed;

					if (defaultButton != MessageBoxDefaultButton.Button3)
						SetDefaultButton(defaultButton);
					else SetDefaultButton(MessageBoxDefaultButton.Button1);
					break;
			}
		}
		private void SetDefaultButton(MessageBoxDefaultButton defaultButton)
		{
			switch (defaultButton)
			{
				case MessageBoxDefaultButton.Button1:
					button1.Select();
					button1.ForeColor = Color.White;
					button1.Font = new Font(button1.Font, FontStyle.Underline);
					break;
				case MessageBoxDefaultButton.Button2:
					button2.Select();
					button2.ForeColor = Color.White;
					button2.Font = new Font(button2.Font, FontStyle.Underline);
					break;
				case MessageBoxDefaultButton.Button3:
					button3.Select();
					button3.ForeColor = Color.White;
					button3.Font = new Font(button3.Font, FontStyle.Underline);
					break;
			}
		}
	}
}
