using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
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

        private void cbtnChooseUser_Click(object sender, EventArgs e)
        {
            using (var form = new PopupSelect("getUsers"))
            {
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    lblName.Text = form.res1+" "+form.res2;
                    lblUname.Text = form.res3;
                    user_id = form.id;
                    pChooseUser.Visible = false;
                    cbtnKiad.Enabled = true;
                }
            }
            
        }

        private async void cbtnKiad_Click(object sender, EventArgs e)
        {
            var output = (List<Dictionary<string, string>>)await ApiComm.SendPost(new Dictionary<string, string> { { "type", "borrowBook" }, { "user_id", user_id }, { "bookID", book_id }, { "empl_id", LoginForm.employee } });
            if (output.First()["state"]== "siker")
            {
                LoginForm.main.OpenChildForm(LoginForm.main.prev);
            }
            else
            {
                //ERROR MSG WE NEED TO HANDLE IT SOMEHOW
            }
        }

        private void cbtnChooseBook_Click(object sender, EventArgs e)
        {
            using (var form = new PopupSelect("userBorrow"))
            {
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    lblIsbn.Text = form.res1;
                    lblTitle.Text = form.res2;
                    book_id = form.id;
                    pChooseBook.Visible = false;
                    cbtnKiad.Enabled = true;
                }
            }
        }

        private async void setInfo(string id, string status)
		{
            List<Dictionary<string, string>> result = (List<Dictionary<string, string>>)await ApiComm.SendPost(new Dictionary<string, string> { { "type", "borrowInfo" }, { "id", id }, { "state", status } });
            Dictionary<string, string> data = result.First();
            if (status == "booking")
            {
                book_id = id;
                user_id = data["user_id"];
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
