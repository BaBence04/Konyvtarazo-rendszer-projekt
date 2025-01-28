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
	public partial class BookLendingPage : Form
	{
        static string book_id, user_id;
		//status can be booking/book_id/user_id
        public BookLendingPage(string id, string status)
		{
			InitializeComponent();
			setInfo(id, status);
			
		}

        private void backBtn_Click(object sender, EventArgs e)
        {
            LoginForm.main.OpenChildForm(LoginForm.main.prev);
        }

        private async void setInfo(string id, string status)
		{
            List<Dictionary<string, string>> result = (List<Dictionary<string, string>>)await ApiComm.SendPost(new Dictionary<string, string> { { "type", "borrowInfo" }, { "id", id }, { "state", status } });
            Dictionary<string, string> data = result.First();
            if (status == "booking")
            {
                book_id = id;
                lblIsbn.Text = data["ISBN"];
                lblTitle.Text = data["title"];
                lblName.Text = data["name"];
                lblUname.Text = data["username"];
            }
            else if (status == "book_id")
            {
                book_id = id;
                pChooseUser.Visible = true;
                lblIsbn.Text = data["ISBN"];
                lblTitle.Text = data["title"];
            }
            else
            {
                user_id = id;
                pChooseBook.Visible = true;
                lblName.Text = data["name"];
                lblUname.Text = data["username"];
            }
        }
    }
}
