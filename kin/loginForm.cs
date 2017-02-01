﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kin
{
    public partial class loginForm : Form
    {
        public loginForm()
        {
            InitializeComponent();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            string username = uNameTxtBox.Text;
            string pw = pwTxtBox.Text;

            SystemDB sysDB = new SystemDB();
            Boolean valid = sysDB.loginCheck(username,pw);
            if (valid)
            {
                Menu menu = new Menu();
                this.Hide();
                menu.ShowDialog();
            }
            else
            {
                errorLbl.Text = "Wrong username or password!";
            }
           
        }
    }
}
