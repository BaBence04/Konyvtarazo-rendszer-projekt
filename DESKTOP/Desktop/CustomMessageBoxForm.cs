using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desktop
{
	public partial class CustomMessageBoxForm : Form
	{
		private Color primaryColor = Color.FromArgb(40, 40, 50);
		private Color secondaryColor = Color.FromArgb(40, 40, 50);
		

        private int borderRadius = 20;
        private int borderSize = 2;
        private Color borderColor = Color.FromArgb(128, 128, 255);


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

		public CustomMessageBoxForm(string text, string caption, bool noButtons)
		{
			InitializeComponent();
			InitializeItems();
			this.PrimaryColor = primaryColor;
			this.labelMessage.Text = text;
			this.labelCaption.Text = caption;

			if (noButtons)
			{
				this.button1.Visible = false;
				this.button2.Visible = false;
				this.button3.Visible = false;
			}
			else
			{
				SetButtons(MessageBoxButtons.OK, MessageBoxDefaultButton.Button1);
			}
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
					button1.BackColor = Color.FromArgb(79, 81, 140);

					button2.Visible = true;
					button2.Text = "Nem";
					button2.DialogResult = DialogResult.No;
					button2.BackColor = Color.FromArgb(79, 81, 140);

                    button3.Visible = true;
					button3.Text = "Mégsem";
					button3.DialogResult = DialogResult.Cancel;
					button3.BackColor = Color.FromArgb(79, 81, 140);

                    SetDefaultButton(defaultButton);
					break;

				case MessageBoxButtons.YesNo:
					button1.Visible = true;
					button1.Text = "Igen";
					button1.DialogResult = DialogResult.Yes;

					button2.Visible = true;
					button2.Text = "Nem";
					button2.DialogResult = DialogResult.No;
					button2.BackColor = Color.FromArgb(79, 81, 140);

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


        //Get rounded form///


        /*private GraphicsPath GetRoundedPath(Rectangle rect, float radius)
        {
            GraphicsPath path = new GraphicsPath();
            float curveSize = radius * 2F;

            path.StartFigure();
            path.AddArc(rect.X, rect.Y, curveSize, curveSize, 180, 90);
            path.AddArc(rect.Right - curveSize, rect.Y, curveSize, curveSize, 270, 90);
            path.AddArc(rect.Right - curveSize, rect.Bottom - curveSize, curveSize, curveSize, 0, 90);
            path.AddArc(rect.X, rect.Bottom - curveSize, curveSize, curveSize, 90, 90);
            path.CloseFigure();
            return path;
        }

        private void FormRegionAndBorder(Form form, float radius, Graphics graph, Color borderColor, float borderSize)
        {
            if (this.WindowState != FormWindowState.Minimized)
            {
                using (GraphicsPath roundPath = GetRoundedPath(form.ClientRectangle, radius))
                using (Pen penBorder = new Pen(borderColor, borderSize))
                using (Matrix transform = new Matrix())
                {
                    graph.SmoothingMode = SmoothingMode.AntiAlias;
                    form.Region = new Region(roundPath);
                    if (borderSize >= 1)
                    {
                        Rectangle rect = form.ClientRectangle;
                        float scaleX = 1.0F - ((borderSize + 1) / rect.Width);
                        float scaleY = 1.0F - ((borderSize + 1) / rect.Height);

                        transform.Scale(scaleX, scaleY);
                        transform.Translate(borderSize / 1.6F, borderSize / 1.6F);

                        graph.Transform = transform;
                        graph.DrawPath(penBorder, roundPath);
                    }
                }
            }
        }

        private void ControlRegionAndBorder(Control control, float radius, Graphics graph, Color borderColor)
        {
            using (GraphicsPath roundPath = GetRoundedPath(control.ClientRectangle, radius))
            using (Pen penBorder = new Pen(borderColor, 1))
            {
                graph.SmoothingMode = SmoothingMode.AntiAlias;
                control.Region = new Region(roundPath);
                graph.DrawPath(penBorder, roundPath);
            }
        }

        private void DrawPath(Rectangle rect, Graphics graph, Color color)
        {
            using (GraphicsPath roundPath = GetRoundedPath(rect, borderRadius))
            using (Pen penBorder = new Pen(color, 3))
            {
                graph.DrawPath(penBorder, roundPath);
            }
        }

        private struct FormBoundsColors
        {
            public Color TopLeftColor;
            public Color TopRightColor;
            public Color BottomLeftColor;
            public Color BottomRightColor;
        }
        private FormBoundsColors GetFormBoundsColors()
        {
            var fbColor = new FormBoundsColors();
            using (var bmp = new Bitmap(1, 1))
            using (Graphics graph = Graphics.FromImage(bmp))
            {
                Rectangle rectBmp = new Rectangle(0, 0, 1, 1);

                //Top Left
                rectBmp.X = this.Bounds.X - 1;
                rectBmp.Y = this.Bounds.Y;
                graph.CopyFromScreen(rectBmp.Location, Point.Empty, rectBmp.Size);
                fbColor.TopLeftColor = bmp.GetPixel(0, 0);

                //Top Right
                rectBmp.X = this.Bounds.Right;
                rectBmp.Y = this.Bounds.Y;
                graph.CopyFromScreen(rectBmp.Location, Point.Empty, rectBmp.Size);
                fbColor.TopRightColor = bmp.GetPixel(0, 0);

                //Bottom Left
                rectBmp.X = this.Bounds.X;
                rectBmp.Y = this.Bounds.Bottom;
                graph.CopyFromScreen(rectBmp.Location, Point.Empty, rectBmp.Size);
                fbColor.BottomLeftColor = bmp.GetPixel(0, 0);

                //Bottom Right
                rectBmp.X = this.Bounds.Right;
                rectBmp.Y = this.Bounds.Bottom;
                graph.CopyFromScreen(rectBmp.Location, Point.Empty, rectBmp.Size);
                fbColor.BottomRightColor = bmp.GetPixel(0, 0);
            }
            return fbColor;
        }


        private void CustomMessageBoxForm_Paint(object sender, PaintEventArgs e)
        {
            //-> SMOOTH OUTER BORDER
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            Rectangle rectForm = this.ClientRectangle;
            int mWidht = rectForm.Width / 2;
            int mHeight = rectForm.Height / 2;
            var fbColors = GetFormBoundsColors();

            //Top Left
            DrawPath(rectForm, e.Graphics, fbColors.TopLeftColor);

            //Top Right
            Rectangle rectTopRight = new Rectangle(mWidht, rectForm.Y, mWidht, mHeight);
            DrawPath(rectTopRight, e.Graphics, fbColors.TopRightColor);

            //Bottom Left
            Rectangle rectBottomLeft = new Rectangle(rectForm.X, rectForm.X + mHeight, mWidht, mHeight);
            DrawPath(rectBottomLeft, e.Graphics, fbColors.BottomLeftColor);

            //Bottom Right
            Rectangle rectBottomRight = new Rectangle(mWidht, rectForm.Y + mHeight, mWidht, mHeight);
            DrawPath(rectBottomRight, e.Graphics, fbColors.BottomRightColor);

            //-> SET ROUNDED REGION AND BORDER
            FormRegionAndBorder(this, borderRadius, e.Graphics, borderColor, borderSize);
        }*/
    }
}
