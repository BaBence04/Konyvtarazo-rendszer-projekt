using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desktop
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //REMOVE THIS WHEN ITS PROD TIME THIS JUST FOR TESTING
            LoginForm start = new LoginForm();
            LoginForm.main = new MainForm();
            LoginForm.employee = "1";
            LoginForm.empl_uname = "AABBC";
            Application.Run(LoginForm.main);

            
        }
    }
}
