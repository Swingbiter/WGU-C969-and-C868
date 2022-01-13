using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C969_Project
{
    public partial class Main : Form
    {
        public Login loginform;
        public Main()
        {
            InitializeComponent();

            if (DBHelper.loggedIn != true)
            {
                loginform = new Login();
                loginform.Show();
                loginform.FormClosed += LoginFormClosed;
                loginform.TopMost = true;
            }
        }

        private void LoginFormClosed(object sender, FormClosedEventArgs e)
        {
            if (DBHelper.loggedIn == true)
            {
                lbl_welcome.Text = $"Welcome, {DBHelper.currentUserName}";
                panel_hider.Visible = true;
            }
            else
            {
                Application.Exit();
            }
        }
    }
}
