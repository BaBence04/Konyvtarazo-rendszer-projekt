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
                var result = await ApiComm.SendPost(values);
                if (result.ToString() == "true")
                {
                    this.Hide();
                    MainForm main = new MainForm();
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
