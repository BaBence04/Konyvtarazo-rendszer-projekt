using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desktop
{
	public static class FormDragger
	{
		private static bool _isDragging = false;
		private static Point _startPoint = Point.Empty;

		public static void MakeDraggable(Form form)
		{
			form.MouseDown += (sender, e) =>
			{
				if (e.Button == MouseButtons.Left)
				{
					_isDragging = true;
					_startPoint = new Point(e.X, e.Y);
				}
			};

			form.MouseMove += (sender, e) =>
			{
				if (_isDragging)
				{
					Point newPoint = form.PointToScreen(new Point(e.X, e.Y));
					form.Location = new Point(newPoint.X - _startPoint.X, newPoint.Y - _startPoint.Y);
				}
			};

			form.MouseUp += (sender, e) =>
			{
				if (e.Button == MouseButtons.Left)
				{
					_isDragging = false;
				}
			};
		}
	}
}
