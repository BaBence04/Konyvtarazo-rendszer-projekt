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
    public partial class addPublisher : Form
    {
        public addPublisher()
        {
            InitializeComponent();
        }

        private async void cbtnAdd_Click(object sender, EventArgs e)
        {
            List<Dictionary<string, string>> data = (List<Dictionary<string, string>>)await ApiComm.SendPost(new Dictionary<string, string> { { "type", "addPublisher" }, { "name", ctbName.Texts }, { "phone", ctbTel.Texts }, { "email", ctbEmail.Texts }, { "webpage", ctbWeb.Texts } });
            if (data.First()["state"] == "fail")
            {
                MessageBox.Show("Ezzel a névvel már létezik kiadó");
            }
            else
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        
        }

        private void button_CloseLoginForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
