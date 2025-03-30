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
    public partial class AddPublisher : Form
    {
        public AddPublisher()
        {
            InitializeComponent();
			FormDragger.MakeDraggable(this);
            this.BorderColor = Color.FromArgb(36, 72, 85);
            this.BorderWidth = 2;
			ThemeManager.ApplyTheme(this);
		}

        protected override void OnShown(EventArgs e)
        {
            
            base.OnShown(e);
        }

        private async void cbtnAdd_Click(object sender, EventArgs e)
        {
            if (ctbName.Texts != ctbName.PlaceholderText && ctbName.Texts != "" && ctbEmail.Texts != ctbEmail.PlaceholderText && ctbEmail.Texts != "" && ctbTel.Texts != ctbTel.PlaceholderText && ctbTel.Texts != "" && ctbWeb.Texts != ctbWeb.PlaceholderText && ctbWeb.Texts != "")
            {
                List<Dictionary<string, string>> data = (List<Dictionary<string, string>>)await ApiComm.SendPost(new Dictionary<string, string> { { "type", "addPublisher" }, { "name", ctbName.Texts }, { "phone", ctbTel.Texts }, { "email", ctbEmail.Texts }, { "webpage", ctbWeb.Texts } });
                if (data.First()["state"] == "fail")
                {
                    //MessageBox.Show("Ezzel a névvel már létezik kiadó");
					using (CustomMessageBoxForm msgBox = new CustomMessageBoxForm("Ezzel a névvel már létezik kiadó.", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error))
					{
						msgBox.ShowDialog();
					}
				}
                else
                {
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
            
        
        }

        private void button_CloseLoginForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

		[Category("Border")]
        [Browsable(true)]
		public float BorderWidth { get; set; } = 1.0f;
		[Category("Border")]
		[Browsable(true)]
		public Color BorderColor { get; set; } = Color.Black;


		protected override void OnPaint(PaintEventArgs e)
		{
			base.OnPaint(e);
			using (Pen pen = new Pen(BorderColor, BorderWidth))
			{
				Rectangle borderRect = new Rectangle(
					(int)(BorderWidth / 2),
					(int)(BorderWidth / 2),
					(int)(this.ClientSize.Width - BorderWidth),
					(int)(this.ClientSize.Height - BorderWidth)
				);

				e.Graphics.DrawRectangle(pen, borderRect);
			}
		}

	}
}
