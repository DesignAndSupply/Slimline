﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;




namespace Slimline_Shopfloor
{
    public partial class Login_Form : Form
    {
        public Login_Form()
        {
            InitializeComponent();
        }
       
    

        private void btn_login_Click(object sender, EventArgs e)
        {
            string userName = txtUsername.Text;
            string passWord = txtPassword.Text;

            Login login = new Login("", "");

            string user = txtUsername.Text;
            string pass = txtPassword.Text;


            if (login.IsLoggedIn(user, pass))
            {

                admin_menu form = new admin_menu();
                form.Show();
                this.WindowState = FormWindowState.Minimized;

            }
            else
            {
                MessageBox.Show("Log in failed please try again!");
            }

        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Return)
            {
                btn_login.PerformClick();
            }
        }

        private void txtUsername_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Return)
            {

                this.ActiveControl = txtPassword;
            }
        }

        private void btn_skip_Click(object sender, EventArgs e)
        {
            Main_menu form = new Main_menu();
            form.Show();
            this.WindowState = FormWindowState.Minimized;
        }

      
    }
}
