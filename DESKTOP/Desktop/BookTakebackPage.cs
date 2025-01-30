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
	public partial class BookTakebackPage : Form
	{
		static string bookID, userID;
		public BookTakebackPage(string book_id)
		{
			InitializeComponent();
			bookID = book_id;
		}

        private async void BookTakebackPage_Load(object sender, EventArgs e)
        {
			var output = (List<Dictionary<string, string>>)await ApiComm.SendPost(new Dictionary<string, string> { { "type", "returnInfo" }, { "bookID", bookID } });
			Dictionary<string, string> info = output.First();
			lblBookTitle.Text = info["title"];
			lblBookIsbn.Text = info["ISBN"];
			lblUserName.Text = info["name"];
			lblReturnDate.Text = info["end"];
			if (info.Keys.Contains("fee"))
			{
				lblLatency.Text = info["late"];
				lblFee.Text = info["fee"];
			}
			else
			{
                lblLatency.Text = "nincs";
                lblFee.Text = "nincs";
            }
			userID = info["user"];
        }

        private async void btn_Click(object sender, EventArgs e)
        {
			var output = (List<Dictionary<string, string>>)await ApiComm.SendPost(new Dictionary<string, string> { {"type", "returnBook" }, {"user_id",  userID}, {"bookID", bookID }, {"empl_id", LoginForm.employee} });
			//DO THIS PROPERLY WHEN PROD
			Console.WriteLine($"new user that is assigned to this book {output.First()["new"]}");
			LoginForm.main.OpenChildForm(LoginForm.main.prev);
		}
    }
}
