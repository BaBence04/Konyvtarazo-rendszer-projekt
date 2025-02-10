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
                        List<Dictionary<string, string>> resp = (List<Dictionary<string, string>>)await ApiComm.SendPost(new Dictionary<string, string> { { "type", "changeEmplPass" }, { "oldPass", ctbOldPass.Texts }, { "newPass", ctbNewPass.Texts } });
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
    }
}
