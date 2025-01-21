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
    public partial class UsersPage : Form
    {
        public UsersPage()
        {
            InitializeComponent();
        }

        private void customDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tableLayoutPanel_Users_Paint(object sender, PaintEventArgs e)
        {

        }

        private async void UsersPage_Load(object sender, EventArgs e)
        {
            cdgwUsers.DataSource = await ApiComm.SendPost(new Dictionary<string, string> { { "type", "getUsers" },{"search", "" } });
        }
    }
}
