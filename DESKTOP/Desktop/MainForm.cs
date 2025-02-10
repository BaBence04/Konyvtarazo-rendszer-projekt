using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;
using System.IO;


namespace Desktop
{
    public partial class MainForm : Form
    {
		public UsersPage usersPage = new UsersPage();
		public AllBooksPage allBooksPage = new AllBooksPage();
		public Dictionary<string, string> system_settings = new Dictionary<string, string>();
		public MainForm()
        {
			InitializeComponent();
			CustomizeDesign();
            ThemeManager.Initialize();
        }

		private async void Form1_Load(object sender, EventArgs e)
		{
            OpenChildForm(new HomePage());
			List<Dictionary<string, string>> temp = (List<Dictionary<string, string>>)await ApiComm.SendPost(new Dictionary<string, string> { { "type", "getSystemSettings" } });
			system_settings = temp.First();
            //WHEN FINAL VERSION UNCOMMENT THIS ALSO NOT REALLY TESTED
            /*
			List<Dictionary<string, string>> reservationResult = (List<Dictionary<string, string>>)await ApiComm.SendPost(new Dictionary<string, string>() { { "type", "deleteExpiredReservations" } });
			string resrvationChanges = resrvationResult.First()["output"];
			List<Dictionary<string, string>> bookingResult = (List<Dictionary<string, string>>)await ApiComm.SendPost(new Dictionary<string, string>() { { "type", "deleteExpiredBookings" } });
			string outputChanges = outputResult.First()["output"];
			if (outputChanges.Length >0 || reservationChanges.Lenth >0)
			{
				changes = changes.Remove(0, 1);
				foreach (string line in changes.Split(';')) {
					string[] data = line.Split(',');
					if (data[2] == "-1")
					{
						data[2] = "nobody";
					}
					Console.WriteLine($"Removes happened: {data[0]}-bookid from {data[1]} to {data[2]}");
				}
			}*/


        }



        private void CustomizeDesign()
		{
			panel_BooksSubMenu.Visible = false;
		}

		private void button_HomePage_Click(object sender, EventArgs e)
		{
			OpenChildForm(new HomePage());
        }
		private void button_Books_Click(object sender, EventArgs e)
		{
			HideAndShowSubmenu();
		}


		private void HideAndShowSubmenu()
		{
			panel_BooksSubMenu.Visible = !panel_BooksSubMenu.Visible;
		}






		private Form activeForm = null;
		public Form prev = null;
		public void OpenChildForm(Form childForm)
		{
            
            if (activeForm != null)
			{
				if (activeForm == usersPage || activeForm == allBooksPage)
				{
					activeForm.Hide();
					
				}
				else
				{
					activeForm.Close();
				}
			}
			prev = activeForm;
            roundedCornerPanel_PageContainer.Controls.Remove(activeForm);
            activeForm = childForm;
			childForm.TopLevel = false;
			childForm.FormBorderStyle = FormBorderStyle.None;
			childForm.Dock = DockStyle.Fill;
			roundedCornerPanel_PageContainer.Controls.Add(childForm);
			roundedCornerPanel_PageContainer.Tag = childForm;
            ThemeManager.ApplyThemeToAllForms();
            childForm.BringToFront();
			childForm.Show();
			childForm.Visible = true;
			panel_BooksSubMenu.Visible = false;
            
        }



		private void button_Users_Click(object sender, EventArgs e)
        {
            OpenChildForm(usersPage);
        }

        private void toggleButton_ThemeChanger_CheckedChanged(object sender, EventArgs e)
        {
			if (!toggleButton_ThemeChanger.Checked)
			{
				ThemeManager.SetTheme("Dark");
			}
			else 
			{
				ThemeManager.SetTheme("Light");
			}

		}

		private void button_BookLending_Click(object sender, EventArgs e)
		{
			//OpenChildForm(new BookLendingPage());
		}

		private void button_BookTakeback_Click(object sender, EventArgs e)
		{
			//OpenChildForm(new BookTakebackPage());
		}

		private void button_AllBooks_Click(object sender, EventArgs e)
		{
			OpenChildForm(allBooksPage);
		}

		private void button_AddBook_Click(object sender, EventArgs e)
		{
			OpenChildForm(new AddBookPage());
		}

		private void button_Publishers_Click(object sender, EventArgs e)
		{
			OpenChildForm(new PublishersPage());
		}

        private void pictureBox_UserPic_Click(object sender, EventArgs e)
        {
			OpenChildForm(new EmployeeDetailedPage());
        }
    }
}
