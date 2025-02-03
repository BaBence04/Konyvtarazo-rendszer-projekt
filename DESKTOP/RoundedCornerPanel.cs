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
	internal class RoundedCornerPanel : Panel
	{
		public int CornerRadius { get; set; } = 20;

		protected override void OnResize(EventArgs e)
		{
			base.OnResize(e);
			this.Invalidate();
		}


		protected override void OnPaint(PaintEventArgs e)
		{
			base.OnPaint(e);

			e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

			GraphicsPath path = new GraphicsPath();
			int radius = CornerRadius;

			path.AddArc(0, 0, radius * 2, radius * 2, 180, 90);

			path.AddLine(radius, 0, Width, 0);

			path.AddLine(Width, 0, Width, Height);

			path.AddLine(Width, Height, 0, Height);

			path.AddArc(0, Height - radius * 2, radius * 2, radius * 2, 90, 90);

			path.AddLine(0, Height - radius, 0, radius);

			this.Region = new Region(path);

		}
	}
}
