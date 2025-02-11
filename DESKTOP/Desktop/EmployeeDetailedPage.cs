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
    public partial class EmployeeDetailedPage : Form
    {
        public EmployeeDetailedPage()
        {
            InitializeComponent();
        }

        private void cbtnLogout_Click(object sender, EventArgs e)
        {
            LoginForm.main.Close();
        }

        private async void cbtnChangePass_Click(object sender, EventArgs e)
        {
            if (ctbNewPass.Texts!="" && ctbNewPassAgain.Texts!="" && ctbOldPass.Texts!="")
            {
                if (ctbNewPass.Texts == ctbNewPassAgain.Texts)
                {
                    if (ctbNewPass.Texts != ctbOldPass.Texts)
                    {
                        List<Dictionary<string, string>> resp = (List<Dictionary<string, string>>)await ApiComm.SendPost(new Dictionary<string, string> { { "type", "changeEmplPass" }, {"empl_id", LoginForm.employee },{ "oldPass", ctbOldPass.Texts }, { "newPass", ctbNewPass.Texts } });
                        if (resp.First()["result"] == "siker")
                        {
                            MessageBox.Show("Sikeresen megváltoztatta a jelszavát");
                            ctbNewPass.Texts = "";
                            ctbNewPassAgain.Texts = "";
                            ctbOldPass.Texts = "";
                        }
                        else
                        {
                            MessageBox.Show("Hibás a régi jelszó");
                        }
                    }
                    else
                    {
                        MessageBox.Show("A régi jelszó megegyezik az új jelszóval");
                    }
                }
                else
                {
                    MessageBox.Show("Az új jelszó nem egyezik meg a két mezőben");
                }
            }
            else
            {
                MessageBox.Show("Az összes mezőt töltse ki");
            }
        }

        private async void EmployeeDetailedPage_Load(object sender, EventArgs e)
        {
            List<Dictionary<string, string>> resp = (List<Dictionary<string, string>>)await ApiComm.SendPost(new Dictionary<string, string> { {"type", "getEmployee" }, {"empl_id", LoginForm.employee } });
            lbName.Text = resp.First()["empl_name"];
            lbUname.Text = resp.First()["empl_uname"];
        }

        private async void cbtnDeleteEmpl_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Biztosan véglegesen deaktiválni szeretné ezt az alkalmazottat?", "Alkalmazott deaktiválása", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                await ApiComm.SendPost(new Dictionary<string, string> { { "type", "deactivateEmpl" }, { "empl_id", LoginForm.employee } });
                LoginForm.main.Close();
            }
        }
    }
}
