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
		public MainForm()
        {
			InitializeComponent();
			CustomizeDesign();
            ThemeManager.Initialize();
        }

		private async void Form1_Load(object sender, EventArgs e)
		{
            OpenChildForm(new HomePage());
			//WHEN FINAL VERSION UNCOMMENT THIS
			/*List<Dictionary<string, string>> result = (List<Dictionary<string, string>>)await ApiComm.SendPost(new Dictionary<string, string>() { { "type", "deleteExpiredBookings" } });
			string changes = result.First()["output"];*/
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
		public void OpenChildForm(Form childForm)
		{
            
            if (activeForm != null)
			{
				activeForm.Close();
			}
			activeForm = childForm;
			childForm.TopLevel = false;
			childForm.FormBorderStyle = FormBorderStyle.None;
			childForm.Dock = DockStyle.Fill;
			roundedCornerPanel_PageContainer.Controls.Add(childForm);
			roundedCornerPanel_PageContainer.Tag = childForm;
            ThemeManager.ApplyThemeToAllForms();
            childForm.BringToFront();
			childForm.Show();
			panel_BooksSubMenu.Visible = false;
            
        }



		private void button_Users_Click(object sender, EventArgs e)
        {
            OpenChildForm(new UsersPage());
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
			OpenChildForm(new BookLendingPage());
		}

		private void button_BookTakeback_Click(object sender, EventArgs e)
		{
			OpenChildForm(new BookTakebackPage());
		}

		private void button_AllBooks_Click(object sender, EventArgs e)
		{
			OpenChildForm(new AllBooksPage());
		}

		private void button_AddBook_Click(object sender, EventArgs e)
		{
			OpenChildForm(new AddBookPage());
		}
    }
}
