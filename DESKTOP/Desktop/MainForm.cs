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
using System.Drawing.Text;
using System.Threading;


namespace Desktop
{
    public partial class MainForm : Form
    {
		public UsersPage usersPage = new UsersPage();
		public AllBooksPage allBooksPage = new AllBooksPage();
		public Dictionary<string, string> system_settings = new Dictionary<string, string>();
		

		// currentPage indicator
        private Button _currentActiveButton;
        private readonly Color customBorderColor = Color.FromArgb(10, 123, 106);

		public string latestBooking;
        public MainForm()
        {
			InitializeComponent();
			CustomizeDesign();
            ThemeManager.Initialize();


            InitializeMenu();
        }

		private async void Form1_Load(object sender, EventArgs e)
		{
            OpenChildForm(new HomePage());
			lblEmplUname.Text = LoginForm.empl_uname;
			List<Dictionary<string, string>> temp = (List<Dictionary<string, string>>)await ApiComm.SendPost(new Dictionary<string, string> { { "type", "getSystemSettings" } });
			system_settings = temp.First();
			CheckForBookings();
			
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


        public async Task CheckForBookings()
        {
            while (true)
            {
				//the txt file is temporary we may change if we find better solution
				List<Dictionary<string, string>> resp = (List<Dictionary<string, string>>)await ApiComm.SendPost(new Dictionary<string, string> { {"type", "checkForBookings" } });
				if (resp.First()["result"] == "true")
				{
					pbNewBookings.Visible = true;
				}
				await Task.Delay(TimeSpan.FromMinutes(15));
            }
        }

        //CurrentPAga indicator

        private void InitializeMenu()
        {
            Button[] menuButtons = { button_HomePage, button_Books, button_Users, button_Publishers, btnBookings, btnReservations, btnBorrowings };

            _currentActiveButton = button_HomePage;
            SetActiveButtonStyle(_currentActiveButton);

            foreach (var button in menuButtons)
            {
                button.Click += MenuButton_Click;
            }
        }

        private void MenuButton_Click(object sender, EventArgs e)
        {
            SetInactiveButtonStyle(_currentActiveButton);

            _currentActiveButton = (Button)sender;
            SetActiveButtonStyle(_currentActiveButton);
        }

        private void SetActiveButtonStyle(Button button)
        {
            button.FlatAppearance.BorderSize = 0;

            button.Paint += Button_Paint;
        }

        private void SetInactiveButtonStyle(Button button)
        {
            button.FlatAppearance.BorderSize = 0;

            button.Paint -= Button_Paint;
        }

		

        private void Button_Paint(object sender, PaintEventArgs e)
        {
            Button button = (Button)sender;
			
            if (button == _currentActiveButton)
            {
                e.Graphics.FillRectangle(new SolidBrush(customBorderColor), 0, 0, 5, button.Height);
            }
        }



        private void CustomizeDesign()
		{
			//panel_BooksSubMenu.Visible = false;
		}

		private void button_HomePage_Click(object sender, EventArgs e)
		{
			OpenChildForm(new HomePage());
			CustomizeDesign();
        }
		private void button_Books_Click(object sender, EventArgs e)
		{
            //HideAndShowSubmenu();
            OpenChildForm(allBooksPage);
        }


		/*private void HideAndShowSubmenu()
		{
			panel_BooksSubMenu.Visible = !panel_BooksSubMenu.Visible;
		}*/






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
			//panel_BooksSubMenu.Visible = false;
            
        }



		private void button_Users_Click(object sender, EventArgs e)
        {
            OpenChildForm(usersPage);
            CustomizeDesign();
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
			//OpenChildForm(allBooksPage);
		}

		private void button_AddBook_Click(object sender, EventArgs e)
		{
			//OpenChildForm(new AddBookPage());
		}

		private void button_Publishers_Click(object sender, EventArgs e)
		{
			OpenChildForm(new PublishersPage());
            CustomizeDesign();
        }

        private void pictureBox_UserPic_Click(object sender, EventArgs e)
        {
			OpenChildForm(new EmployeeDetailedPage());
        }

        private void btnBookings_Click(object sender, EventArgs e)
        {
			OpenChildForm(new BookingsPage());
        }

        private void btnReservations_Click(object sender, EventArgs e)
        {
			OpenChildForm(new ReservationsPage());
        }

        private void btnBorrowings_Click(object sender, EventArgs e)
        {
			OpenChildForm(new BorrowingsPage());
        }
    }
}
