﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Schema;

namespace OAuthLocal
{
    public partial class Oauth_Form : Form
    {
        
        /*
         * This is the first window, what we see if we open the application first
         * 
         * We can choose between login with an existing account 
         * and sign up a new account
         */

        public AuthenticationObject User = null;

        public Oauth_Form()
        {
            InitializeComponent();
        }

        private void login_button_Click(object sender, EventArgs e)
        {
            if (Program.User == null)
            {
                this.Hide();
                LoginForm login_form = new LoginForm();
                login_form.Show(this);
            }
            else
            {
                UserForm form = new UserForm();
                form.Show(this);
            }
        }

        private void signup_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            SignUpForm signup_form = new SignUpForm();
            signup_form.Show(this);
        }
    }
}
