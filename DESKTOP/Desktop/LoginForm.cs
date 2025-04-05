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
    public partial class LoginForm : Form
    {

        public static string employee, empl_uname;
        public static MainForm main;

        public LoginForm()
        {
            InitializeComponent();
            ThemeManager.Initialize();
            ThemeManager.ApplyTheme(this);
			FormDragger.MakeDraggable(this);

		}

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            //ThemeManager.ApplyTheme(this);
        }

        private void button_CloseLoginForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void customButton1_Click(object sender, EventArgs e)
        {
            loginUser();
            
        }

        private void tbLoginPw_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                loginUser();
            }
        }
        private async void loginUser()
        {
            if (tbLoginUname.Texts != tbLoginUname.PlaceholderText && tbLoginPw.Texts != tbLoginPw.PlaceholderText)
            {
                Dictionary<string, string> values = new Dictionary<string, string>();
                values.Add("username", tbLoginUname.Texts);
                values.Add("passw", tbLoginPw.Texts);
                List<Dictionary<string, string>> result = (List<Dictionary<string, string>>)await ApiComm.SendPost(values);
                if (result.First()["info"] != "false")
                {
                    this.Hide();
                    main = new MainForm();
                    employee = result.First()["info"];
                    main.Closed += (s, args) => this.Close();
                    empl_uname = tbLoginUname.Texts;
                    main.Show();
                }
                else
                {
                    //MessageBox.Show("Helytelen felhasználónév vagy jelszó", "Bejelentkezés hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
					using (CustomMessageBoxForm msgBox = new CustomMessageBoxForm("Helytelen felhasználónév vagy jelszó.", "Bejelentkezés hiba", MessageBoxButtons.OK, MessageBoxIcon.Error))
					{
						msgBox.ShowDialog();
					}
				}
            }
            else
            {
                //MessageBox.Show("Nem adott meg felhasználónevet vagy jelszót", "Bejelentkezés hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
				using (CustomMessageBoxForm msgBox = new CustomMessageBoxForm("Nem adott meg felhasználónevet vagy jelszót.", "Bejelentkezés hiba", MessageBoxButtons.OK, MessageBoxIcon.Error))
				{
					msgBox.ShowDialog();
				}
			}
        }
        private void tbLoginUname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                loginUser();
            }
            
        }
    }
}
