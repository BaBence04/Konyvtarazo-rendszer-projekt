using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desktop
{ 
	public partial class BookLendingPage : Form
	{
        static string book_id, user_id, state;
        static bool allGood = true;
		//status can be booking/book_id/user_id/reservation
        public BookLendingPage(string id, string status)
		{
			InitializeComponent();
            state = status;
			setInfo(id, status);
            
			
		}

        private void backBtn_Click(object sender, EventArgs e)
        {
            if (state == "reservation")
            {
                LoginForm.main.OpenChildForm(new ReservationsPage());
            }
            else
            {
                LoginForm.main.OpenChildForm(LoginForm.main.prev);
            }
            
        }

        private async void cbtnChooseUser_Click(object sender, EventArgs e)
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
                    List<Dictionary<string, string>> response = (List<Dictionary<string, string>>)await ApiComm.SendPost(new Dictionary<string, string> { {"type", "checkPermissions" },{"id", user_id} });
                    if (state == "reservation" && response.First()["reservation"] == "false")
                    {
                        allGood = false;
                        lblHistory.Text = "Ez a felhasználó nem tud már több könyvet előjegyezni";
                    }
                    else if (!pChooseBook.Visible)
                    {
                        cbtnKiad.Enabled = true;
                        GetHistory();
                    }
                   
                }
            }
            
        }

        private async void cbtnKiad_Click(object sender, EventArgs e)
        {
            List<Dictionary<string, string>>output;
            if (state == "reservation")
            {
                output = (List<Dictionary<string, string>>)await ApiComm.SendPost(new Dictionary<string, string> { { "type", "addReservationOrBooking" }, { "ISBN", book_id }, { "userid", user_id } });
                LoginForm.main.OpenChildForm(new ReservationsPage());
            }
            else
            {
                output = (List<Dictionary<string, string>>)await ApiComm.SendPost(new Dictionary<string, string> { { "type", "borrowBook" }, { "user_id", user_id }, { "bookID", book_id }, { "empl_id", LoginForm.employee } });
                LoginForm.main.OpenChildForm(LoginForm.main.prev);
            }
            
            /*if (output.First()["state"]== "siker")
            {
                
            }
            else
            {
                //ERROR MSG WE NEED TO HANDLE IT SOMEHOW
            }*/
        }

        private void cbtnChooseBook_Click(object sender, EventArgs e)
        {
            string search = "userBorrow";
            if (state == "reservation")
            {
                search = "getReservables";
            }
            using (var form = new PopupSelect(search))
            {
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    lblIsbn.Text = form.res1;
                    lblTitle.Text = form.res2;
                    book_id = form.id;
                    pChooseBook.Visible = false;
                    if (!pChooseUser.Visible && allGood)
                    {
                        cbtnKiad.Enabled = true;
                        GetHistory();
                    }
                    
                }
            }
        }

        private async void setInfo(string id, string status)
        {
            if (state != "reservation")
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
                    cbtnKiad.Enabled = true;
                    GetHistory();
                }
                else if (status == "book_id")
                {
                    book_id = id;
                    pChooseUser.Visible = true;
                    lblIsbn.Text = data["ISBN"];
                    lblTitle.Text = data["title"];

                }
                else if (status == "user_id")
                {
                    user_id = id;
                    pChooseBook.Visible = true;
                    lblName.Text = data["name"];
                    lblUname.Text = data["username"];
                }
            }
            else
            {
                pChooseBook.Visible = true;
                pChooseUser.Visible = true;
                cbtnKiad.Text = "Előjegyzés";
            }
        }
        private async void GetHistory()
        {
            if (allGood)
            {
                List<Dictionary<string, string>> resp = (List<Dictionary<string, string>>) await ApiComm.SendPost(new Dictionary<string, string> { {"type", "getHistory" }, {"book_id", book_id }, {"user_id", user_id } });
                if (resp.First()["result"]!="not")
                {
                    lblHistory.Text = $"Ezt a könyvet a felhasználó már olvasta {resp.First()["result"]} napja";
                }
                else
                {
                    lblHistory.Text = "Ezt a könyvet a felhasználó még nem olvasta";
                }
            }
            
            
        }
    }
}
