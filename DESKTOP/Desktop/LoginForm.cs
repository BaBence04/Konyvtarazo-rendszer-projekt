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

        public static string employee;

        public LoginForm()
        {
            InitializeComponent();
            ThemeManager.ApplyTheme(this);
            ThemeManager.SetTheme("Dark");

            
        }

        private void button_CloseLoginForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void customButton1_Click(object sender, EventArgs e)
        {
            if (tbLoginUname.Texts != tbLoginUname.PlaceholderText && tbLoginPw.Texts != tbLoginPw.PlaceholderText)
            {
                Dictionary<string, string> values = new Dictionary<string, string>();
                values.Add("username", tbLoginUname.Texts);
                values.Add("passw", tbLoginPw.Texts);
                List<Dictionary<string, string>> result = (List<Dictionary<string, string>>) await ApiComm.SendPost(values);
                if (result.First()["info"] != "false")
                {
                    this.Hide();
                    MainForm main = new MainForm();
                    employee = result.First()["info"];
                    main.Closed += (s, args) => this.Close();
                    main.Show();
                }
                else
                {
                    MessageBox.Show("Helytelen felhasználónév vagy jelszó", "Bejelentkezés hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Nem adott meg felhasználónevet vagy jelszót", "Bejelentkezés hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
