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
    public partial class AddUser : Form
    {
        private Random rnd = new Random();
        public AddUser()
        {
            InitializeComponent();
            FormDragger.MakeDraggable(this);
            this.BorderColor = Color.FromArgb(10, 123, 106);
            this.BorderWidth = 2;
        }

        private async void cbtnAdd_Click(object sender, EventArgs e)
        {
            if (ctbAddress.Texts!="" && ctbEmail.Texts!="" && ctbFirstName.Texts != "" && ctbMmn.Texts != "" && ctbPhone.Texts  != "" && ctbSurname.Texts != "" && ctbBirthplace.Texts != "")
            {
                string first = ctbSurname.Texts.Split(' ').ToArray().Length>=2&&ctbSurname.Texts.Split(' ')[0].Length<=3?ctbSurname.Texts.Split(' ')[1]:ctbSurname.Texts;
                string uname = first.ToLower().Remove(2, first.Length - 2)+ctbFirstName.Texts.ToLower().Remove(2, ctbFirstName.Texts.Length - 2);
                List<Dictionary<string, string>> names = (List<Dictionary<string, string>>)await ApiComm.SendPost(new Dictionary<string, string> { {"type", "getUsernames" },{"name", uname} });
                string num;
                do
                {
                    num = rnd.Next(0, 10).ToString() + rnd.Next(0, 10).ToString() + rnd.Next(0, 10).ToString();
                } while (names.Select(x => x["username"]).Contains(uname+num));
                uname += num;
                List<Dictionary<string, string>> resp = (List<Dictionary<string, string>>)await ApiComm.SendPost(new Dictionary<string, string> { { "type", "addUser" }, { "surname", ctbSurname.Texts },{"first_name", ctbFirstName.Texts },{"uname", uname },{"birthdate", cdtpBirthDate.Value.ToString("yyyy-MM-dd") },{"email", ctbEmail.Texts },{"phone", ctbPhone.Texts },{"birthplace", ctbBirthplace.Texts },{"address", ctbAddress.Texts }, {"mmn", ctbMmn.Texts } });
                if (resp.First()["state"] == "Siker")
                {
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Ennek a személynek már van fiókja");
                }
            }
            else
            {
                MessageBox.Show("Kérem minden mezőt töltsön ki");
            }
        }

        private void cbtnBack_Click(object sender, EventArgs e)
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

        private void button_CloseForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
