using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using System.ComponentModel;
using System.Security.Policy;
using System.Runtime.CompilerServices;

namespace Desktop
{
	internal class CustomDataGridView : DataGridView
	{
		// properties for header
		private Color headerBackColor = Color.FromArgb(35, 35, 55);
		private Color headerForeColor = Color.WhiteSmoke;
		private bool useHeaderGradient = false;
		private Color headerGradientColor = Color.SlateBlue;

		//properties for cells
		private Color cellBackColor = Color.FromArgb(51, 51, 68);
		private Color cellForeColor = Color.WhiteSmoke;
		private Color alternatingRowBackColor = Color.FromArgb(71, 71, 88);

		// properties for border
		private bool enableBorder = false;
		private Color borderColor = Color.MediumSlateBlue;
		private int borderThickness = 2;

		// Properties for hover and selection
		private Color hoverRowColor = Color.LightSteelBlue;
		private Color selectedRowColor = Color.CornflowerBlue;

		// Properties for rounded corners
		private bool useRoundedCorners = false;
		private int cornerRadius = 8;

		// Header customization properties
		public Color HeaderBackColor
		{
			get => headerBackColor;
			set { headerBackColor = value; this.Invalidate(); }
		}
		public Color HeaderForeColor
		{
			get => headerForeColor;
			set { headerForeColor = value; this.Invalidate(); }
		}
		public bool UseHeaderGradient
		{
			get => useHeaderGradient;
			set { useHeaderGradient = value; this.Invalidate(); }
		}
		public Color HeaderGradientColor
		{
			get => headerGradientColor;
			set { headerGradientColor = value; this.Invalidate(); }
		}

		

		// Cell customization properties
		public Color CellBackColor
		{
			get => cellBackColor;
			set { cellBackColor = value; this.Invalidate(); }
		}
		public Color CellForeColor
		{
			get => cellForeColor;
			set { cellForeColor = value; this.Invalidate(); }
		}
		public Color AlternatingRowBackColor
		{
			get => alternatingRowBackColor;
			set { alternatingRowBackColor = value; this.Invalidate(); }
		}
		// Border customization properties
		public bool EnableBorder
		{
			get => enableBorder;
			set { enableBorder = value; this.Invalidate(); }
		}
		public Color BorderColor
		{
			get => borderColor;
			set { borderColor = value; this.Invalidate(); }
		}
		public int BorderThickness
		{
			get => borderThickness;
			set { borderThickness = value; this.Invalidate(); }
		}

		// Hover and selection properties
		public Color HoverRowColor
		{
			get => hoverRowColor;
			set { hoverRowColor = value; this.Invalidate(); }
		}
		public Color SelectedRowColor
		{
			get => selectedRowColor;
			set { selectedRowColor = value; this.Invalidate(); }
		}

		// Rounded corners properties
		public bool UseRoundedCorners
		{
			get => useRoundedCorners;
			set { useRoundedCorners = value; this.Invalidate(); }
		}
		public int CornerRadius
		{
			get => cornerRadius;
			set { cornerRadius = value; this.Invalidate(); }
		}

		public CustomDataGridView()
		{
			this.DoubleBuffered = true;
			this.EnableHeadersVisualStyles = false;
			this.BackgroundColor = Color.FromArgb(51, 51, 68);
			this.BorderStyle = BorderStyle.None;
			this.GridColor = this.BackgroundColor;
			this.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;

            // Apply styles
            ApplyStyles();
		}

		private void ApplyStyles()
		{
			// Header styles
			this.EnableHeadersVisualStyles = false;
			this.ColumnHeadersDefaultCellStyle.BackColor = headerBackColor;
			this.ColumnHeadersDefaultCellStyle.ForeColor = headerForeColor;
			this.ColumnHeadersDefaultCellStyle.Font = new Font(this.Font, FontStyle.Bold);
			this.ColumnHeadersHeight = 40;

			// Row header (first column) styles
			this.RowHeadersDefaultCellStyle.BackColor = headerBackColor;
			this.RowHeadersDefaultCellStyle.ForeColor = headerForeColor;
			this.RowHeadersDefaultCellStyle.SelectionBackColor = selectedRowColor;
			this.RowHeadersDefaultCellStyle.SelectionForeColor = headerForeColor;
			this.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;

			// Cell styles
			this.DefaultCellStyle.BackColor = cellBackColor;
			this.DefaultCellStyle.ForeColor = cellForeColor;
			this.DefaultCellStyle.SelectionBackColor = selectedRowColor;
			this.DefaultCellStyle.SelectionForeColor = Color.White;

			// Alternating row styles
			this.AlternatingRowsDefaultCellStyle.BackColor = alternatingRowBackColor;

			// Gridlines
			this.GridColor = cellBackColor; // Match your custom border color
			this.CellBorderStyle = DataGridViewCellBorderStyle.None;
		}


		protected override void OnPaint(PaintEventArgs e)
		{
			base.OnPaint(e);

			// Draw custom border if enabled
			if (enableBorder)
			{
				using (Pen borderPen = new Pen(borderColor, borderThickness))
				{
					Rectangle rect = this.ClientRectangle;

					// Ensure the rectangle is valid
					if (rect.Width > 0 && rect.Height > 0)
					{
						rect.Width -= borderThickness;
						rect.Height -= borderThickness;
						e.Graphics.DrawRectangle(borderPen, rect);
					}
				}
			}
		}

		private bool IsInDesignMode()
		{
			return LicenseManager.UsageMode == LicenseUsageMode.Designtime;
		}



		protected override void OnCellPainting(DataGridViewCellPaintingEventArgs e)
		{

			if (IsInDesignMode())
			{
				base.OnCellPainting(e);
				return;
			}

			base.OnCellPainting(e);

			if (e.CellStyle == null || e.FormattedValue == null)
				return;

			if (useRoundedCorners && e.RowIndex == -1)
			{
				using (GraphicsPath path = GetRoundedRectanglePath(e.CellBounds, cornerRadius))
				{
					e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

					Brush brush = null;
					try
					{
						if (useHeaderGradient)
						{
							brush = new LinearGradientBrush(e.CellBounds, headerBackColor, headerGradientColor, LinearGradientMode.Vertical);
						}
						else
						{
							brush = new SolidBrush(headerBackColor);
						}

						e.Graphics.FillPath(brush, path);
					}
					finally
					{
						brush?.Dispose();
					}

					if (e.FormattedValue != null)
					{
						TextRenderer.DrawText(e.Graphics, e.FormattedValue.ToString(), e.CellStyle.Font,
							e.CellBounds, headerForeColor, TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
					}

					e.Handled = true;
				}
			}
		}



		protected override void OnRowPrePaint(DataGridViewRowPrePaintEventArgs e)
		{
			base.OnRowPrePaint(e);

			if (this.Rows[e.RowIndex].Selected)
			{
				using (Brush selectionBrush = new SolidBrush(selectedRowColor))
				{
					e.Graphics.FillRectangle(selectionBrush, e.RowBounds);
				}
			}
		}

		private GraphicsPath GetRoundedRectanglePath(Rectangle bounds, int radius)
		{
			GraphicsPath path = new GraphicsPath();
			path.AddArc(bounds.X, bounds.Y, radius, radius, 180, 90);
			path.AddArc(bounds.Right - radius, bounds.Y, radius, radius, 270, 90);
			path.AddArc(bounds.Right - radius, bounds.Bottom - radius, radius, radius, 0, 90);
			path.AddArc(bounds.X, bounds.Bottom - radius, radius, radius, 90, 90);
			path.CloseFigure();
			return path;
		}



		// Custom function(s)

		// UserDeletingRow (ha nem jó, if-else)
		/*protected async override void OnUserDeletingRow(DataGridViewRowCancelEventArgs e)
		{
			var customMessageBox = new CustomMessageBoxForm(
				"Biztosan törölni szeretné a sort?",
				"Sor törlése",
				MessageBoxButtons.YesNo,
				MessageBoxIcon.Warning);

			DialogResult result = customMessageBox.ShowDialog();

			if (result == DialogResult.No)
			{
				e.Cancel = true;
			}

			base.OnUserDeletingRow(e);
		}*/

        protected override void OnAllowUserToAddRowsChanged(EventArgs e)
        {
            base.OnAllowUserToAddRowsChanged(e);
        }
    }
}
