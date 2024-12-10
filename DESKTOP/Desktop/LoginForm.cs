﻿using System;
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
    }
}
