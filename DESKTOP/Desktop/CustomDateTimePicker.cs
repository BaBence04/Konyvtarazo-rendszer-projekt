using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desktop
{
	internal class CustomDateTimePicker : DateTimePicker
	{
		private Color skinColor = Color.MediumSlateBlue;
		private Color textColor = Color.White;
		private Color borderColor = Color.PaleVioletRed;
		private int borderSize = 0;

		private bool droppedDown = false;
		private Image calendarIcon = Properties.Resources.calendarWhite;
		private RectangleF iconButtonArea;
		private const int calendarIconWidth = 34;
		private const int arrowIconWidth = 17;


		public Color SkinColor
		{
			get { return skinColor; }
			set
			{
				skinColor = value;
				if (skinColor.GetBrightness() >= 0.8F)
					calendarIcon = Properties.Resources.calendarBlack;
				else calendarIcon = Properties.Resources.calendarWhite;
				this.Invalidate();
			}
		}

		public Color TextColor
		{
			get { return textColor; }
			set
			{
				textColor = value;
				this.Invalidate();
			}
		}

		public Color BorderColor
		{
			get { return borderColor; }
			set
			{
				borderColor = value;
				this.Invalidate();
			}
		}

		public int BorderSize
		{
			get { return borderSize; }
			set
			{
				borderSize = value;
				this.Invalidate();
			}
		}

		public CustomDateTimePicker()
		{
			this.SetStyle(ControlStyles.UserPaint, true);
			this.MinimumSize = new Size(0, 35);
			this.Font = new Font(this.Font.Name, 9.5F);
		}

		private int borderRadius = 10;

		public int BorderRadius
		{
			get { return borderRadius; }
			set
			{
				if (value >= 0)
				{
					borderRadius = value;
					this.Invalidate();
				}
			}
		}



		protected override void OnDropDown(EventArgs eventargs)
		{
			base.OnDropDown(eventargs);
			droppedDown = true;
		}
		protected override void OnCloseUp(EventArgs eventargs)
		{
			base.OnCloseUp(eventargs);
			droppedDown = false;
		}
		protected override void OnKeyPress(KeyPressEventArgs e)
		{
			base.OnKeyPress(e);
			e.Handled = true;
		}
		/*protected override void OnPaint(PaintEventArgs e)
		{
			using (Graphics graphics = this.CreateGraphics())
			using (Pen penBorder = new Pen(borderColor, borderSize))
			using (SolidBrush skinBrush = new SolidBrush(skinColor))
			using (SolidBrush openIconBrush = new SolidBrush(Color.FromArgb(50, 64, 64, 64)))
			using (SolidBrush textBrush = new SolidBrush(textColor))
			using (StringFormat textFormat = new StringFormat())
			{
				RectangleF clientArea = new RectangleF(0, 0, this.Width - 0.5F, this.Height - 0.5F);
				RectangleF iconArea = new RectangleF(clientArea.Width - calendarIconWidth, 0, calendarIconWidth, clientArea.Height);
				penBorder.Alignment = PenAlignment.Inset;
				textFormat.LineAlignment = StringAlignment.Center;


				graphics.FillRectangle(skinBrush, clientArea);

				graphics.DrawString("   " + this.Text, this.Font, textBrush, clientArea, textFormat);
				if (droppedDown == true) graphics.FillRectangle(openIconBrush, iconArea);
				if (borderSize >= 1) graphics.DrawRectangle(penBorder, clientArea.X, clientArea.Y, clientArea.Width, clientArea.Height);

				graphics.DrawImage(calendarIcon, this.Width - calendarIcon.Width - 9, (this.Height - calendarIcon.Height) / 2);

			}
		}*/


		protected override void OnPaint(PaintEventArgs e)
		{
			using (Graphics graphics = e.Graphics)
			using (Pen penBorder = new Pen(borderColor, borderSize))
			using (SolidBrush skinBrush = new SolidBrush(skinColor))
			using (SolidBrush openIconBrush = new SolidBrush(Color.FromArgb(50, 64, 64, 64)))
			using (SolidBrush textBrush = new SolidBrush(textColor))
			using (StringFormat textFormat = new StringFormat())
			{
				graphics.SmoothingMode = SmoothingMode.AntiAlias;

				RectangleF clientArea = new RectangleF(0, 0, this.Width - 1F, this.Height - 1F);
				RectangleF iconArea = new RectangleF(clientArea.Width - calendarIconWidth, 0, calendarIconWidth, clientArea.Height);

				using (GraphicsPath roundedPath = GetRoundedRectanglePath(clientArea, borderRadius))
				{
					graphics.FillPath(skinBrush, roundedPath);

					if (borderSize >= 1)
						graphics.DrawPath(penBorder, roundedPath);
				}

				textFormat.LineAlignment = StringAlignment.Center;
				graphics.DrawString("   " + this.Text, this.Font, textBrush, clientArea, textFormat);

				if (droppedDown)
					graphics.FillRectangle(openIconBrush, iconArea);

				graphics.DrawImage(calendarIcon, this.Width - calendarIcon.Width - 9, (this.Height - calendarIcon.Height) / 2);
			}
		}





		protected override void OnHandleCreated(EventArgs e)
		{
			base.OnHandleCreated(e);
			int iconWidth = GetIconButtonWidth();
			iconButtonArea = new RectangleF(this.Width - iconWidth, 0, iconWidth, this.Height);
		}
		protected override void OnMouseMove(MouseEventArgs e)
		{
			base.OnMouseMove(e);
			if (iconButtonArea.Contains(e.Location))
				this.Cursor = Cursors.Hand;
			else this.Cursor = Cursors.Default;
		}






		private int GetIconButtonWidth()
		{
			int textWidh = TextRenderer.MeasureText(this.Text, this.Font).Width;
			if (textWidh <= this.Width - (calendarIconWidth + 20))
				return calendarIconWidth;
			else return arrowIconWidth;
		}

		private GraphicsPath GetRoundedRectanglePath(RectangleF rect, int radius)
		{
			GraphicsPath path = new GraphicsPath();
			float r = radius * 2F;
			path.StartFigure();
			path.AddArc(rect.X, rect.Y, r, r, 180, 90);
			path.AddArc(rect.Right - r, rect.Y, r, r, 270, 90);
			path.AddArc(rect.Right - r, rect.Bottom - r, r, r, 0, 90);
			path.AddArc(rect.X, rect.Bottom - r, r, r, 90, 90);
			path.CloseFigure();
			return path;
		}
	}
}
