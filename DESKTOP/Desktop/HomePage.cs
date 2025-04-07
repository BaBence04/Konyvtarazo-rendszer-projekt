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
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }


		private void customButton4_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void quickAddUser_Click(object sender, EventArgs e)
		{
			AddUser addUserForm = new AddUser();
			addUserForm.Show();
		}
	}
}
