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
                List<Dictionary<string, string>> resp = (List<Dictionary<string, string>>)await ApiComm.SendPost(new Dictionary<string, string> { { "type", "addUser" }, { "surname", ctbSurname.Texts },{"first_name", ctbFirstName.Texts },{"uname", uname },{"birthdate", dtpBirthDate.Value.ToString("yyyy-MM-dd") },{"email", ctbEmail.Texts },{"phone", ctbPhone.Texts },{"birthplace", ctbBirthplace.Texts },{"address", ctbAddress.Texts }, {"mmn", ctbMmn.Texts } });
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
    }
}
