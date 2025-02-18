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
    public partial class AddEmployee : Form
    {
        private Random rnd = new Random();
        public AddEmployee()
        {
            InitializeComponent();
            FormDragger.MakeDraggable(this);
            this.BorderColor = Color.FromArgb(10, 123, 106);
			this.BorderWidth = 2;
		}

        private async void cbtnAdd_Click(object sender, EventArgs e)
        {
            if (ctbEmplName.Texts != "" && ctbEmplPass.Texts != "" && ctbEmplName.Texts.Split(' ').Length>1)
            {
                string uname = "";
                if (ctbEmplName.Texts.Split(' ').ToArray().Length >= 3 && ctbEmplName.Texts.Split(' ')[0].Length <= 3)
                {
                    uname = ctbEmplName.Texts.Split(' ')[1].ToLower().Remove(2, ctbEmplName.Texts.Split(' ')[1].Length - 2) + ctbEmplName.Texts.Split(' ')[2].ToLower().Remove(2, ctbEmplName.Texts.Split(' ')[2].Length - 2);
                }
                else
                {
                    uname = ctbEmplName.Texts.Split(' ')[0].ToLower().Remove(2, ctbEmplName.Texts.Split(' ')[0].Length - 2) + ctbEmplName.Texts.Split(' ')[1].ToLower().Remove(2, ctbEmplName.Texts.Split(' ')[1].Length - 2);
                }
                List<Dictionary<string, string>> names = (List<Dictionary<string, string>>)await ApiComm.SendPost(new Dictionary<string, string> { {"type", "getEmplUsernames" }, {"name", uname } });
                string num;
                do
                {
                    num = rnd.Next(0, 10).ToString() + rnd.Next(0, 10).ToString() + rnd.Next(0, 10).ToString();
                } while (names.Select(x => x["empl_uname"]).Contains(uname + num));
                uname += num;
                await ApiComm.SendPost(new Dictionary<string, string> { { "type", "addEmployee" }, { "empl_name", ctbEmplName.Texts }, { "empl_uname", uname }, { "pw", ctbEmplPass.Texts } });
                this.Close();
            }
            else
            {
                MessageBox.Show("Minden adatmezőt helyesen töltsön ki");
            }
            

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

        private void button_CloseForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
