﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using MySql.Data;

namespace C969_Project
{
    public partial class Login : Form
    {
        int lcid = 1033; // swedish 1053, amercian english 1033
        public string errorMsg = "Username and Password do not match.";
        public Login()
        {
            InitializeComponent();
            
            if (CultureInfo.CurrentUICulture.LCID == lcid)
            {
                this.Text = "Logga In";
                lbl_username.Text = "Användarnamn";
                lbl_password.Text = "Lösenord";
                btn_login.Text = "Logga In";
                btn_cancel.Text = "Annullera";
                errorMsg = "Användarnamn och lösenord passar inte.";
            }
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            string userName = txt_username.Text;
            string pwd = txt_password.Text;
            if (DBHelper.LoginUser(userName, pwd) == true)
            {
                this.Close();
            }
            else
            {
                MessageBox.Show(errorMsg);
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
